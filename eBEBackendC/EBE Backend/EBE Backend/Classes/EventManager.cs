using System;
using System.Collections.Generic;
using System.Text;

namespace EBE_Backend.Classes
{
    class EventManager : User
    {
        public EventManager(
            string name,
            string sex,
            string birthDate,
            string cpf,
            string rg,
            string institution,
            string role,
            string nivelDeAcesso,
            string email,
            string password,
            string description,
            string medicalCares,
            string avatarUrl) : base(name, sex, birthDate, cpf, rg, 
                institution, role, nivelDeAcesso, email, password, description, medicalCares, avatarUrl)
        {
        }

        ~EventManager() 
        {
            Console.WriteLine("EventManager destructor was called. Open fire!");
        }
    }
}
