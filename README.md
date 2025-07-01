# 📘 Exercício: Trabalhador com N Contratos

## 🧾 Descrição
O objetivo deste exercício é desenvolver um pequeno sistema em C# que:

1. Lê os dados de um trabalhador (nome, nível, salário base, departamento).
2. Permite cadastrar **N contratos de trabalho** para esse trabalhador.
3. Solicita do usuário um **mês e ano** (formato MM/YYYY).
4. Calcula e exibe o **salário do trabalhador naquele mês**, considerando:
   - Salário base.
   - Soma do valor total dos contratos realizados no mês informado.

---

## 🧠 Conceitos Utilizados

- **Composição de objetos**  
  A classe `Worker` contém:
  - `WorkLevel` (enum) → nível do trabalhador.
  - `Departament` (objeto) → nome do departamento.
  - Lista de `HourContract` → contratos vinculados ao trabalhador.

- **Enumeração (Enum)**  
  Usada para representar o nível do trabalhador:
  ```csharp
  enum WorkLevel { Junior, Mid_Level, Senior }
