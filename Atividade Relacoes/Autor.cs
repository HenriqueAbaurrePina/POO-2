using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Autor {
    
    private string nome {get;set;}
    private string abreviatura {get;set;}
    private Contato Dono {get;set;}
    public List<Contato> listContato;
    
    
    public Autor (string nome, string abreviatura){
        this.nome = nome;
        this.abreviatura = abreviatura;
        listContato = new List<Contato>();
    }
    
    public void adicionarContato(string tipo, string contato){
        Dono = new Contato(tipo,contato);
        listContato.Add(Dono);
    }
    
}