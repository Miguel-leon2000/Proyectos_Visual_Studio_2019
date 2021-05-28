Imports System

Module Program
    Sub Main(args As String())

        Const IVA As Double = 0.16

        Console.WriteLine("Inserte el valor de un producto")
        Dim producto As Double = Console.ReadLine()

        Dim valorIVA As Double = producto * IVA
        Dim valorFinal As Double = producto + valorIVA

        Console.WriteLine("El valor del IVA del prducto es: " & "$" & valorIVA & " pesos")

        Console.WriteLine("El valor final es: " & "$" & valorFinal & " pesos")

        Console.ReadLine()

    End Sub
End Module
