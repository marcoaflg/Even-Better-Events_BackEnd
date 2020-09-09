using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBE_Backend.Classes
{
    class Instituition
    {
        private string
            name,
            cnpj,
            email,
            password,
            discription,
            avatarUrl,
            addressReference;

        private int[] representantes;

        private int id, addressNumber, addressId;

        private Address address;

        public Instituition(
            int id,
            int addressId,
            string name,
            string cnpj,
            string email,
            string password,
            string discription,
            string avatarUrl,
            string addressReference,
            int addressNumber,
            int[] representantes)//max 10
        {
            this.id = id;
            this.addressId = addressId;
            this.name = name;
            this.cnpj = cnpj;
            this.email = email;
            this.password = password;
            this.discription = discription;
            this.avatarUrl = avatarUrl;
            this.addressNumber = addressNumber;
            this.addressReference = addressReference;
            this.representantes = representantes;

            address.GetById(this.addressId);
        }

        public string Name { get => name; set => name = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Discription { get => discription; set => discription = value; }
        public string AvatarUrl { get => avatarUrl; set => avatarUrl = value; }
        public int[] Representantes { get => representantes; set => representantes = value; }
        public string AddressReference { get => addressReference; set => addressReference = value; }
        public int AddressNumber { get => addressNumber; set => addressNumber = value; }
        public int Id { get => id; set => id = value; }
        public int AddressId { get => addressId; set => addressId = value; }

        ~Instituition()
        {
            Console.WriteLine("Institution destructor was called. Open fire!");
        }

        public void Create()
        {

            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            try
            {
                string staff = this.representantes[0].ToString();

                for (int i = 1; i < 10; i++)
                {
                    staff += "," + this.representantes[i].ToString();
                } 
                cmd.CommandText = "INSERT INTO Instituition (addressId, name, CNPJ, email, password, discription, avatar, addressNumber, addressReference, staff ) VALUES ( '" + this.addressId + "', '" + this.name + "', '" + this.cnpj + "', '" + this.email + "', '" + this.password + "', '" + this.discription + "', '" + this.avatarUrl + "', '" + this.addressNumber + "', '" + this.addressReference + "', '" + staff + "');";
                cmd.ExecuteNonQuery();
                Console.WriteLine("cadastrado!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }

        }

        public void ReadTable()
        {
            string url = @"server=localhost;userid=Jacik;password=1234;database=ebedata";

            using var connection = new MySqlConnection(url);

            connection.Open();

            string statement = "select * from Instituition";

            using var cmd = new MySqlCommand(statement, connection);

            using MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    Console.WriteLine("Id {0}, Name {1}, CNPJ {2}, email {3}, password {4}, discription {5}, avatarUrl {6}, staff {7} ",
                        reader.GetInt32(0), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(8), reader.GetString(7));
                    this.address.GetById(reader.GetInt32(1));
                    Console.WriteLine("cep:" + this.address.Cep + " Numero: " + reader.GetInt32(9) + "cidade: " + this.address.City + " pais: " + this.address.Country + " rua: " + this.address.Street + " estado: " + this.address.State + " bairro: " + this.address.District + " referencia: " + reader.GetString(10));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public Instituition GetById(int id)
        {

            string url = @"server=localhost;userid=Jacik;password=1234;database=ebedata";

            using var connection = new MySqlConnection(url);

            connection.Open();

            string statement = "select * from Instituition";

            using var cmd = new MySqlCommand(statement, connection);

            using MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {

                        string[] staff = reader.GetString(7).Split(',');
                        int[] staff1 = new int[10];

                        for (int i = 0; i < 10; i++)
                        {
                            if (staff[i] != default)
                            {
                                staff1[i] = Int32.Parse(staff[i]);
                            }
                            else
                            {
                                staff1[i] = 0;
                            }

                        }
                        this.id = reader.GetInt32(0);
                        this.addressId = reader.GetInt32(1);
                        this.name = reader.GetString(2);
                        this.cnpj = reader.GetString(3);
                        this.email = reader.GetString(4);
                        this.password = reader.GetString(5);
                        this.discription = reader.GetString(6);
                        this.representantes[] = reader.GetInt32(7);
                        this.avatarUrl = reader.GetString(8);
                        this.addressNumber = reader.GetInt32(9);
                        this.addressReference = reader.GetString(10);
                    }
                    else
                    {
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }

            return this;
        }
        public static void Update(int id,
            string name,
            string cnpj,
            string email,
            string password,
            string discription,
            string avatarUrl,
            string addressReference,
            int addressNumber,
            int addressId,
            int[] representantes)
        {
            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            string staff = new string (representantes[0].ToString());

            for (int i = 1; i < 10; i++)
            {
                if (representantes[i] != default)
                {
                    staff += "," + representantes[i].ToString();
                }
                else
                {
                    staff += ",0";
                }

            }

            try
            {
                cmd.CommandText = "update Instituition set addressId ='" + addressId + "', name= '" + name + "', CNPJ= '" + cnpj + "', email= '" + email + 
                    "', password= '" + password + "', discription= '" + discription + "', avatar= '" + avatarUrl + "', addressNumber= '" + addressNumber + "', addressReference= '" + addressReference + "', staff ='" + staff + "' where id =" + id + ";";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Atualizado!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Delete(int id)
        {
            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            try
            {
                cmd.CommandText = "delete from Instituition where Id = " + id + ";";
                cmd.ExecuteNonQuery();
                Console.WriteLine("id" + id + "deletado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
            
        }
    }
}
