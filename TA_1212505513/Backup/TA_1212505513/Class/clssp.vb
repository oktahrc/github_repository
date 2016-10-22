Imports System.Data.Odbc
Public Class clssp

    Private fno_sp As String
    Private ftglsp As Date
    Private fkd_cus As String
    Private falmtkrm As String
    Private ftgl_krm As Date

    Public Property palmtkrm() As String
        Get
            Return falmtkrm
        End Get
        Set(ByVal value As String)
            falmtkrm = value
        End Set
    End Property

    Public Property pkd_cus() As String
        Get
            Return fkd_cus
        End Get
        Set(ByVal value As String)
            fkd_cus = value
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

    Public Property ptgl_krm() As Date
        Get
            Return ftgl_krm
        End Get
        Set(ByVal value As Date)
            ftgl_krm = value
        End Set
    End Property

    Public Property ptglsp() As Date
        Get
            Return ftglsp
        End Get
        Set(ByVal value As Date)
            ftglsp = value
        End Set
    End Property


    Public Function autonumber() As String

    End Function


    Public Function cari() As Boolean

    End Function


    Public Function simpan() As Integer

    End Function


    Public Function tampildata(ByVal xData As String) As List(Of clssp)

    End Function
End Class
