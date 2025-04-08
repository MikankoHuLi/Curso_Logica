-- tabela e insert produto
CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    preco DECIMAL(10 , 2 ) NOT NULL,
    estoque INT NOT NULL,
    id_fornecedor INT NOT NULL,
    FOREIGN KEY (id_fornecedor)
        REFERENCES fornecedor (id)
);
INSERT INTO produto (
nome, categoria, preco, estoque, id_fornecedor)
 VALUES
('Celular X','Eletrônicos',2500.00,30,1),
('Notebook Y','Eletrônicos',4800.00,15,2),
('Mesa de Madeira','Móveis',750.00,10,3),
('Cadeira Z','Móveis',300.00,25,3),
('Tv 50','Eletrônicos',3500.00,8,1);

-- tabela e insert fornecedor
CREATE TABLE IF NOT EXISTS fornecedor (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL
);
INSERT INTO fornecedor (nome,cidade)
VALUES 
('TechBrasil','São Paulo'),
('Computech','Rio de Janeiro'),
('Moveis&Co','Curitiba');

-- tabela e insert cliente
CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL,
    idade INT NOT NULL
);

INSERT INTO cliente (nome,cidade,idade)
VALUES
('João Silva','São Paulo',35),
('Maria Santos','Belo Horizonte',28),
('Carlos Lima','Rio de Janeiro',42),
('Fernanda Rocha','Curitiba',30);

-- taebela e insert pedido
CREATE TABLE IF NOT EXISTS pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    id_produto INT NOT NULL,
    quantidade INT NOT NULL,
    data_pedido DATETIME NOT NULL,
    id_cliente INT NOT NULL,
    FOREIGN KEY (id_produto)
        REFERENCES produto (id),
	FOREIGN KEY (id_cliente)
        REFERENCES cliente (id)
);
INSERT INTO pedido
(id_produto,quantidade,data_pedido,id_cliente)
VALUES
(1,2,'2024-03-10',1),
(3,1,'2024-03-11',2),
(2,1,'2024-03-15',3),
(5,3,'2024-03-18',1),
(4,4,'2024-03-20',4);

-- 2.1
SELECT nome, categoria, preco
FROM produto
WHERE categoria = 'Eletrônicos' AND preco > 3000 
ORDER BY preco DESC; 

-- 2.2
SELECT nome, cidade, idade
FROM cliente
WHERE cidade <>'São Paulo' AND idade > 30;

-- 2.3
SELECT id AS 'Número do Pedido', quantidade, data_pedido AS 'Data do Pedido'
FROM pedido
WHERE data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
ORDER BY data_pedido ASC;

-- 2.4
SELECT nome, estoque
FROM produto
WHERE estoque < 10
ORDER BY estoque ASC;

-- 2.5
SELECT nome, cidade
FROM fornecedor
WHERE cidade <> 'Rio de Janeiro' AND nome LIKE 'T%';

-- 3.1
SELECT AVG (preco) AS 'Média', categoria
FROM produto
GROUP BY categoria;

-- 3.2
SELECT COUNT(pedido.id) AS 'Quantidade de Pedidos', cliente.nome
FROM pedido
INNER JOIN cliente ON pedido.id_cliente = cliente.id
GROUP BY cliente.nome
ORDER BY COUNT(pedido.id) DESC;

-- 3.3
SELECT SUM(estoque) AS 'Estoque', categoria
FROM produto
GROUP BY categoria;

-- 3.4
SELECT pedido.id AS 'Numero do Pedido', produto.nome AS 'Produto',  quantidade
FROM pedido
INNER JOIN produto ON id_produto = produto.id
ORDER BY quantidade DESC
LIMIT 1;

-- 3.5
-- insert opcional
INSERT INTO cliente (nome,cidade,idade)
VALUES
('Guilherme Diniz','São Paulo',24);

SELECT COUNT(nome) AS 'Quantidade de Clientes', cidade
FROM cliente
GROUP BY cidade 
ORDER BY 'Quantidade de Clientes' DESC;

-- 4.1
SELECT fornecedor.nome AS 'Fornecedor', produto.nome AS 'Produto'
FROM produto
INNER JOIN fornecedor ON id_fornecedor = fornecedor.id
ORDER BY fornecedor.nome ASC;

-- 4.2
SELECT pedido.id AS 'Número do Pedido', cliente.nome AS 'Cliente', produto.nome AS 'Produto', quantidade
FROM pedido
JOIN cliente ON id_cliente = cliente.id
JOIN produto ON id_produto = produto.id
ORDER BY data_pedido ASC;

-- 4.3
SELECT pedido.id AS 'Número do Pedido', cliente.nome AS 'Cliente', produto.nome AS 'Produto',
quantidade, fornecedor.nome AS 'Fornecedor'
FROM pedido
JOIN cliente ON id_cliente = cliente.id
JOIN produto ON id_produto = produto.id
JOIN fornecedor ON id_fornecedor = fornecedor.id;

-- 4.4
SELECT SUM(quantidade) AS 'Quantidade Produtos', cliente.nome
FROM pedido
JOIN cliente ON id_cliente = cliente.id
GROUP BY cliente.nome ORDER BY SUM(quantidade) DESC;

-- 5.1
SELECT nome, preco,categoria 
FROM produto p
WHERE preco > (SELECT AVG(preco) FROM produto pr WHERE p.categoria = pr.categoria)
;


-- SELECT nome, preco,categoria 
-- FROM produto
-- WHERE preco > (SELECT AVG(preco) FROM produto WHERE categoria = 'Eletrônicos') AND categoria = 'Eletrônicos'
-- OR preco > (SELECT AVG(preco) FROM produto WHERE categoria = 'Móveis') AND categoria = 'Móveis ;
 
-- consulta media
-- SELECT AVG(preco) FROM produto GROUP BY categoria;

-- 5.2

UPDATE produto
SET preco = preco * 1.1
WHERE categoria = 'Eletrônicos';

-- 5.3
DELETE from pedido
WHERE id_cliente IN (SELECT id_cliente FROM cliente WHERE cidade = 'Curitiba');

-- 5.4
INSERT INTO cliente (nome,cidade,idade)
VALUES
('Ricardo Lopes','Porto Alegre',38);

-- 5.5

INSERT INTO pedido
(id_produto,quantidade,data_pedido,id_cliente)
VALUES
((SELECT id FROM produto WHERE nome = 'Notebook Y'),
2,'2024-03-25',
(SELECT id FROM cliente WHERE nome = 'João Silva'));

-- 5.6
SELECT DISTINCT cliente.nome, pedido.id AS 'Número do Pedido', produto.nome AS 'Nome do Produto'
FROM pedido
JOIN cliente ON id_cliente = cliente.id
JOIN produto ON id_produto = produto.id
WHERE produto.categoria = 'Móveis'
;











