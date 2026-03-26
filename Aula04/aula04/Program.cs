using System;
    class carro{
        public string modelo;
        public string fabricante;
        public string cor;
        public double arro;
        public int ano;
        public bool ligado=false;
        public void exibir(){
            Console.WriteLine($"fabricante {fabricante} modelo {modelo} cor{cor} arro{arro} ano{ano}");
        }
        public void ligar(){
            if(ligado){
                Console.WriteLine("o carro ja está ligado");
            }else{
                Console.WriteLine("ligou!");
                ligado=true;
            }
        }    
        public void desligar(){
            if(ligado){
                Console.WriteLine("Desligou");
                ligado=false;
            }else{
                Console.WriteLine("Ja está desligado");
            }
        }


    }


    class livro{
        public string titulo;
        public int ano;
        public bool disponivel=true;



        public void exibir(){
            Console.WriteLine($"Titulo: {titulo}, ano: {ano}, Disponivel: {disponivel}");
        }
        public void emprestar(){
            if(disponivel){
                Console.WriteLine("Livro empretado com sucesso!");
                disponivel=false;
            }else{
                Console.WriteLine("Livro indisponivel");
            }
        }
        public void devolver(){
            if(disponivel){
                Console.WriteLine("livro não foi emprestado");
            } else{
                Console.WriteLine("Livro devolvido com sucesso!");
                disponivel=true;
            }
        }
    }




class Program {
    static void Main(){
        carro c1= new carro();
        c1.fabricante="renault";
        c1.modelo="clio";
        c1.cor="branco";
        c1.arro=22.5;
        c1.ano=6767;

        c1.exibir();
    
        c1.ligar();
        c1.ligar();
        c1.desligar();
        c1.desligar();

        livro l1=new livro();
        l1.titulo="A volta dos que não foram";
        l1.ano=6767;
        l1.exibir();
        l1.devolver();
        l1.emprestar();

        livro[] biblioteca=new livro[3];

        biblioteca[0]=l1;
        biblioteca[1]=l1;

        biblioteca[1].devolver();
    }
}