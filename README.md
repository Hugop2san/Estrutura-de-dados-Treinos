## Resumo da arquitetura com interface e upcasting 💡 
Nesta atualização, implementei o uso de interface para desacoplar a lógica de imposto da classe RentalService. Em vez de instanciar diretamente a classe concreta BrasilTaxService dentro do serviço, criei uma interface (ITaxService) que define o contrato necessário. A classe concreta apenas implementa esse contrato.

No Program.cs, que é o nível mais alto do sistema (orquestrador), faço a instância de BrasilTaxService e passo essa instância para o construtor da RentalService, realizando um upcasting implícito: a instância concreta é tratada como um tipo abstrato (interface).

Esse padrão permite:

Flexibilidade para trocar a lógica de imposto futuramente sem alterar a regra de aluguel

Facilidade para testar (ITaxService pode ser simulado com um fake ou mock)

Redução de acoplamento entre as camadas

Adesão ao Princípio da Inversão de Dependência (DIP) e Responsabilidade Única (SRP)

## 🧠 Dica prática:
Instancie as dependências concretas no ponto mais alto do sistema (nível de orquestração), e passe abstrações (interfaces) para os níveis mais baixos (serviços, regras).
Isso permite que suas classes de lógica de negócio sejam reutilizáveis, testáveis e independentes de detalhes específicos.
