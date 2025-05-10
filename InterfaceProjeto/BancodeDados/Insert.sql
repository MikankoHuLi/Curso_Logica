INSERT INTO jogo (nome,genero, valor)
VALUES
('Adventure','Aventura', 33.90),
('Donkey Kong','Plataforma', 25.90),
('The Last Of Us','Aventura', 19.90),
('God Of War','Aventura', 19.90),
('Sonic Heroes','Plataforma', 33.90),
('Dark Souls 2','RPG', 10.50),
('Marvel Rivals','Hero Shooter', 52.90),
('Minecraft','Sandbox', 26.90),
('Cyberpunk 2077','RPG', 31.90),
('Stardew Valley','Simulador', 12.50)
;

INSERT INTO cliente (nome, telefone, email, cpf,genero,data_de_nascimento,logradouro,numero,bairro, cep,cidade)
VALUES
('Mariana Lopes', '11999876541', 'mari.ana.lopes@gmail.com', '15553758692',1,'1995-04-24','Rua Algazarra','42','Campo Limpo', '98789876', 'São Paulo'),
('Paulo Coelho', '11911007541', 'paulo.coelhos@gmail.com', '25552228692',2,'1990-09-17','Rua Rebimboca','7','Vila das Belezas', '98775676','São Paulo'),
('Kaique Pereira', '11904007541', 'kaiimusics@gmail.com', '45372228692',1,'1998-10-26','Longinho','23','Putz', '77775676','São Paulo'),
('Guilherme Diniz', '11912007541', 'dinizo@gmail.com', '09552028692',1,'2000-07-03','Fazzeoni','202','Capão Redondo', '41775676','São Paulo'),
('Valerya Cruz', '11959107541', 'vavss@gmail.com', '93552928692',0,'2001-06-26','Itapecerica','12','Bem Longe', '53775676','Itapecerica'),
('Eduardo Gomes', '11976007541', 'edunintendo@gmail.com', '12557228692',1,'2002-11-23','Pernambucanas','9','Capão Redondo', '08775676','São Paulo')
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
  