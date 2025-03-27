select
*
from
livro
where data_publicacao 
between '1990/01/01' and '1999/12/31';

select
*
from
livro
where data_publicacao >= '1990/01/01 00:00:00'
and data_publicacao >= '1999/12/31 23:59:59'

