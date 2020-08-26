class SubEvent:

    def __init__(self,
                 name,
                 starting,
                 ending,
                 description,
                 palestrante,
                 listaDePartcipantesSubEVent):

        self.name = name
        self.starting = starting
        self.description = description
        self.ending = ending
        self.palestrante = palestrante
        self.listaDePartcipantesSubEvent = listaDePartcipantesSubEVent

#SET####

    def setName(self, name):
        self.name = name

    def setStarting(self, starting):
        self.starting = starting
    
  

    def setEnding(self, ending):
        self.ending = ending

    def setDescription(self, description):
        self.description = description

    def setPalestrante(self, palestrante):
        self.palestrante = palestrante

    def setListaDeParticipanteSubEvent(self, listaDePartcipantesSubEvent):
        self.listaDePartcipantesSubEvent = listaDePartcipantesSubEvent

#get####

    def getName(self, name):
        return self.name 

    def getStarting(self, starting):
        return self.starting 
    

    def getEnding(self, ending):
        return self.ending 

    def getDescription(self, description):
        return self.description 

    def getPalestrante(self, palestrante):
        return self.palestrante 

    def getListaDeParticipanteSubEvent(self, listaDePartcipantesSubEvent):
        return self.listaDePartcipantesSubEvent 
