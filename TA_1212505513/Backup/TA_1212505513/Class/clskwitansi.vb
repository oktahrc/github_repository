Imports System.Data.Odbc
Public Class clskwitansi

    Private fno_kwit As String
    Private ftglkwit As Date
    Private fno_nota As String

    Public Property pno_kwit() As String
        Get
            Return fno_kwit
        End Get
        Set(ByVal value As String)
            fno_kwit = value
        End Set
    End Property

    Public Property ptglkwit() As Date
        Get
            Return ftglkwit
        End Get
        Set(ByVal value As Date)
            ftglkwit = value
        End Set
    End Property

    Public Property pno_nota() As String
        Get
            Return fno_nota
        End Get
        Set(ByVal value As String)
            fno_nota = value
        End Set
    End Property


    Public Function autonumber() As String

    End Function


    Public Function cari() As Boolean

    End Function






    Public Function simpan() As Integer

    End Function


    Public Function tampildata(ByVal xData As String) As List(Of clskwitansi)

    End Function




End Class
