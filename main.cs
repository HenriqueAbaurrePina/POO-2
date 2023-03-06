using System;

class Banco {
    static void Main(){
        Conta Conta1 = new Conta();
        Conta1.Saldo = 10;
        Console.WriteLine(Conta1.Saldo);
        Conta1.Sacar = 5;
        Console.WriteLine(Conta1.Saldo);
    }
}
