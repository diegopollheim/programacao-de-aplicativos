CREATE TABLE Empresa (
    Id int IDENTITY(0,1) PRIMARY KEY,
    RazaoSocial varchar(100) NOT NULL,
    NomeFantasia varchar(100) NOT NULL,    
    CNPJ varchar(20) NOT NULL,
    EndLogr varchar(100),
	EndNum varchar(10),
	EndCidade varchar(20),
	EndUf VARCHAR(2),
    Telefone varchar(20)
);