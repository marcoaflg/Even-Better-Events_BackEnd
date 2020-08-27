using System;
using System.Collections.Generic;
using System.Text;

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
            representantes; //lista

        public Instituition(
            string name,
            string cnpj,
            string email,
            string password,
            string discription,
            string avatarUrl,
            string representantes)
        {
            this.name = name;
            this.cnpj = cnpj;
            this.email = email;
            this.password = password;
            this.discription = discription;
            this.avatarUrl = avatarUrl;
            this.representantes = representantes;
        }

        public string Name { get => name; set => name = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Discription { get => discription; set => discription = value; }
        public string AvatarUrl { get => avatarUrl; set => avatarUrl = value; }
        public string Representantes { get => representantes; set => representantes = value; }

        ~Instituition()
        {
            Console.WriteLine("Institution destructor was called. Open fire!");
        }
    }
}
