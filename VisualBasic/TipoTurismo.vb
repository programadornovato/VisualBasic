Public Class TipoTurismo
    Inherits Carro
    Private numeroPuertas As Integer
    Public Sub New(_matricula As String, _marca As String, _modelo As String, _numeroPuertas As Integer)
        MyBase.New(_matricula, _marca, _modelo)
        numeroPuertas = _numeroPuertas
    End Sub
    Public Overrides Function retornarDatos()
        Return "Matricula=" & getMatricula() & " Marca=" & getMarca() & " Modelo=" & getModelo() & " Numero Puertas=" & numeroPuertas
    End Function

End Class
