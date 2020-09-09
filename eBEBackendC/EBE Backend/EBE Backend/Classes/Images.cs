using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBE_Backend.Classes
{
    class Images
    {
        int id, eventId;
        string url;

        public Images(int id, int eventId, string url)
        {
            this.id = id;
            this.eventId = eventId;
            this.url = url;
        }

        public int Id { get => id; set => id = value; }
        public int EventId { get => eventId; set => eventId = value; }
        public string Url { get => url; set => url = value; }

        ~Images()
        {
            Console.WriteLine("Image destructor was called. Open fire!");
        }

        public static void Create(int id, int eventId, string url)
        {

            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            try
            {
                cmd.CommandText = "INSERT INTO EventsImages (idImage, idEvents, imageAddress) VALUES ( '" + id + "', '" + eventId + "', '" + url + "');";
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
        public static void ReadTable()
        {
            string url = @"server=localhost;userid=Jacik;password=1234;database=ebedata";

            using var connection = new MySqlConnection(url);

            connection.Open();

            string statement = "select * from EventsImages";

            using var cmd = new MySqlCommand(statement, connection);

            using MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    Console.WriteLine("Id: {0}, eventId: {1}, url: {2}, ",
                        reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
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

        public static Images GetById(int id)
        {
            string url = @"server=localhost;userid=Jacik;password=1234;database=ebedata";
            Images img = null;

            using var connection = new MySqlConnection(url);

            connection.Open();

            string statement = "select * from EventsImages";

            using var cmd = new MySqlCommand(statement, connection);

            using MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {

                        img = new Images(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2));

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

            return img;
        }

        public static void Update(int id, int eventId, string url)
        {
            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            try
            {
                cmd.CommandText = "update EventsImages set idEvents= '" + eventId + "', imageAddress = '" + url + "' where id =" + id + ";";
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
                cmd.CommandText = "delete from EventsImages where Id = " + id + ";";
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
