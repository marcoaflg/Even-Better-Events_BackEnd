﻿using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBE_Backend.Classes
{
    class Event
    {
        private string
            eventName,
            starting,
            ending,
            discription,
            manager,
            avatar,
            addressReference;

        private int id, addressId, addressNumber;

        public Event(
            int id,
            int addressId,
            string eventName, 
            string starting, 
            string ending, 
            string discription, 
            string manager,
            string avatar,
            int addressNumber,
            string addressReference)
        {
            this.id = id;
            this.addressId = addressId;
            this.eventName = eventName;
            this.starting = starting;
            this.ending = ending;
            this.discription = discription;
            this.manager = manager;
            this.avatar = avatar;
            this.addressNumber = addressNumber;
            this.addressReference = addressReference;
            
        }

        public string EventName { get => eventName; set => eventName = value; }
        public string Starting { get => starting; set => starting = value; }
        public string Ending { get => ending; set => ending = value; }
        public string Discription { get => discription; set => discription = value; }
        public string Manager { get => manager; set => manager = value; }
        public int Id { get => id; set => id = value; }
        public int AddressId { get => addressId; set => addressId = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string AddressReference { get => addressReference; set => addressReference = value; }
        public int AddressNumber { get => addressNumber; set => addressNumber = value; }

        ~Event() 
        {
            Console.WriteLine("Event destructor was called. Open fire!");
        }
        public static void Create(int addressId,
            string eventName,
            string starting,
            string ending,
            string discription,
            string manager,
            string avatar,
            int addressNumber,
            string addressReference)
        {

            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            try
            {
                cmd.CommandText = "INSERT INTO Events (addressId, eventName, starting, ending, discription, manager, avatar, addressNumber, addressReference) VALUES ( '" + addressId + "', '" + eventName + "', '" + starting + "', '" + ending + "', '" + discription + "', '" + manager + "', '" + avatar + "', '" + addressNumber + "', '" + addressReference + "');";
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

            string statement = "select * from Events";

            using var cmd = new MySqlCommand(statement, connection);

            using MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    Console.WriteLine("Id: {0}, eventId: {1}, eventName: {2}, starting: {3}, ending: {4}, discription: {5}, manager: {6}, avatar: {7}, addressNumber: {8}, addressReference: {9}",
                        reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8), reader.GetString(9));
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

        public static Event GetById(int id)
        {
            string url = @"server=localhost;userid=Jacik;password=1234;database=ebedata";

            Event events = null;

            using var connection = new MySqlConnection(url);

            connection.Open();

            string statement = "select * from Events";

            using var cmd = new MySqlCommand(statement, connection);

            using MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {

                        events = new Event(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8), reader.GetString(9));

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

            return events;
        }

        public static void Update(int id,
            int addressId,
            string eventName,
            string starting,
            string ending,
            string discription,
            string manager,
            string avatar,
            int addressNumber,
            string addressReference)
        {
            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            try
            {
                cmd.CommandText = "update Events set addressId= '" + addressId + "', eventName = '" + eventName + "', starting = '" + starting + "', ending = '" + ending + "', discription = '" + discription + "', manager = '" + manager + "', avatar = '" + avatar + "', addressNumber = '" + addressNumber + "', addressReference = '" + addressReference + "' where id =" + id + ";";
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
                cmd.CommandText = "delete from Events where Id = " + id + ";";
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
