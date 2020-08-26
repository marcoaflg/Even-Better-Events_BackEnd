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

        def set_cep(self, cep):
            self.cep = cep

        def set_city(self, city):
            self.city = city

        def set_street(self, street):
            self.street = street

        def set_number(self, number):
            self.number = number

        def set_state(self, state):
            self.state = state

        def set_reference(self, reference):
            self.reference = reference


    ##get####


        def get_cep(self, cep):
            return self.cep

        def get_city(self, city):
            return self.city

        def get_street(self, street):
            return self.street

        def get_number(self, number):
            return self.number

        def get_state(self, state):
            return self.state

        def get_reference(self, reference):
            return self.reference





