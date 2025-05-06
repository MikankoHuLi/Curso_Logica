select * from cliente WHERE nome LIKE '@%';
select * from jogo WHERE nome LIKE '@%';

INSERT INTO aluguel (cliente_id, data_inicio, data_devolucao, pagamento, valor)
VALUES
(1, '2025-04-24','2025-05-04',0,59.89),
(2, '2025-04-24','2025-05-04',1,39.82)
;
select * from cliente WHERE nome LIKE 'mari%';
SELECT * FROM jogo WHERE nome LIKE 'd%';
select * from cliente;

SELECT cliente.nome AS 'cliente',aluguel.id AS 'numero pedido', data_inicio,data_devolucao,pagamento,aluguel.valor,jogo.nome,jogo.valor
FROM aluguel_jogo
 INNER JOIN aluguel ON aluguel.id = aluguel_jogo.aluguel_id
 INNER JOIN jogo ON jogo.id = aluguel_jogo.jogo_id
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
;
SELECT cliente.nome ,aluguel.id , data_inicio,data_devolucao,pagamento,aluguel.valor, cliente_id
FROM aluguel
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 WHERE cliente.nome LIKE 'mari%'
;
SELECT jogo.nome,jogo.valor
FROM aluguel_jogo
 INNER JOIN aluguel ON aluguel.id = aluguel_jogo.aluguel_id
 INNER JOIN jogo ON jogo.id = aluguel_jogo.jogo_id
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 where aluguel.id = 1
;
select * from aluguel_jogo;