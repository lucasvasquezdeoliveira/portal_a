Feature: Cadastro de Graduação

  Scenario: Usuário deseja se cadastrar no nível de ensino "Graduação"
    Given que o usuário acessa o portal
    And o usuário escolhe a opção "Graduação"
    And seleciona o curso desejado e avança
    And o portal apresenta uma tela de cadastramento
    And o usuário preenche todos os campos
    And é apresentada uma mensagem com o usuário e senha do candidato
    And o usuário clica na opção "Acessar área do Candidato"
    When o usuário preenche o usuário e senha e clica em "Login"
    Then é apresentada a área do candidato com sucesso.



   Scenario: Usuário deseja se cadastrar no nível de ensino "Pos-Graduação"
    Given que o usuário acessa o portal
    And o usuário escolhe a opção pos
    And seleciona o curso desejado e avança
    And o portal apresenta uma tela de cadastramento
    And o usuário preenche todos os campos
    And é apresentada uma mensagem com o usuário e senha do candidato
    And o usuário clica na opção "Acessar área do Candidato"
    When o usuário preenche o usuário e senha e clica em "Login"
    Then é apresentada a área do candidato com sucesso.