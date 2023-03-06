using System;

class Conta{
    private string nome;
    private string cpf;
    private double saldo;
    //private double extrato;
    
    public Conta(){
        Nome = "";
        Cpf = "";
        Saldo = 0;
    }    
    public string Nome 
    { 
        get {return nome;}
        set {nome = value;}
    }

    public string Cpf 
    { 
        get {return cpf;}
        set {cpf = value;}
    }

    public double Saldo 
    { 
        get {return saldo;}
        set {saldo = value;}
    }

    public double Sacar (double valor) {
        return Saldo = Saldo - valor;
        
    }
}
