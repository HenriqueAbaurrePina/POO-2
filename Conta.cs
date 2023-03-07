using System;
using System.Collections.Generic;

class Conta{
    private string nome;
    private string cpf;
    private double saldo;
    List<(string, double)> transacoes = new List<(string, double)>();

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
        transacoes.Add(("Saque", valor));
        return Saldo = Saldo - valor;
        
    }
    public double Depositar (double valor) {
        transacoes.Add(("Deposito", valor));
        return Saldo = Saldo + valor;
        
    }
    
    public void Extrato()
    {
        Console.WriteLine("Transações realizadas:");
        foreach (var transacao in transacoes) {
            Console.WriteLine($"---------------\n{transacao.Item1}: R${transacao.Item2}\n");
        }
        Console.WriteLine($"---------------\nSaldo atual: R${saldo}");
    }
}
