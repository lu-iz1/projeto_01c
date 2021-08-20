Imports System

Module Program
    Sub Main()
        'Vamos desenvolver um sistema para calcular o reajuste de salário
        Dim funcionario As String
        Dim salario, reajuste, novosalario As Double

        Console.WriteLine("Digite o nome do funcionário? ")
        funcionario = Console.ReadLine()

        Console.WriteLine("Digite o salário atual: ")
        salario = Console.ReadLine()

        Console.WriteLine("Digite o percentual de reajuste: (sem '%')")
        reajuste = Console.ReadLine()

        novosalario = salario + salario * reajuste / 100

        Console.WriteLine("O novo salário do funcionário " & funcionario & " é de: " & novosalario)
    End Sub
End Module
