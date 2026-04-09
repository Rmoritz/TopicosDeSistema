using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite um numero: ");
        int num = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"O dobro do numero é {num * 2}");
    }
}