
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

    def setEventName(self, eventName):
        self.eventName = eventName

    def setStarting(self, starting):
        self.starting = starting

    def setEnding(self, ending):
        self.ending = ending

    def setDescription(self, description):
        self.description = description

    def setSubEvent(self, subEvent):
        self.subEvent = subEvent

    def setManager(self, manager):
        self.manager = manager

    def setListaDeParticipantes(self, listaDeParticipantes):
        self.listaDeParticipantes = listaDeParticipantes

###GET###
    def GetEventName(self, eventName):
        return self.eventName

    def getStarting(self, starting):
        return self.starting

    def getEnding(self, ending):
        return self.ending

    def getDescription(self, description):
        return self.description

    def getSubEvent(self, subEvent):
        return self.subEvent

    def getManager(self, manager):
        return self.manager

    def getListaDeParticipantes(self, listaDeParticipantes):
        return self.listaDeParticipantes
