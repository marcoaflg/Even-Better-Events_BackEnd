using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBE_Backend.Classes
{
    class SubEvent
    {
        int id, eventId;

        private string
            name,
            starting,
            ending,
            discription,
            palestrantes,
            manager;
        

        public SubEvent(int id, int eventId, string name, string palestrantes, string starting, string ending, 
            string discription, string manager)
        {
            this.id = id;
            this.eventId = eventId;
            this.name = name;
            this.starting = starting;
            this.ending = ending;
            this.discription = discription;
            this.manager = manager;
            this.palestrantes = palestrantes;
        }

        public string Name { get => name; set => name = value; }
        public string Starting { get => starting; set => starting = value; }
        public string Ending { get => ending; set => ending = value; }
        public string Discription { get => discription; set => discription = value; }
        public string Palestrantes { get => palestrantes; set => palestrantes = value; }
        public int Id { get => id; set => id = value; }
        public int EventId { get => eventId; set => eventId = value; }
        public string Manager { get => manager; set => manager = value; }

        ~SubEvent()
        {
            Console.WriteLine("SubEvent destructor was called. Open fire!");
        }

        public static void Create(int eventId,
            string name,
            string palestrantes,
            string starting,
            string ending,
            string discription, 
            string manager)
        {

            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            try
            {
                cmd.CommandText = "INSERT INTO Events (idEvents, name, palestrantes_User_id, starting, ending, discription, manager) VALUES ( '" + eventId + "', '" + name + "', '" + palestrantes + "', '" + starting + "', '" + ending + "', '" + discription + "', '" + manager + "');";
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

            string statement = "select * from SubEvents";

            using var cmd = new MySqlCommand(statement, connection);

            using MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    Console.WriteLine("Id: {0}, eventName: {1}, starting: {2}, ending: {3}, discription: {4}, subEvent: {5}, manager: {6}",
                        reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
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

        public static SubEvent GetById(int id)
        {
            string url = @"server=localhost;userid=Jacik;password=1234;database=ebedata";

            SubEvent subEvent = null;

            using var connection = new MySqlConnection(url);

            connection.Open();

            string statement = "select * from SubEvent";

            using var cmd = new MySqlCommand(statement, connection);

            using MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {

                        subEvent = new SubEvent(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));

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

            return subEvent;
        }

        public static void Update(int id, int eventId, string name, string palestrantes, string starting, string ending,
            string discription, string manager)
        {
            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            try
            {
                cmd.CommandText = "update SubEvent set idEvents= '" + eventId + "', name = '" + name + "', palestrantes = '" + palestrantes 
                    + "', starting = '" + starting + "', ending = '" + ending + "', discription = '" + discription + "', manager = '" + manager + "' where id =" + id + ";";
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
                cmd.CommandText = "delete from SubEvent where Id = " + id + ";";
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
