CREATE TABLE IF NOT EXISTS endereco (
    id INT PRIMARY KEY AUTO_INCREMENT,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    complemento VARCHAR(50) NULL,
    bairro VARCHAR(50) NOT NULL,
    municipio VARCHAR(50) NOT NULL,
    estado VARCHAR(30) NOT NULL,
    cep VARCHAR(10) NOT NULL
);

insert into endereco
(logradouro, numero, bairro, municipio, estado, cep, complemento)
values
('The Last Drop Avenue','01','Vielas','Vielas','Zaun','08987789',null),
('Kiramman Manor','69','Capital','Capital','Piltover','08987666',null)
;

