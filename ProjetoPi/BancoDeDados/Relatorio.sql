-- numero alugueis por jogo
SELECT count(aluguel_id) , jogo.nome
FROM aluguel_jogo
 INNER JOIN aluguel ON aluguel.id = aluguel_jogo.aluguel_id
 INNER JOIN jogo ON jogo.id = aluguel_jogo.jogo_id
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 GROUP BY jogo.nome;
 
 -- numero pedidos por cliente
 SELECT count(aluguel.id) , cliente.nome,cliente.cpf
FROM aluguel
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 group by cliente.nome
 ;
 -- jogos em aluguel
 SELECT aluguel_id, cliente.nome AS 'cliente', jogo_id, jogo.nome, jogo.genero, jogo.valor
 FROM aluguel_jogo
 INNER JOIN aluguel ON aluguel.id = aluguel_jogo.aluguel_id
 INNER JOIN jogo ON jogo.id = aluguel_jogo.jogo_id
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 WHERE alugado = 1 AND entregue = 0;

 -- pedidos com multa 
 SELECT aluguel.id , aluguel.valor  ,cliente.nome, cliente.cpf, cliente.email, data_inicio,data_devolucao,data_retorno,pagamento
FROM aluguel
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 WHERE multa = 1;
-- total
SELECT aluguel.id, cliente_id, cliente.nome, cliente.cpf, data_inicio, data_devolucao, data_retorno, pagamento, valor, multa
FROM aluguel
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 WHERE entregue = 1;
 
 

 