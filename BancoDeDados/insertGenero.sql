CREATE TABLE IF NOT EXISTS genero (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL
   
);
select
genero
from
livro;

insert into genero 
(nome)

values
('tecnologia'),
('documentário cinematográfico'),
('terror'),
('drama'),
('entrevista'),
('aventura'),
('fantasia'),
('ação'),
('ficção científica'),
('romance distópico');

 SELECT
    *
    FROM
    genero;

