SELECT 
    a.id,
    c.nome,
    c.cpf,
    c.email,
    a.data_inicio,
    a.data_devolucao,
    a.valor,
    a.pagamento
FROM
    aluguel a
        INNER JOIN
    cliente c ON a.cliente_id = c.id
WHERE
    a.entregue = 1;