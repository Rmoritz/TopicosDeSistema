using System;
class livro{
    public String autor;
    public String titulo;
    public int ano;
}
class emprestimo{
    
    public livro livro;
    public String dataEmprestimo;
    public String dataDevolução;

}


class program{

    static void Main(){
        livro l1=new livro();
        l1.autor="Davi brito";
        l1.titulo="a volta dos que nao foram";
        l1.ano=2067;
        emprestimo e1=new emprestimo();
        e1.livro=l1;
        e1.DataEmprestimo = "09/05/2026";
        e1.DataDevolucao = "16/05/2026";
        
    }
    
}


