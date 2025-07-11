📌 Fala, rede! Hoje mergulhei nos conceitos de design usando Orientação a Objetos — mais especificamente na ideia de separar responsabilidades entre classes.

Pra você ter uma noção, imagine que temos uma classe que representa o aluguel de um carro (CarRental) e outra que representa a fatura desse aluguel (Invoice). Em vez de juntar tudo numa só, cada uma fica responsável por uma parte do sistema — isso é o que chamamos de encapsulamento.

Aí entra a composição: o aluguel “tem uma” fatura. Ou seja, o objeto aluguel mantém uma referência pra fatura, deixando o código organizado e fácil de manter. Se precisar mudar algo na fatura, não preciso mexer no aluguel — só na classe da fatura.

Essa estrutura ajuda muito na manutenção e na clareza do projeto, mostrando que pensar no design desde o começo faz toda diferença!
