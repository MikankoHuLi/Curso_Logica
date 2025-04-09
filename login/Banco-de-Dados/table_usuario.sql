CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(20) NOT NULL
);

INSERT INTO usuario (email,senha) VALUES
('neymar.jr@email.com','BrunaS2!'),
('pablo.vitar@email.com','Eoque11?'),
('sukuna.silva@email.com','Megum!666')
;





