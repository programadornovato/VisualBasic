Public Class Carro
    Private matricula As String
    Private marca As String
    Private modelo As String
    Public Sub New(_matricula As String, _marca As String, _modelo As String)
        matricula = _matricula
        marca = _marca
        modelo = _modelo
    End Sub
    Public Overridable Function retornarDatos()
        Return "Matricula=" & matricula & " Marca=" & marca & " Modelo=" & modelo
    End Function
    Public Function getMarca()
        Return marca
    End Function
    Public Function getModelo()
        Return modelo
    End Function
    Public Function getMatricula()
        Return matricula
    End Function
End Class
