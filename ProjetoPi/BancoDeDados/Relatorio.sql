-- numero alugueis por jogo
SELECT count(aluguel_id) , jogo.nome
FROM aluguel_jogo
 INNER JOIN aluguel ON aluguel.id = aluguel_jogo.aluguel_id
 INNER JOIN jogo ON jogo.id = aluguel_jogo.jogo_id
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 GROUP BY jogo.nome;
 
 -- numero pedidos por cliente
 SELECT count(aluguel.id) AS 'NumeroDePedidos', cliente.nome,cliente.cpf
FROM aluguel
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 group by cliente.nome
 ;
 -- jogos em aluguel
 SELECT *
 FROM jogo
 WHERE alugado = 1;
 
 -- pedidos com multa
 SELECT aluguel.id AS 'Numero do Pedido', aluguel.valor  ,cliente.nome, cliente.cpf, cliente.email, data_inicio,data_devolucao,data_retorno,pagamento,multa
FROM aluguel
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 WHERE multa = 1;

 
 

 