class Adress:

    def __init__(self,
                 cep,
                 city,
                 street,
                 number,
                 state,
                 reference):

        self.cep = cep
        self.city = city
        self.street = street
        self.number = number
        self.state = state
        self.reference = reference

##SET####

    def setCep(self, cep):
        self.cep = cep

    def setCity(self, city):
        self.city = city

    def setStreet(self, street):
        self.street = street

    def setNumber(self, number):
        self.number = number

    def setState(self, state):
        self.state = state

    def setReference(self, reference):
        self.reference = reference


##get####


    def getCep(self, cep):
        return self.cep

    def getCity(self, city):
        return self.city

    def getStreet(self, street):
        return self.street

    def getNumber(self, number):
        return self.number

    def getState(self, state):
        return self.state

    def getReference(self, reference):
        return self.reference
