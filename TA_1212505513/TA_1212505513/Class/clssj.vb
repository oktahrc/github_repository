Imports System.Data.Odbc
Public Class clssj

    Private fno_sj As String
    Private ftglsj As Date
    Private fno_kwit As String
    Private fkd_kur As String

    Public Property pkd_kur() As String
        Get
            Return fkd_kur
        End Get
        Set(ByVal value As String)
            fkd_kur = value
        End Set
    End Property

    Public Property pno_kwit() As String
        Get
            Return fno_kwit
        End Get
        Set(ByVal value As String)
            fno_kwit = value
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

    Public Property ptglsj() As Date
        Get
            Return ftglsj
        End Get
        Set(ByVal value As Date)
            ftglsj = value
        End Set
    End Property


    Public Function autonumber() As String

    End Function


    Public Function cari() As Boolean

    End Function






    Public Function simpan() As Integer

    End Function


    Public Function tampildata(ByVal xData As String) As List(Of clssj)

    End Function




End Class
