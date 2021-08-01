Public Class TipoFurgoneta
    Inherits Carro
    Private carga As Integer
    Public Sub New(_matricula As String, _marca As String, _modelo As String, _carga As Integer)
        MyBase.New(_matricula, _marca, _modelo)
        carga = _carga
    End Sub
    Public Overrides Function retornarDatos()
        Return "Matricula=" & getMatricula() & " Marca=" & getMarca() & " Modelo=" & getModelo() & " Carga=" & carga
    End Function

End Class
