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
       mexe na linha
       
    UPDATE tabela
    SET (nome = rafael);
    WHERE id = x;
    mexe na coluna