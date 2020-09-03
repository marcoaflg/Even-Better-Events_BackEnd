using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBE_Backend
{
    class Address
    {
        private string
            cep,
            city,
            street,
            country,
            state,
            district;
            

        public Address(
            string cep,
            string city,
            string country,
            string street,
            string state,
            string district)
        {
            this.cep = cep;
            this.city = city;
            this.country = country;
            this.street = street;
            this.state = state;
            this.district = district;
        }


        public string Cep { get => cep; set => cep = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string State { get => state; set => state = value; }
        public string District { get => district; set => district = value; }
        public string Country { get => country; set => country = value; }

        ~Address()
        {
            Console.WriteLine("Address destructor was called. Open fire!");
        }

        public static void ReadTable()
        {
            string url = @"server=localhost;userid=Jacik;password=1234;database=ebedata";

            using var connection = new MySqlConnection(url);

            connection.Open();

            string statement = "select * from Address";

            using var cmd = new MySqlCommand(statement, connection);

            using MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    Console.WriteLine("Id: {0}, cep: {1}, city: {2}, coountry: {3}, street: {4}, state: {5}, district: {6}",
                        reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                }
            }
            catch
            {
                Console.WriteLine("Erro ao ler");
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
