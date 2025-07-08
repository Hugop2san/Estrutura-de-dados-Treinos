📌 **Design com Exceções: Boa Arquitetura e Responsabilidade no Código**

Ao desenvolver sistemas, separar responsabilidades entre **camadas** é essencial para manter um código limpo, organizado e sustentável. 

Neste exemplo, a **regra de negócio** (camada inferior) é responsável por **validar e lançar exceções** como `ArgumentException`. Já a **camada de controle** (nível superior) é quem **trata essas exceções**, garantindo um fluxo controlado e seguro para o usuário final.

🔁 Esse modelo respeita o princípio da **Responsabilidade Única (Single Responsibility Principle)**:

- A lógica de negócio apenas *"grita"* quando algo está errado.
- A camada superior *escuta e decide como reagir* (exibir mensagem, registrar erro, interromper o fluxo, etc.).

💡 Esse design melhora significativamente a **manutenção do sistema**, **facilita testes automatizados** e traz **clareza para quem lê ou trabalha no código depois de você**.

---
