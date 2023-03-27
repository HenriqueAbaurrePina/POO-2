using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Contato{
    private string tipo {get;set;}
    private string contato {get;set;}
    
    public Contato(string tipo, string contato){
        this.tipo = tipo;
        this.contato = contato;
    }
}