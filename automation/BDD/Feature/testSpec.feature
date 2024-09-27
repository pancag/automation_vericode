Feature: Teste para candidatura na Vericode

  Scenario: Preencher campos de um formulário
    Given Estou na pagina esperada
    When Eu preencher os campos primeiros 4 campos
    | make | model | CMM | kW |
    | BMW  | Moped | 150 | 1500 |
    Then O teste está concluído