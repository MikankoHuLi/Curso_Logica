CREATE TABLE IF NOT EXISTS gamers (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    genero VARCHAR(50) NOT NULL ,
    jogo VARCHAR(50) NOT NULL,
    personagem VARCHAR(50) NOT NULL    
);

INSERT INTO gamers 
    (
    nome,
    genero,
    jogo,
    personagem
    )
    VALUES
    ('Guilherme Diniz','RPG','Baldurs Gate ','Shadowheart'),
    ('Eduardo Gomes','Plataforma','Sonic 3','Knuckles'),
    ('Andre Luis','FPS','Apex','Gibraltar'),
    ('Matheus Selpa','RPG','Skyrim','Dragonborn'),
    ('Kaique Perereira','Hero Shotter','Overwatch','Ana'),
    ('Bruno Luis','RPG','Baldurs Gate','Halsin'),
    ('Fernando Lima','Guerra','God of War','Kratos'),
    ('Felipe Pazzoto','RPG','Castlevania','Alucard'),
    ('Valerya Quirino','PvP','Mobile Legends','Layla'),
    ('Emily Santos','Sandbox','GTA','Cj'),
    ('Joazinho','Battle Royal','Free Fire','Walter'),
    ('Renata Ingrata','Moba','LoL','Viktor'),
    ('Bianca Diniz','Historia','Night in The Woods','Gregg'),
    ('Julia Diniz','FPS','Overwatch','Ana'),
    ('Nadia Diniz','Mobile','Pokemon Go','Pikachu');
    
        SELECT 
    *
FROM
    gamers
WHERE
    genero LIKE '%fps%';
    
    