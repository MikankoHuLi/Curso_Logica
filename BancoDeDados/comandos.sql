SELECT 
    *
FROM
    usuario
WHERE
    id = 1;
    
    SELECT 
    *
FROM
    usuario
WHERE
    email LIKE '%gmail.com';
        SELECT 
    *
FROM
    usuario
WHERE
    senha LIKE '%@%';
    
    CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

INSERT INTO usuario 
    (
    nome,
    email,
    senha
    )
    VALUES
    ('jinx','jinx@gmail.com','cathsucks123');
    
    DROP TABLE comando proibido;
    
SELECT 
    *
FROM
    livro
WHERE
    data_publicacao BETWEEN '1990/01/01' AND '2000/01/01'
    
    DELETE FROM tabela
    WHERE id = x
    WHERE autor = y;
   --    mexe na linha
       
    UPDATE tabela
    SET (nome = rafael);
    WHERE id = x;
   -- mexe na coluna
    
    LIMIT x 
    -- limita aparicoes na lista
    select MAX() from xxx
    -- aparece o maior item 
    
    -- trocar uma query já usada por um apelido facilita precessamento
    
    UNION
    -- junta dois selects
    
    SELECT nome, preco,categoria 
FROM produto p
WHERE preco > (SELECT AVG(preco) FROM produto pr WHERE p.categoria = pr.categoria)
;
IN
NOT IN
-- pode ser usado pra quando query tem mais de um elemento 
