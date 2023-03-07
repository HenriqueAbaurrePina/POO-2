using System;
using System.Collections.Generic;

class Banco {
    static void Main(){
        bool online = true;
        Conta Conta1 = new Conta();
        Console.WriteLine("Digite o seu Nome para criação da conta: \n");
        Conta1.Nome = Console.ReadLine();
        Console.WriteLine("Digite o seu CPF para criação da conta: \n");
        Conta1.Cpf = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Bem vindo ao Banco senhor/a " + Conta1.Nome);
        Conta1.Saldo = 1000;
        while (online == true){
            Console.WriteLine("Digite o numero da operação desejada:\n1: Saldo\n2: Saque\n3: Deposito\n4: Extrato\n5: Sair");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch(menu){
                case 1:
                    Console.Clear();
                    Console.WriteLine("O saldo da sua conta é de: " + Conta1.Saldo);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Digite o valor do saque que deseja fazer:\n");
                    int saque1 = Convert.ToInt32(Console.ReadLine());
                    if (saque1 > Conta1.Saldo){
                        Console.Clear();
                        Console.WriteLine("Valor do saque invalido.");
                        break;
                    }else{
                        Console.Clear();
                        Conta1.Sacar(saque1);
                        Console.WriteLine("Saque concluido.\nNovo saldo = " + Conta1.Saldo);
                        break;
                    }
                case 3:
                    Console.Clear();
                    Console.WriteLine("Digite o valor que deseja depositar na conta:\n");
                    int deposito1 = Convert.ToInt32(Console.ReadLine());
                    if (deposito1 < 0){
                        Console.Clear();
                        Console.WriteLine("Deposito de valor negativo invalido.");
                        break;
                    }else{
                        Console.Clear();
                        Conta1.Depositar(deposito1);
                        Console.WriteLine("Deposito concluido.\nNovo saldo = " + Conta1.Saldo);
                        break;
                    }
                case 4:
                    Console.Clear();
                    Conta1.Extrato();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Você tem certeza que deseja sair ?\n1: Sair\n2: Não Sair");
                    int confirmacao = Convert.ToInt32(Console.ReadLine());
                    if(confirmacao == 1){
                        online = false;
                        Console.Clear();
                        Console.WriteLine("Obrigado por usar o banco.");
                        break;
                    }else{
                        Console.WriteLine("Voltando para as operação.");
                        break;
                    }
                default:
                    Console.Clear();
                    Console.WriteLine("Favor escolha um numero de operação valido.");
                    break;
            }
            
        }
    }
}
