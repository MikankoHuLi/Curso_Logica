CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    nome_social VARCHAR(100) NULL,
    data_nascimento DATE NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone VARCHAR(20) NOT NULL UNIQUE,
    tipo INT NOT NULL,
    etnia INT NOT NULL,
    genero INT NOT NULL,
    estrangeiro BIT NOT NULL,
    id_endereco INT NOT NULL,
    FOREIGN KEY (id_endereco)
        REFERENCES endereco (id)
);

insert into cliente
(nome, nome_social,data_nascimento,email,telefone,tipo,etnia,genero,estrangeiro,id_endereco)
values
('Powder','Jinx','2000-07-04','jinx@gmail.com','(11)90588-8408',0,0,1,0,(SELECT id FROM endereco WHERE logradouro = 'The Last Drop Avenue')),
('Violet','Vi','1995-04-19','vi@gmail.com','(11)97788-8408',0,0,1,0,(SELECT id FROM endereco WHERE logradouro = 'Kiramman Manor')),
('Caitlyn','Cupcake','1994-07-09','cupcake@gmail.com','(11)95688-8408',0,3,1,1,(SELECT id FROM endereco WHERE logradouro = 'Kiramman Manor'))
;


