Public Class Estudiantes
    Inherits Personas
    Private codigoEstudiante As String
    Private calificacion As Double
    Private salon As String

    Public Sub New(_nombre As String, _apellido As String, _edad As Integer, _codigoEstudiante As String, _calificacion As Double, _salon As String)
        MyBase.New(_nombre, _apellido, _edad)
        codigoEstudiante = _codigoEstudiante
        calificacion = _calificacion
        salon = _salon
    End Sub
    Public Function getCodigoEstudiante()
        Return codigoEstudiante
    End Function
    Public Function getCalificacion()
        Return calificacion
    End Function
    Public Function getSalon()
        Return salon
    End Function
End Class
