-- tabela cliente e insert
    CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade INT NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    saldo DECIMAL(10, 2) NOT NULL
);
INSERT INTO cliente(
nome, idade, cidade, saldo)
VALUES
('Carlos','45','São Paulo','2500.00'),
('Mariana','32','Rio de Janeiro','3200.50'),
('Pedro','27','Belo Horizonte','1500.75'),
('Fernanda','38','Curitiba','4200.00')
;
select *
from cliente;

-- tabela pedido e insert
    CREATE TABLE IF NOT EXISTS pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    id_cliente INT NOT NULL,
    valor DECIMAL(10, 2) NULL,
    data_publicacao DATETIME NOT NULL,
     FOREIGN KEY (id_cliente)
        REFERENCES cliente (id)
);
INSERT INTO pedido(
id_cliente, valor, data_publicacao)
VALUES
('1','500.00','2024-03-10'),
('2','1200.00','2024-03-12'),
('3','300.50','2024-03-15'),
('1','800.00','2024-03-18')
;
select *
from pedido;

-- tarefa 1.1
SELECT nome, cidade
FROM cliente
WHERE cidade = 'Rio de Janeiro';

-- tarefa 1.2
SELECT nome, saldo
FROM cliente
WHERE saldo > 2000 ORDER BY saldo DESC;

-- tarefa 1.3
SELECT nome, idade
FROM cliente
WHERE idade > 30 ORDER BY idade ASC;

-- tarefa 2.1
SELECT nome, idade
FROM cliente
WHERE idade BETWEEN 25 AND 40 ORDER BY idade ASC;

-- tarefa 2.2
SELECT nome
FROM cliente
WHERE nome LIKE 'F%';

-- tarefa 2.3
SELECT nome, cidade
FROM cliente
WHERE cidade != 'São Paulo' AND cidade != 'Curitiba';

-- tarefa 3.1
SELECT COUNT(id) AS 'Pedidos'
FROM pedido;

-- tarefa 3.2
SELECT AVG(valor) AS 'Valor Médio'
FROM pedido;

-- tarefa 3.3
SELECT cliente.nome, SUM(valor)
FROM pedido
JOIN cliente ON pedido.id_cliente = cliente.id
GROUP BY id_cliente; 

-- tarefa 4.1
SELECT pedido.id AS 'Pedido', valor, data_publicacao, cliente.nome
FROM pedido
INNER JOIN cliente ON pedido.id_cliente = cliente.id
ORDER BY pedido.id ASC;

-- TAREFA 4.2
SELECT cliente.nome, idade, cidade, saldo, valor, data_publicacao
FROM cliente
LEFT JOIN pedido ON pedido.id_cliente = cliente.id;

-- tarefa 5.1
SELECT nome, valor
FROM pedido
INNER JOIN cliente ON pedido.id_cliente = cliente.id
WHERE valor > (SELECT AVG(valor) FROM pedido);

-- tarefa 5.2
SELECT nome, valor
FROM pedido
INNER JOIN cliente ON pedido.id_cliente = cliente.id
WHERE valor > 1000;

-- tarefa 6.1
INSERT INTO cliente(
nome, idade, cidade, saldo)
VALUES
('Rafael','36','Porto Alegre','0')
;
-- tarefa 6.2
UPDATE cliente
SET 
    cliente.saldo = cliente.saldo + (cliente.saldo * 0.1);
-- tarefa 6.3
DELETE FROM pedido 
WHERE id = (SELECT id FROM pedido WHERE valor < 500);







