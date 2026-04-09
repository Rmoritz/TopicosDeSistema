using System;

class Program {
    static void Main() {
        Carro[] garagem = new Carro[3];
        int somaAnos = 0;
        int carrosCadastrados = 0;

        for (int i = 0; i < garagem.Length; i++) {
            garagem[i] = new Carro();
            
            Console.Write($"Marca do carro {i}: ");
            garagem[i].Marca = Console.ReadLine();
            
            Console.Write($"Modelo do carro {i}: ");
            garagem[i].Modelo = Console.ReadLine();
            
            Console.Write($"Ano do carro {i}: ");
            garagem[i].Ano = int.Parse(Console.ReadLine());
            
            somaAnos += garagem[i].Ano;
            carrosCadastrados++;
        }

        Console.WriteLine("\nCarros cadastrados:");
        for (int i = 0; i < garagem.Length; i++) {
            if (garagem[i] != null) {
                Console.Write($"[{i}] ");
                garagem[i].ExibirDados();
            }
        }

        Console.WriteLine($"\nMedia dos anos: {somaAnos / (double)carrosCadastrados}");

        Console.WriteLine("\nDigite o indice (0, 1 ou 2) do carro que deseja remover:");
        int indice = int.Parse(Console.ReadLine());

        if (indice >= 0 && indice < garagem.Length && garagem[indice] != null) {
            garagem[indice] = null;
            Console.WriteLine("Carro removido com sucesso!");
        } else {
            Console.WriteLine("Indice invalido ou vaga ja esta vazia.");
        }

        Console.WriteLine("\nGaragem atualizada:");
        for (int i = 0; i < garagem.Length; i++) {
            if (garagem[i] != null) {
                Console.Write($"[{i}] ");
                garagem[i].ExibirDados();
            } else {
                Console.WriteLine($"[{i}] --- VAGA VAZIA ---");
            }
        }
    }
}