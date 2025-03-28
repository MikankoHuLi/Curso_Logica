SELECT 
	livro.titulo,
    livro.data_publicacao,
    livro.preco,
    livro.isbn,
    genero.nome AS genero,
    autor.nome AS autor,
    editora.nome AS editora
FROM
    livro,
    genero,
    autor,
    editora
WHERE
    livro.id_genero = genero.id
        AND livro.id_autor = autor.id
        AND livro.id_editora = editora.id;