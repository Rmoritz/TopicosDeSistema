using System;

class Program{
    static void Main(){
        int soma, subtracao, multiplicacao;

        Console.WriteLine("Digite um numero");
        int num1=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite outro numero");
        int num2=int.Parse(Console.ReadLine());
        
        soma=num1+num2;
        subtracao=num1-num2;
        multiplicacao=num1*num2;            
        
        Console.WriteLine($"o resultado da soma é: {soma}");
        Console.WriteLine($"O resultado da subtraçao é: {subtracao}");
        Console.WriteLine($"O resultado da mutiplicacao é: {multiplicacao}");
        
        if(num2==0){
            Console.WriteLine("Não tem como dividir por 0");
        } else{
            Console.WriteLine($"O resultado da divisao é: {num1/num2}");
        }
    }
}