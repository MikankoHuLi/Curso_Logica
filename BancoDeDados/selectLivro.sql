SELECT 
	livro.titulo,
    livro.data_publicacao,
    livro.preco,
    livro.isbn,
    genero.nome AS genero,
    autor.nome AS autor,
    editora.nome AS editora
FROM
    livro
    JOIN genero ON livro.id_genero = genero.id
    JOIN autor ON livro.id_autor = autor.id
    JOIN editora ON livro.id_editora = editora.id;
