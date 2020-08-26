using System;
using System.Collections.Generic;
using System.Text;

namespace EBE_Backend.Classes
{
    class Event
    {
        private string 
            eventName,
            starting,
            ending,
            description,
            subEvent,
            manager,
            listaDeParticipantes;

        public Event(
            string eventName, 
            string starting, 
            string ending, 
            string description, 
            string subEvent, 
            string manager, 
            string listaDeParticipantes)
        {
            this.eventName = eventName;
            this.starting = starting;
            this.ending = ending;
            this.description = description;
            this.subEvent = subEvent;
            this.manager = manager;
            this.listaDeParticipantes = listaDeParticipantes;
        }

        public string EventName { get => eventName; set => eventName = value; }
        public string Starting { get => starting; set => starting = value; }
        public string Ending { get => ending; set => ending = value; }
        public string Description { get => description; set => description = value; }
        public string SubEvent { get => subEvent; set => subEvent = value; }
        public string Manager { get => manager; set => manager = value; }
        public string ListaDeParticipantes { get => listaDeParticipantes; set => listaDeParticipantes = value; }

        ~Event() 
        {
            Console.WriteLine("Event destructor was called. Open fire!");
        }
    }
}
