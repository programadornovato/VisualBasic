Public Class Humano
    Inherits Animal
    Public Overrides Sub comer()
        Console.WriteLine("Los humanos comen en plato")
    End Sub
    Public Overrides Sub correr()
        Console.WriteLine("Los humanos corren con tenis")
    End Sub

End Class
