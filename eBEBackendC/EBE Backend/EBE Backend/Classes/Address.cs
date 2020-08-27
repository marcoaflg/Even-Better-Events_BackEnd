using System;
using System.Collections.Generic;
using System.Text;

namespace EBE_Backend
{
    class Address
    {
        private string 
            cep, 
            city, 
            street, 
            state, 
            reference;

        private int number;

        public Address(
            string cep,
            string city,
            string street,
            string state,
            string reference,
            int number)
        {
            this.cep = cep;
            this.city = city;
            this.street = street;
            this.state = state;
            this.reference = reference;
            this.number = number;
        }


        public string Cep { get => cep; set => cep = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string State { get => state; set => state = value; }
        public string Reference { get => reference; set => reference = value; }
        public int Number { get => number; set => number = value; }

        ~Address()
        {
            Console.WriteLine("Address destructor was called. Open fire!");
        }
    }
    
}
