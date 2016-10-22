Imports System.Data.Odbc
Public Class clsdetil_sj

    Private fno_sj As String
    Private fkd_brg As String
    Private fjmlkrm As Integer

    Public Property pkd_brg() As String
        Get
            Return fkd_brg
        End Get
        Set(ByVal value As String)
            fkd_brg = value
        End Set
    End Property

    Public Property pno_sj() As String
        Get
            Return fno_sj
        End Get
        Set(ByVal value As String)
            fno_sj = value
        End Set
    End Property

    Public Property pjmlkm() As Integer
        Get
            Return fjmlkrm
        End Get
        Set(ByVal value As Integer)
            fjmlkrm = value
        End Set
    End Property


    Public Function cari() As Boolean
        sql = "select * from detil_sj where no_sj=@1"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_sj)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.HasRows = True Then
            fno_sj = Bacadata.Item("kd_brg")
            fkd_brg = Bacadata.Item("kd_brg")
            fjmlkrm = Bacadata.Item("jmlkrm")
            Return True
        Else
            Bacadata.Close()
            Return False
        End If
    End Function


    Public Function simpan() As Integer
        sql = "insert into detil_sj(no_sj,kd_brg,jmlkrm) values(@1,@2,@3)"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_sj)
        cmmd.Parameters.AddWithValue("@2", fkd_brg)
        cmmd.Parameters.AddWithValue("@3", fjmlkrm)
        Return cmmd.ExecuteNonQuery
    End Function


    Public Function tampildata(ByVal xData As String) As List(Of clsdetil_sj)
        Dim viloid As String
        Dim baca_class As New List(Of clsdetil_sj)

        viloid = "select * from detil_sj where no_sj like '%" & xData & "%'"
        cmmd = New OdbcCommand(viloid, MyCn)

        Bacadata = cmmd.ExecuteReader
        If Bacadata.HasRows Then
            While Bacadata.Read
                Dim objTemp As New clsdetil_sj
                objTemp.fno_sj = Bacadata.Item("no_sj")
                objTemp.fkd_brg = Bacadata.Item("kd_brg")
                objTemp.fjmlkrm = Bacadata.Item("jmlkrm")
                baca_class.Add(objTemp)
            End While
        End If
        Bacadata.Close() : Return baca_class
    End Function
End Class
