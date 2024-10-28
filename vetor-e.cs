using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int maior, menor;

        
        Console.WriteLine("Digite 10 números inteiros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        
        maior = numeros[0];
        menor = numeros[0];

        
        for (int i = 1; i < 10; i++)
        {
            if (numeros[i] > maior)
                maior = numeros[i];
            if (numeros[i] < menor)
                menor = numeros[i];
        }

        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
    }
}
