using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Livro{
    private string titulo{get;set;}
    private int anoPublicacao{get;set;}
    private float preco{get;set;}
    private int nota{get;set;}
    private int quantidade{get;set;}
    public List<Autor> listAutor;
    
    public Livro(string titulo, int anoPublicado, float preco, int nota, int quantidade){
        this.titulo = titulo;
        this.anoPublicacao = anoPublicacao;
        this.preco = preco;
        this.nota = nota;
        this.quantidade = quantidade;
        listAutor = new List<Autor>();
    }

    public int atualizaNota(int novaNota){
        return this.nota = novaNota;
    }
    
    public void adicionarAutor(Autor autor){
        listAutor.Add(autor);
    }
}