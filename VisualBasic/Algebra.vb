Namespace Algebra
    Public Class Matematicas
        Private n1 As Integer
        Private n2 As Integer
        Public Sub New(_n1 As Integer, _n2 As Integer)
            n1 = _n1
            n2 = _n2
        End Sub
        Public Function suma()
            Return n1 + n2
        End Function
    End Class
End Namespace