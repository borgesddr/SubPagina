# Paginação 
A paginação permite que o programa possa ser espelhado por áreas não sequenciais de memória. Ou seja, o seu espaço de endereçamento logico de um único processo é dividido em páginas logicas sendo cada uma de um mesmo tamanho fixo assim como também ocorre com a memória física. Com isso o programa é executado pagina a página onde cada página logica ocupa uma página física. 
O endereçamento logico é dividido em duas partes, de início a pagina logica é utilizada como o índice no acesso a tabela de páginas com objetivo de obter o número da página física. E segundo em um deslocamento dentro da página. 

# Substituição de página 
Um algoritmo de substituição de páginas é utilizado quando dentro do sistema ocorre a falta de página e quando a memória principal já está cheia, com isso, o sistema operacional deve escolher uma página para ser removida da memória. Existem alguns tipos de algoritmos para esse tipo de operação.
	
# Fifo
Seu objetivo é parecido com a NRU, porem só armazena dados de quanto tempo cada página individualmente esta alocada na memória, sem se preocupar com seu status “acessada ou mortificada”
