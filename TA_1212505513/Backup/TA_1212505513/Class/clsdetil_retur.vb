Imports System.Data.Odbc
Public Class clsdetil_retur

    Private fkd_brg As String
    Private fno_ret As String
    Private fno As Integer
    Private fjmlret As Integer
    Private fket As String
    Private fjnsganti As String

    Public Property pkd_brg() As String
        Get
            Return fkd_brg
        End Get
        Set(ByVal value As String)
            fkd_brg = value
        End Set
    End Property

    Public Property pno_ret() As String
        Get
            Return fno_ret
        End Get
        Set(ByVal value As String)
            fno_ret = value
        End Set
    End Property

    Public Property pno() As Integer
        Get
            Return fno
        End Get
        Set(ByVal value As Integer)
            fno = value
        End Set
    End Property

    Public Property pjmlret() As Integer
        Get
            Return fjmlret
        End Get
        Set(ByVal value As Integer)
            fjmlret = value
        End Set
    End Property

    Public Property pket() As String
        Get
            Return fket
        End Get
        Set(ByVal value As String)
            fket = value
        End Set
    End Property

    Public Property pjnsganti() As String
        Get
            Return fjnsganti
        End Get
        Set(ByVal value As String)
            fjnsganti = value
        End Set
    End Property

    Public Function cari() As Boolean
        sql = "select * from detil_retur where no_ret=@1"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_ret)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.HasRows = True Then
            fno_ret = Bacadata.Item("no_ret")
            fkd_brg = Bacadata.Item("kd_brg")
            fno = Bacadata.Item("no")
            fjmlret = Bacadata.Item("jmlret")
            fket = Bacadata.Item("ket")
            fjnsganti = Bacadata.Item("jnsganti")
            Return True
        Else
            Bacadata.Close()
            Return False
        End If
    End Function


    Public Function simpan() As Integer
        sql = "insert into detil_retur(no_ret,kd_brg,no,jmlret,ket,jnsganti) values(@1,@2,@3,@4,@5,@6)"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_ret)
        cmmd.Parameters.AddWithValue("@2", fkd_brg)
        cmmd.Parameters.AddWithValue("@3", fno)
        cmmd.Parameters.AddWithValue("@4", fjmlret)
        cmmd.Parameters.AddWithValue("@5", fket)
        cmmd.Parameters.AddWithValue("@6", fjnsganti)
        Return cmmd.ExecuteNonQuery
    End Function

    Public Function tampildata(ByVal xData As String) As List(Of clsdetil_retur)
        Dim viloid As String
        Dim baca_class As New List(Of clsdetil_retur)

        viloid = "select * from detil_retur where no_ret like '%" & xData & "%'"
        cmmd = New OdbcCommand(viloid, MyCn)

        Bacadata = cmmd.ExecuteReader
        If Bacadata.HasRows Then
            While Bacadata.Read
                Dim objTemp As New clsdetil_retur
                objTemp.fno_ret = Bacadata.Item("no_ret")
                objTemp.fkd_brg = Bacadata.Item("kd_brg")
                objTemp.fno = Bacadata.Item("no")
                objTemp.fjmlret = Bacadata.Item("jmlret")
                objTemp.fket = Bacadata.Item("ket")
                objTemp.fjnsganti = Bacadata.Item("jnsganti")
                baca_class.Add(objTemp)
            End While
        End If
        Bacadata.Close() : Return baca_class
    End Function
End Class
