Imports System.Data.Odbc
Public Class clskurir

    Private fkd_kur As String
    Private fnm_kur As String
    Private ftlpkur As String
    Private falmtkur As String

    Public Property pkd_kur() As String
        Get
            Return fkd_kur
        End Get
        Set(ByVal value As String)
            fkd_kur = value
        End Set
    End Property

    Public Property pnm_kur() As String
        Get
            Return fnm_kur
        End Get
        Set(ByVal value As String)
            fnm_kur = value
        End Set
    End Property

    Public Property ptlpkur() As String
        Get
            Return ftlpkur
        End Get
        Set(ByVal value As String)
            ftlpkur = value
        End Set
    End Property

    Public Property palmtkur() As String
        Get
            Return falmtkur
        End Get
        Set(ByVal value As String)
            falmtkur = value
        End Set
    End Property


    Public Function autonumber() As String
        Dim nilai As String
        sql = "select max(kd_kur) as max from kurir"
        cmmd = New OdbcCommand(sql, MyCn)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.IsDBNull(0) Then
            nilai = "K01"
        Else
            nilai = Val(Mid(Bacadata.Item("max"), 2, 2)) + 1
            If Len(nilai) = 1 Then
                nilai = "K" + nilai
            End If
        End If
        Bacadata.Close()
        Return nilai
    End Function

    Public Function cari() As Boolean
        sql = "select * from kurir where kd_kur=@1"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fkd_kur)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.HasRows = True Then
            fkd_kur = Bacadata.Item("kd_kur")
            fnm_kur = Bacadata.Item("nm_kur")
            ftlpkur = Bacadata.Item("tlpkur")
            falmtkur = Bacadata.Item("almtkur")
            Return True
        Else
            Bacadata.Close()
            Return False
        End If
    End Function

    Public Function hapus() As Integer
        sql = "delete from kurir where kd_kur=@1"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fkd_kur)
        Return cmmd.ExecuteNonQuery
    End Function

    Public Function simpan() As Integer
        sql = "insert into kurir(kd_kur,nm_kur,tlpkur,almtkur) values(@1,@2,@3,@4)"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fkd_kur)
        cmmd.Parameters.AddWithValue("@2", fnm_kur)
        cmmd.Parameters.AddWithValue("@3", ftlpkur)
        cmmd.Parameters.AddWithValue("@4", falmtkur)
        Return cmmd.ExecuteNonQuery
    End Function

    Public Function tampildata(ByVal xnama_kurir As String) As List(Of clskurir)
        Dim viloid As String
        Dim baca_class As New List(Of clskurir)

        viloid = "select kd_kur,nm_kur,tlpkur,almtkur"
        viloid &= " from kurir where nm_kur like '%" & xnama_kurir & "%'"
        cmmd = New OdbcCommand(viloid, MyCn)

        Bacadata = cmmd.ExecuteReader
        If Bacadata.HasRows Then
            While Bacadata.Read
                Dim objTemp As New clskurir
                objTemp.fkd_kur = Bacadata.Item("kd_kur")
                objTemp.fnm_kur = Bacadata.Item("nm_kur")
                objTemp.ftlpkur = Bacadata.Item("tlpkur")
                objTemp.falmtkur = Bacadata.Item("almtkur")
                baca_class.Add(objTemp)
            End While
        End If
        Bacadata.Close() : Return baca_class
    End Function

    Public Function ubah() As Integer
        sql = "update kurir set nm_kur=@1, tlpkur=@2, almtkur=@3, kd_kur=@4"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fnm_kur)
        cmmd.Parameters.AddWithValue("@2", ftlpkur)
        cmmd.Parameters.AddWithValue("@3", falmtkur)
        cmmd.Parameters.AddWithValue("@4", fkd_kur)
        Return cmmd.ExecuteNonQuery
    End Function
End Class
