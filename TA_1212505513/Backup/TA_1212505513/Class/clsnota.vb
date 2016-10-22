Imports System.Data.Odbc
Public Class clsnota

    Private fno_nota As String
    Private ftglnota As Date
    Private fdp As Double
    Private fjnsbyr As String
    Private fno_sp As String

    Public Property pno_nota() As String
        Get
            Return fno_nota
        End Get
        Set(ByVal value As String)
            fno_nota = value
        End Set
    End Property

    Public Property ptglnota() As Date
        Get
            Return ftglnota
        End Get
        Set(ByVal value As Date)
            ftglnota = value
        End Set
    End Property

    Public Property pdp() As Double
        Get
            Return fdp
        End Get
        Set(ByVal value As Double)
            fdp = value
        End Set
    End Property

    Public Property pjnsbyr() As String
        Get
            Return fjnsbyr
        End Get
        Set(ByVal value As String)
            fjnsbyr = value
        End Set
    End Property

    Public Property pno_sp() As String
        Get
            Return fno_sp
        End Get
        Set(ByVal value As String)
            fno_sp = value
        End Set
    End Property

    Public Function autonumber() As String

    End Function

    Public Function cari() As Boolean

    End Function

    Public Function simpan() As Integer

    End Function

    Public Function tampildata(ByVal xData As String) As List(Of clsnota)

    End Function




End Class
