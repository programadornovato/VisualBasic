Public Class Perro
    Inherits Animal
    Public Overrides Sub comer()
        Console.WriteLine("Los perros comen en plato en el piso")
    End Sub
    Public Overrides Sub correr()
        Console.WriteLine("Los perros corren detras de los humanos")
    End Sub

End Class
