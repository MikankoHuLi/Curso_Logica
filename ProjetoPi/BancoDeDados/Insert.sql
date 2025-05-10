INSERT INTO jogo (nome,genero, valor)
VALUES
('Adventure','Aventura', 33.99),
('Donkey Kong','Plataforma', 25.90),
('The Last Of Us','Aventura', 19.92),
('God Of War','Aventura', 19.90),
('Monster Hunter Rise','RPG', 25.45),
('Dark Souls 2','RPG', 15.90),
('Marvel Rivals','Hero Shooter', 52.10),
('Minecraft','Sandbox', 12.60)
;

INSERT INTO cliente (nome, telefone, email, cpf,genero,data_de_nascimento,logradouro,numero,bairro, cep,cidade)
VALUES
('Mariana Valente', '11999876541', 'mari.ana.lopes@gmail.com', '15553758692',1,'1995-04-24','Rua Algazarra','42','Campo Limpo', '98789876', 'São Paulo'),
('Paulo Coelho', '11999007541', 'paulo.coelhos@gmail.com', '25552228692',2,'1990-09-17','Rua Rebimboca','7','Vila das Belezas', '98775676','São Paulo'),
('Valerya Cruz', '11988007533', 'valerya@gmail.com', '34411758692',1,'2001-06-26','Muito Longe','34','Itapecerica', '77789876', 'São Paulo'),
('Eduardo Gomes', '11977871141', 'edunintendo@gmail.com', '90323758692',1,'2002-11-13','Pernambucanas','88','Capão Redondo', '45689876', 'São Paulo'),
('Kaique Pereira', '11913117741', 'kaiimusic@gmail.com', '02353755692',1,'1998-10-26','Longe Também','42','Putz', '33781806', 'São Paulo'),
('Guilherme Diniz', '11952033661', 'dinizo@gmail.com', '48753755600',1,'2000-07-03','Fazzeoni','202','Capão Redondo', '05889876', 'São Paulo')
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


