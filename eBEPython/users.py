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

    def set_name(self, name):
        self.name = name

   


    def set_sex(self, sex):
        self.sex = sex

    def set_birthDate(self, birthDate):
        self.birthDate = birthDate
    
    def set_cpf(self, cpf):
        self.cpf = cpf

    def set_rg(self, rg):
        self.rg = rg


    def set_institution(self, institution):
        self.institution = institution

    def set_role(self, role):
        self.role = role

    def set_nivelDeAcesso(self, nivelDeAcesso):
        self.nivelDeAcesso = nivelDeAcesso
    
    def set_email(self, email):
        self.email = email

    def set_password(self, password):
        self.password = password

    def set_description(self, description):
        self.description = description

    def set_medicalCares(self, medicalCares):
        self.medicalCares = medicalCares


#GET####

    def get_name(self, name):
      return  self.name
  

    def get_sex(self, sex):
       return self.sex

    def get_birthDate(self, birthDate):
       return self.birthDate 
    
    def get_cpf(self, cpf):
       return self.cpf 

    def get_rg(self, rg):
       return self.rg 


    def get_institution(self, institution):
       return self.institution 

    def get_rle(self, role):
       return self.role 

    def get_nivelDeAcesso(self, nivelDeAcesso):
       return self.nivelDeAcesso 
    
    def get_email(self, email):
       return self.email 

    def get_password(self, password):
        return self.password 

    def get_description(self, description):
        return self.description 

    def get_medicalCares(self, medicalCares):
        return self.medicalCares 
