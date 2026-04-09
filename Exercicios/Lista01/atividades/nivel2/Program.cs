using System;

class Program {
    static void Main() {
        Console.WriteLine("Ex 5: Digite um numero:");
        int num5 = int.Parse(Console.ReadLine());
        if (num5 > 0) Console.WriteLine("Positivo");
        else if (num5 < 0) Console.WriteLine("Negativo");
        else Console.WriteLine("Zero");

        Console.WriteLine("\nEx 6: Digite um numero para a tabuada:");
        int num6 = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine($"{num6} x {i} = {num6 * i}");
        }

        Console.WriteLine("\nEx 7: Digite 5 numeros:");
        int soma7 = 0;
        for (int i = 0; i < 5; i++) {
            soma7 += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Soma: {soma7} | Media: {soma7 / 5.0}");

        Console.WriteLine("\nEx 8: Digite numeros para somar (0 para sair):");
        int soma8 = 0, num8;
        do {
            num8 = int.Parse(Console.ReadLine());
            soma8 += num8;
        } while (num8 != 0);
        Console.WriteLine($"Soma total: {soma8}");
    }
}