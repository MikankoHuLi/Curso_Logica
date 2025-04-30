INSERT INTO jogo (nome, valor)
VALUES
('Adventure', 33.99),
('Donkey Kong', 25.90),
('The Last Of Us', 19.92),
('God Of War', 19.90)
;

SELECT * FROM cliente;

INSERT INTO cliente (nome, telefone, email, cpf, cep)
VALUES
('Mariana', '11999876541', 'mari.ana.lopes@gmail.com', '25553758692', '98789876'),
('Paulo', '11999007541', 'paulo.coelhos@gmail.com', '25552228692', '98775676')
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
SELECT * FROM aluguel;