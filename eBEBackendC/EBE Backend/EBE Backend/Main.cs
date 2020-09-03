using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using EBE_Backend.Classes;
using MySql.Data.MySqlClient;


namespace EBE_Backend
{
    class MainClass
    {
        static void Main()
        {
            string consoleInput;

            do
            {
                Console.WriteLine("ler, cadastrar ou deletar");
                consoleInput = Console.ReadLine();

                if (consoleInput == "ler")
                {
                    Comandos.ReadUserTable();
                }

                if (consoleInput == "cadastrar")
                {
                    Console.WriteLine("Digite nome, data de nascimento, nivel de acesso, email e senha:");

                    string[] input = Console.ReadLine().Split(',');

                    Console.WriteLine(input[0] + input[1] + input[2] + input[3] + input[4]);

                    Comandos.CadastrarUser(input[0], input[1], input[2], input[3], input[4]);

                }
                if(consoleInput == "deletar")
                {
                    Console.WriteLine("Digite o id");
                    var id = Console.ReadLine();

                    Comandos.DeleteUser(Int32.Parse(id));
                }
                
            } while (consoleInput != "exit");


        }
    }

}