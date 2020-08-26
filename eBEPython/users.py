from adress import Adress

class Users(Adress):

    def __init__(self,
                 name,
                 cep,
                 city,
                 street,
                 number,
                 state,
                 reference,
                 sex,
                 birthDate,
                 cpf,
                 rg,
                 institution,
                 role,
                 nivelDeAcesso,
                 email,
                 password,
                 description,
                 medicalCares):

        super().__init__(cep, city, street, number, state, reference)        

        
        self.name = name
        self.sex = sex
        self.birthDate = birthDate
        self.cpf = cpf
        self.rg = rg
        self.institution = institution
        self.role = role
        self.nivelDeAcesso = nivelDeAcesso
        self.email = email
        self.password = password
        self.description = description
        self.medicalCares = medicalCares

#SET####

    def setName(self, name):
        self.name = name

   


    def setSex(self, sex):
        self.sex = sex

    def setBirthDate(self, birthDate):
        self.birthDate = birthDate
    
    def setCpf(self, cpf):
        self.cpf = cpf

    def setRg(self, rg):
        self.rg = rg


    def setInstitutiton(self, institution):
        self.institution = institution

    def setRole(self, role):
        self.role = role

    def setNivelDeAcesso(self, nivelDeAcesso):
        self.nivelDeAcesso = nivelDeAcesso
    
    def setEmail(self, email):
        self.email = email

    def setPassword(self, password):
        self.password = password

    def setDescription(self, description):
        self.description = description

    def setMedicalCares(self, medicalCares):
        self.medicalCares = medicalCares


#GET####

    def getName(self, name):
      return  self.name
  

    def getSex(self, sex):
       return self.sex

    def getBirthDate(self, birthDate):
       return self.birthDate 
    
    def getCpf(self, cpf):
       return self.cpf 

    def getRg(self, rg):
       return self.rg 


    def getInstitutiton(self, institution):
       return self.institution 

    def getRole(self, role):
       return self.role 

    def getNivelDeAcesso(self, nivelDeAcesso):
       return self.nivelDeAcesso 
    
    def getEmail(self, email):
       return self.email 

    def getPassword(self, password):
        return self.password 

    def getDescription(self, description):
        return self.description 

    def getMedicalCares(self, medicalCares):
        return self.medicalCares 
