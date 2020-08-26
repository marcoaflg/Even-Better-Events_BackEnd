
class Events:

    def __init__(self,
                 eventName,
                 starting,
                 ending,
                 description,
                 subEvent,
                 manager,
                 listaDeParticipantes):

        self.eventName = eventName
        self.starting = starting
        self.ending = ending
        self.description = description
        self.subEvent = subEvent
        self.manager = manager
        self.listaDeParticipantes = listaDeParticipantes
#SET####

    def set_eventName(self, eventName):
        self.eventName = eventName

    def set_starting(self, starting):
        self.starting = starting

    def set_ending(self, ending):
        self.ending = ending

    def set_description(self, description):
        self.description = description

    def set_subeEvent(self, subEvent):
        self.subEvent = subEvent

    def set_manager(self, manager):
        self.manager = manager

    def set_listaDeParticipantes(self, listaDeParticipantes):
        self.listaDeParticipantes = listaDeParticipantes

###GET###
    def get_eventName(self, eventName):
        return self.eventName

    def get_starting(self, starting):
        return self.starting

    def get_ending(self, ending):
        return self.ending

    def get_description(self, description):
        return self.description

    def get_subEvent(self, subEvent):
        return self.subEvent

    def get_manager(self, manager):
        return self.manager

    def get_listaDeParticipantes(self, listaDeParticipantes):
        return self.listaDeParticipantes
