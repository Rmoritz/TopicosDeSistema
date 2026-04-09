using System;

class Program {
    static void Main() {
        int[] numeros = new int[5];
        int soma = 0;
        int maior = int.MinValue;

        Console.WriteLine("Digite 5 numeros:");
        for (int i = 0; i < 5; i++) {
            numeros[i] = int.Parse(Console.ReadLine());
            soma += numeros[i];
            
            if (numeros[i] > maior) {
                maior = numeros[i];
            }
        }

        Console.WriteLine("\nValores digitados:");
        for (int i = 0; i < 5; i++) {
            Console.WriteLine(numeros[i]);
        }

        Console.WriteLine($"Maior valor: {maior}");
        Console.WriteLine($"Media: {soma / 5.0}");
    }
}