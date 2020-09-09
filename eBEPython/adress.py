import mysql.connector


class Adress:

    def __init__(self,
                 addressId,
                 cep,
                 city,
                 street,
                 addressNumber,
                 state,
                 addressReference):
        self.addressId = addressId
        self.cep = cep
        self.city = city
        self.street = street
        self.addressNumber = addressNumber
        self.state = state
        self.addressReference = addressReference

    ##SET####

    def set_cep(self, cep):
        self.cep = cep

    def set_adressId(self, addressId):
        self.adressId = adressId

    def set_city(self, city):
        self.city = city

    def set_street(self, street):
        self.street = street

    def set_number(self, addressNumber):
        self.addressNumber = addressNumber

    def set_state(self, state):
        self.state = state

    def set_district(self, addressReference):
        self.addressReference = addressReference

    ##get####

    def get_adressId(self, addressId):
        return self.adressId

    def get_cep(self, cep):
        return self.cep

    def get_city(self, city):
        return self.city

    def get_street(self, street):
        return self.street

    def get_number(self, addresNumber):
        return self.addressNumber

    def get_state(self, state):
        return self.state

    def get_district(self, addressReference):
        return self.addressReference

    def connect_db():
        mydb = mysql.connector.connect(
            host="localhost",
            user="root",
            password="Acer1234$",
            database="EBEData"

        )
        cur = mydb.cursor()
        print("Sucess to connect with database")

    def insert(self, connection):
        s = "INSERT INTO Address ( addressId, CEP, city, country, street, state, district) VALUES ( %s, %s, %s, %s, %s, %s, %s)"

        b1 = (17, 85754, 'foz do aadfasf', 'teste', 'asfasf', 'faf', 'eeee')

        cur.execute(s, b1)

        mydb.commit()
        mydb.close()

    def select_all():

        cur.execute("SELECT * from Address")

        myresult = cur.fetchall()

        print(myresult)

        mydb.close()
