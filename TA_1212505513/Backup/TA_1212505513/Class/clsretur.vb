Imports System.Data.Odbc
Public Class clsretur

    Private fno_ret As String
    Private ftglret As Date
    Private fno_sj As String

    Public Property pno_ret() As String
        Get
            Return fno_ret
        End Get
        Set(ByVal value As String)
            fno_ret = value
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

    Public Property ptglret() As Date
        Get
            Return ftglret
        End Get
        Set(ByVal value As Date)
            ftglret = value
        End Set
    End Property


    Public Function autonumber() As String

    End Function


    Public Function cari() As Boolean

    End Function






    Public Function simpan() As Integer

    End Function


    Public Function tampildata(ByVal xData As String) As List(Of clsretur)

    End Function




End Class
