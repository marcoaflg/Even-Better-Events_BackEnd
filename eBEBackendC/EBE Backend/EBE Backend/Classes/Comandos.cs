using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.FileIO;
using MySql.Data.MySqlClient;

namespace EBE_Backend.Classes
{
    class Comandos
    {
        public static void ReadUserTable()
        {
            string url = @"server=localhost;userid=Jacik;password=1234;database=ebedata";

            using var connection = new MySqlConnection(url);

            connection.Open();

            string statement = "select * from User";

            using var cmd = new MySqlCommand(statement, connection);

            using MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    Console.WriteLine("id:{0}, name {1}, birthDate {2}, acessLevel {3}, email {4}, password {5}",
                        reader.GetInt32(0), reader.GetString(2), reader.GetDateTime(3), reader.GetString(9), reader.GetString(10), reader.GetString(11));
                }
            }
            catch
            {
                Console.WriteLine("erro ao ler");
            }
            finally
            {
                connection.Close();
            }
            

        }
        public static void CadastrarUser(string name, string birthDate, string acessLevel, string email, string password)
        {

            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            try
            {
                cmd.CommandText = "INSERT INTO User (name, birthDate, acessLevel, email, password) VALUES ( '" + name + "', '" + birthDate + "', '" + acessLevel + "', '" + email + "', '" + password + "');";
                cmd.ExecuteNonQuery();
                Console.WriteLine("cadastrado!");
            }
            catch
            {
                Console.WriteLine("Erro ao cadastrar!");
            }
            finally
            {
                connection.Close();
            }

        }

        public static void DeleteUser(int id) 
        {
            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            try
            {
                cmd.CommandText = "delete from User where Id = " + id + ";";
                cmd.ExecuteNonQuery();
                Console.WriteLine("id" + id + "deletado");
            }
            catch
            {
                Console.WriteLine("Erro ao deletar!");
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
