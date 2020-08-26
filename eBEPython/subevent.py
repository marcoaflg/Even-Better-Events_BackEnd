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

    def set_name(self, name):
        self.name = name

    def set_starting(self, starting):
        self.starting = starting
    
  

    def set_ending(self, ending):
        self.ending = ending

    def set_description(self, description):
        self.description = description

    def set_palestrantes(self, palestrante):
        self.palestrante = palestrante

    def set_listaDeParticipantesSubEvent(self, listaDePartcipantesSubEvent):
        self.listaDePartcipantesSubEvent = listaDePartcipantesSubEvent

#get####

    def get_name(self, name):
        return self.name get_starting(self, starting):
        return self.starting 
    

    def get_ending(self, ending):
        return self.ending 

    def get_description(self, description):
        return self.description 

    def get_palestrantes(self, palestrante):
        return self.palestrante 

    def get_listaDeParticipantesSubEvent(self, listaDePartcipantesSubEvent):
        return self.listaDePartcipantesSubEvent 
