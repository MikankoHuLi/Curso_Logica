CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    usuario;
    
    INSERT INTO usuario 
    (
    nome,
    email,
    senha
    )
    VALUES
    ('jinx','jinx@gmail.com','caitsucks123');
    
     INSERT INTO usuario 
    (
    nome,
    email,
    senha
    )
    VALUES
    ('Neymar Jr','njr@email.com','brun@'),
    ('Maria Madalena','mmadalena@email.com','maria123'),
    ('Pablo Vitar','p.vitar@email.com','senha@forte');
    drop table usuario