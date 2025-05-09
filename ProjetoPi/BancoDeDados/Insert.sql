INSERT INTO jogo (nome,genero, valor)
VALUES
('Adventure','Aventura', 33.99),
('Donkey Kong','Plataforma', 25.90),
('The Last Of Us','Aventura', 19.92),
('God Of War','Aventura', 19.90)
;

INSERT INTO cliente (nome, telefone, email, cpf,genero,data_de_nascimento,logradouro,numero,bairro, cep,cidade)
VALUES
('Mariana', '11999876541', 'mari.ana.lopes@gmail.com', '15553758692',1,'1995-04-24','Rua Algazarra','42','Campo Limpo', '98789876', 'São Paulo'),
('Paulo', '11999007541', 'paulo.coelhos@gmail.com', '25552228692',2,'1990-09-17','Rua Rebimboca','7','Vila das Belezas', '98775676','São Paulo')
;

INSERT INTO aluguel (cliente_id, data_inicio, data_devolucao, pagamento, valor)
VALUES
(1, '2025-04-24','2025-05-04',0,59.89),
(2, '2025-04-24','2025-05-04',1,39.82)
;

INSERT INTO aluguel_jogo (aluguel_id, jogo_id)
VALUES
(1,1),
(1,2),
(2,3),
(2,4)
;


