-- tabela empregado e insert
    CREATE TABLE IF NOT EXISTS empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade INT NOT NULL,
    id_departamento INT NOT NULL,
    salario DECIMAL(10, 2) NULL,
     FOREIGN KEY (id_departamento)
        REFERENCES departamento (id)
);

INSERT INTO empregado(
nome, idade, id_departamento, salario)
VALUES
('João','30','1','50000'),
('Sarah','28','2','60000'),
('Miguel','35','3','55000'),
('Ana','27','2','62000')
;

SELECT 
empregado.nome,
empregado.idade,
departamento.nome AS departamento,
empregado.salario
  
FROM
    empregado
    JOIN departamento ON empregado.id_departamento = departamento.id;
    
-- tabela departamento e insert
  CREATE TABLE IF NOT EXISTS departamento (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL
);

insert into departamento
(nome)
values
('RH'),
('TI'),
('Vendas'),
('Limpeza')
;

SELECT 
    *
FROM
    departamento;

-- tarefa 1.1
SELECT empregado.nome, departamento.nome AS departamento
FROM empregado
JOIN departamento ON empregado.id_departamento = departamento.id
WHERE empregado.id_departamento = (SELECT departamento.id FROM departamento WHERE	departamento.nome = 'TI');

-- tarefa 1.2
SELECT nome, salario
FROM empregado
WHERE salario > 55000;

-- tarefa 1.3
SELECT nome , idade
FROM empregado
ORDER BY idade DESC;

-- tarefa 2.1
SELECT nome,idade
FROM empregado
WHERE idade BETWEEN 28 AND 38
ORDER BY idade ASC;

-- tarefa 2.2
SELECT nome
FROM empregado
WHERE nome LIKE 'M%';

-- tarefa 2.3
SELECT empregado.nome, departamento.nome AS departamento
FROM empregado
JOIN departamento ON empregado.id_departamento = departamento.id
WHERE empregado.id_departamento != (SELECT departamento.id FROM departamento WHERE departamento.nome = 'RH');

-- tarefa 3.1
SELECT departamento.nome AS departamento , count(empregado.nome) AS funcionarios
FROM empregado
JOIN departamento ON empregado.id_departamento = departamento.id
GROUP BY id_departamento;

-- tarefa 3.2
SELECT AVG(empregado.salario) AS 'Media Salarial'
FROM empregado
JOIN departamento ON empregado.id_departamento = departamento.id
WHERE empregado.id_departamento = (SELECT departamento.id FROM departamento WHERE departamento.nome = 'TI');

-- tarefa 3.3
SELECT SUM(salario) AS 'Soma Salarial'
FROM empregado
JOIN departamento ON empregado.id_departamento = departamento.id
WHERE empregado.id_departamento = (SELECT departamento.id FROM departamento WHERE departamento.nome = 'Vendas');

-- tarefa 4.1

SELECT 
empregado.nome,
departamento.nome AS departamento
FROM
empregado
INNER JOIN departamento ON empregado.id_departamento = departamento.id;

-- tarefa 4.2
SELECT *
  FROM departamento
  LEFT JOIN empregado
    ON empregado.id_departamento = departamento.id;
    
-- empregado.id_departamento = departamento.id
-- departamento.id = empregado.id_departamento

-- tarefa 5.1
SELECT nome, salario
FROM empregado
WHERE salario > (SELECT AVG(salario) FROM empregado);

-- tarefa 5.2
SELECT 
empregado.nome,
departamento.nome AS departamento
FROM
empregado
INNER JOIN departamento ON empregado.id_departamento = departamento.id
WHERE empregado.id_departamento = (SELECT empregado.id_departamento FROM empregado WHERE empregado.nome = 'Sarah'); 

-- tarefa 6.1
INSERT INTO empregado(
nome, idade, id_departamento, salario)
VALUES
('Tomás','48','3','58000')
;

-- tarefa 6.2
UPDATE empregado
SET 
    empregado.salario = empregado.salario + (empregado.salario * 0.05)
WHERE empregado.id_departamento = (SELECT departamento.id FROM departamento WHERE departamento.nome = 'TI');

DELETE FROM empregado 
WHERE id = (SELECT id FROM empregado WHERE idade > 40);




    

    