select * from cliente WHERE nome LIKE '@%';
select * from jogo WHERE nome LIKE '@%';

INSERT INTO aluguel (cliente_id, data_inicio, data_devolução, pagamento, valor)
VALUES
(1, '2025-04-24','2025-05-04',0,59.89),
(2, '2025-04-24','2025-05-04',1,39.82)
;
select * from cliente WHERE nome LIKE 'mari%';
SELECT * FROM jogo WHERE nome LIKE 'd%';
select * from cliente;

SELECT cliente.nome AS 'cliente',aluguel.id AS 'numero pedido', data_inicio,data_devolução,pagamento,aluguel.valor,jogo.nome,jogo.valor
FROM aluguel_jogo
 INNER JOIN aluguel ON aluguel.id = aluguel_jogo.aluguel_id
 INNER JOIN jogo ON jogo.id = aluguel_jogo.jogo_id
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
;

