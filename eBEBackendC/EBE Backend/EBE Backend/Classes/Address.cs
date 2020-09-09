﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using MySql.Data.MySqlClient;

namespace EBE_Backend
{
    class Address
    {
        private int id;

        private string
            cep,
            city,
            street,
            country,
            state,
            district;

        public Address(
            int id,
            string cep,
            string city,
            string country,
            string street,
            string state,
            string district)
        {
            this.id = id;
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
        public int Id { get => id; set => id = value; }


        ~Address()
        {
            Console.WriteLine("Address destructor was called. Open fire!");
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
                cmd.CommandText = "INSERT INTO Address (CEP, city, country, street, state, district) VALUES ( '" + this.cep + "', '" + this.city + "', '" + this.country + "', '" + this.street + "', '" + this.state + "', '" + this.district + "');";
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

            string statement = "select * from Address";

            using var cmd = new MySqlCommand(statement, connection);

            using MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    Console.WriteLine("Id: {0}, cep: {1}, city: {2}, coountry: {3}, street: {4}, state: {5}, district: {6}",
                        reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
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

        public Address GetById(int id)
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
                    if(reader.GetInt32(0) == id)
                    {
                        this.id = reader.GetInt32(0);
                        this.cep = reader.GetString(1);
                        this.city = reader.GetString(2); 
                        this.country = reader.GetString(3);
                        this.street = reader.GetString(4); 
                        this.state = reader.GetString(5); 
                        this.district = reader.GetString(6);

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

        public void Update()
        {
            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            try
            {
                cmd.CommandText = "update Address set cep= '" + this.cep + "', city = '" + this.city + "', country = '" + this.country + "', street = '" + this.street + "', state = '" + this.state + "', district = '" + this.district + "' where id =" + this.id + ";";
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
        public void Delete()
        {
            using var connection = new MySqlConnection(@"server=localhost;userid=Jacik;password=1234;database=ebedata");

            connection.Open();

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection
            };

            try
            {
                cmd.CommandText = "delete from Address where Id = " + this.id + ";";
                cmd.ExecuteNonQuery();
                Console.WriteLine("id" + this.id + "deletado");
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
