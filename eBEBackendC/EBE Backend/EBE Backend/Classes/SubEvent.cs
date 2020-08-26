using System;
using System.Collections.Generic;
using System.Text;

namespace EBE_Backend.Classes
{
    class SubEvent
    {
        private string
            name,
            starting,
            ending,
            description,
            palestrante,
            listaDePartcipantesSubEVent;

        public SubEvent(string name, string starting, string ending, string description, string palestrante, string listaDePartcipantesSubEVent)
        {
            this.name = name;
            this.starting = starting;
            this.ending = ending;
            this.description = description;
            this.palestrante = palestrante;
            this.listaDePartcipantesSubEVent = listaDePartcipantesSubEVent;
        }

        public string Name { get => name; set => name = value; }
        public string Starting { get => starting; set => starting = value; }
        public string Ending { get => ending; set => ending = value; }
        public string Description { get => description; set => description = value; }
        public string Palestrante { get => palestrante; set => palestrante = value; }
        public string ListaDePartcipantesSubEVent { get => listaDePartcipantesSubEVent; set => listaDePartcipantesSubEVent = value; }
        
        ~SubEvent()
        {
            Console.WriteLine("SubEvent destructor was called. Open fire!");
        }
    }
}
