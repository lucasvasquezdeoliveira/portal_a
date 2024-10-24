Estratégia de Manutenção de Dados Durante Execução de Testes
Este documento descreve o processo para garantir que os dados de testes sejam manipulados corretamente antes, durante e após a execução dos testes.

1. Verificação Pré-Testes
Antes da execução dos testes, é essencial garantir que os dados necessários já estejam presentes no banco de dados. Essa etapa evita problemas de inconsistência ou falta de dados durante os testes.

Ação: Verifique se os dados relevantes (como dados de clientes) já estão presentes na base de dados. Caso estejam, os registros devem ser mantidos para evitar duplicações desnecessárias.

Objetivo: Garantir que a base de dados esteja limpa ou tenha os dados esperados para a execução dos testes sem a necessidade de inserções redundantes.


SELECT * FROM clientes WHERE email = 'cliente_teste@exemplo.com';
Se não houver resultados, pode ser iniciado os testes.

2. Execução dos Testes
Após a verificação inicial, execute os testes. Durante essa etapa, o sistema deve interagir com a base de dados e realizar as operações necessárias, como criação de registros, atualizações, etc.


3. Validação Pós-Testes
Após a execução dos testes, é crucial validar se os dados foram criados corretamente na base de dados, garantindo que os testes refletiram as operações esperadas.


SELECT * FROM clientes WHERE email = 'cliente_teste@exemplo.com';
Verifique se as informações estão corretas, como nome, email, telefone, etc.

4. Limpeza de Dados Pós-Testes
Para evitar inconsistências em futuras execuções de testes, é necessário limpar a base de dados removendo os dados de teste criados.

DELETE FROM clientes WHERE email = 'cliente_teste@exemplo.com';
