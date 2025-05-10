-- jogos mais vendidos
SELECT count(aluguel_id) AS 'QuantidadeDeAlugueis', jogo.nome
FROM aluguel_jogo
 INNER JOIN aluguel ON aluguel.id = aluguel_jogo.aluguel_id
 INNER JOIN jogo ON jogo.id = aluguel_jogo.jogo_id
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 group by jogo.nome;
 
 -- numero pedidos por cliente
 SELECT count(aluguel.id) AS 'NumeroDePedidos', cliente.nome,cliente.cpf
FROM aluguel
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 group by cliente.nome
 ;
 -- jogos indisponiveis
 SELECT aluguel_id, cliente.nome AS 'cliente', jogo_id, jogo.nome, jogo.genero, jogo.valor 
 FROM aluguel_jogo 
 INNER JOIN aluguel ON aluguel.id = aluguel_jogo.aluguel_id 
 INNER JOIN jogo ON jogo.id = aluguel_jogo.jogo_id 
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id 
 WHERE alugado = 1 AND entregue = 0;
 
 -- pedidos com multa
 SELECT aluguel.id AS 'Numero do Pedido', aluguel.valor  ,cliente.nome, cliente.cpf, cliente.email, data_inicio,data_devolucao,data_retorno,pagamento,multa
FROM aluguel
 INNER JOIN cliente ON cliente.id = aluguel.cliente_id
 WHERE multa = 1;
 
 -- relatorio pedidos finalizados
SELECT aluguel.id, cliente_id, cliente.nome, cliente.cpf, data_inicio, data_devolucao, data_retorno, pagamento, valor, multa 
FROM aluguel 
INNER JOIN cliente ON cliente.id = aluguel.cliente_id 
WHERE entregue = 1;