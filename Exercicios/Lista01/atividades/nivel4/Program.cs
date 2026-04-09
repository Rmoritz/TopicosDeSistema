using System;

class Carro {
    public string Marca;
    public string Modelo;
    public int Ano;

    public void ExibirDados() {
        Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
    }
}

class Funcionario {
    public string Nome;
    public double Salario;
    public string Cargo;

    public void ExibirDados() {
        Console.WriteLine($"Funcionario: {Nome} | Cargo: {Cargo} | Salario: {Salario}");
    }

    public double CalcularSalarioAnual() {
        return Salario * 12;
    }

    public void AumentarSalario(double percentual) {
        Salario += Salario * (percentual / 100);
    }

    public void DescontarSalario(double valor) {
        Salario -= valor;
    }
}

class Program {
    static void Main() {
        Carro c1 = new Carro();
        c1.Marca = "Toyota";
        c1.Modelo = "Corolla";
        c1.Ano = 2020;
        c1.ExibirDados();

        Funcionario f1 = new Funcionario();
        f1.Nome = "Rafael";
        f1.Cargo = "Desenvolvedor";
        f1.Salario = 1450.00;
        
        f1.ExibirDados();
        Console.WriteLine($"Salario Anual: {f1.CalcularSalarioAnual()}");
        
        f1.AumentarSalario(10);
        f1.DescontarSalario(50);
        f1.ExibirDados();
    }
}