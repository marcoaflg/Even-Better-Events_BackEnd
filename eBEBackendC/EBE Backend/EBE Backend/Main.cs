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
                Console.WriteLine("ler, ler id, cadastrar, deletar ou att");
                consoleInput = Console.ReadLine();

                if (consoleInput == "ler")
                {
                    Instituition.ReadTable();
                }

                if (consoleInput == "ler id")
                {
                    Console.WriteLine("Digite o id");
                    var id = Console.ReadLine();
                    Instituition.GetById(Int32.Parse(id));

                    Instituition ins= Instituition.GetById(Int32.Parse(id));
                    if( ins == null)
                    {
                        Console.WriteLine("instituition null");
                    }else
                    {
                        Console.Write(" lido => Id: " + ins.Id + " id dos staffs:");
                        foreach (int rep in ins.Representantes)
                        {
                            Console.Write(" " + rep);
                        }
                        Console.WriteLine();
                    }
                    
                }

                if (consoleInput == "cadastrar")
                {
                   

                   

                }
                if(consoleInput == "deletar")
                {
                    Console.WriteLine("Digite o id");
                    var id = Console.ReadLine();

                    Instituition.Delete(Int32.Parse(id));
                }

                if(consoleInput == "att")
                {
                    Console.WriteLine("Digite o id");
                    var id = Console.ReadLine();

                    Instituition ins = Instituition.GetById(Int32.Parse(id));
                    if (ins == null)
                    {
                        Console.WriteLine("instituition null");
                    }
                    else
                    {
                        Console.WriteLine(" lido => Id: " + ins.Id + " name:" + ins.Name + " addressId: " + ins.AddressId);
                        Console.WriteLine("Digite addressId, Name, CNPJ, email, password, discription, avatarUrl, addresReference, addressNumber, staff");

                        string[] input = Console.ReadLine().Split(',');

                        Console.WriteLine(input[0] + input[1] + input[2] + input[3] + input[4] + input[5] + input[6] + input[7] + input[8]);

                        int[] staff1 = new int[10];
                        staff1[0] = Int32.Parse(input[9]);
                        staff1[1] = Int32.Parse(input[10]);
                        staff1[2] = Int32.Parse(input[11]);

                        Instituition.Update(Int32.Parse(id), input[1], input[2], input[3], input[4], input[5], input[6], input[7], Int32.Parse(input[8]), Int32.Parse(input[0]), staff1);
                    }
                }
                
                
            } while (consoleInput != "exit");


        }
    }

}