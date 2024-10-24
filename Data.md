Estrat�gia de Manuten��o de Dados Durante Execu��o de Testes
Este documento descreve o processo para garantir que os dados de testes sejam manipulados corretamente antes, durante e ap�s a execu��o dos testes.

1. Verifica��o Pr�-Testes
Antes da execu��o dos testes, � essencial garantir que os dados necess�rios j� estejam presentes no banco de dados. Essa etapa evita problemas de inconsist�ncia ou falta de dados durante os testes.

A��o: Verifique se os dados relevantes (como dados de clientes) j� est�o presentes na base de dados. Caso estejam, os registros devem ser mantidos para evitar duplica��es desnecess�rias.

Objetivo: Garantir que a base de dados esteja limpa ou tenha os dados esperados para a execu��o dos testes sem a necessidade de inser��es redundantes.


SELECT * FROM clientes WHERE email = 'cliente_teste@exemplo.com';
Se n�o houver resultados, pode ser iniciado os testes.

2. Execu��o dos Testes
Ap�s a verifica��o inicial, execute os testes. Durante essa etapa, o sistema deve interagir com a base de dados e realizar as opera��es necess�rias, como cria��o de registros, atualiza��es, etc.


3. Valida��o P�s-Testes
Ap�s a execu��o dos testes, � crucial validar se os dados foram criados corretamente na base de dados, garantindo que os testes refletiram as opera��es esperadas.


SELECT * FROM clientes WHERE email = 'cliente_teste@exemplo.com';
Verifique se as informa��es est�o corretas, como nome, email, telefone, etc.

4. Limpeza de Dados P�s-Testes
Para evitar inconsist�ncias em futuras execu��es de testes, � necess�rio limpar a base de dados removendo os dados de teste criados.

DELETE FROM clientes WHERE email = 'cliente_teste@exemplo.com';
