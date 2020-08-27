using System;
using System.Dynamic;

namespace EBE_Backend
{
    class User
    {
        private string
            name,
            sex,
            birthDate,
            cpf,
            rg,
            institution,
            role,
            nivelDeAcesso,
            email,
            password,
            description,
            medicalCares,
            avatarUrl;

        public User(
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
            string avatarUrl)
        {
            this.name = name;
            this.sex = sex;
            this.birthDate = birthDate;
            this.cpf = cpf;
            this.rg = rg;
            this.institution = institution;
            this.role = role;
            this.nivelDeAcesso = nivelDeAcesso;
            this.email = email;
            this.password = password;
            this.description = description;
            this.medicalCares = medicalCares;
            this.avatarUrl = avatarUrl;
        }

        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Institution { get => institution; set => institution = value; }
        public string Role { get => role; set => role = value; }
        public string NivelDeAcesso { get => nivelDeAcesso; set => nivelDeAcesso = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Description { get => description; set => description = value; }
        public string MedicalCares { get => medicalCares; set => medicalCares = value; }
        public string AvatarUrl { get => avatarUrl; set => avatarUrl = value; }

        ~User()
        {
            Console.WriteLine("User destructor was called. Open fire!");
        }
    }
}
