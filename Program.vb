Imports System

Module Program
    Sub Main()
        'Vamos desenvolver um sistema para calcular o reajuste de sal�rio
        Dim funcionario As String
        Dim salario, reajuste, novosalario As Double

        Console.WriteLine("Digite o nome do funcion�rio? ")
        funcionario = Console.ReadLine()

        Console.WriteLine("Digite o sal�rio atual: ")
        salario = Console.ReadLine()

        Console.WriteLine("Digite o percentual de reajuste: (sem '%')")
        reajuste = Console.ReadLine()

        novosalario = salario + salario * reajuste / 100

        Console.WriteLine("O novo sal�rio do funcion�rio " & funcionario & " � de: " & novosalario)
    End Sub
End Module
