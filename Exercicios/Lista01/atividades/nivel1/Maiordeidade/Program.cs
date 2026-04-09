using System;
    class Program{
        static void Main(){
            Console.WriteLine("Digite sua idade: ");
            int idade=int.Parse(Console.ReadLine());
            if(idade>=18){
                Console.WriteLine("É maior de idade");
            }else{
                Console.WriteLine("Voce e menor de idade");
            }

        }
    }