# Treino com Enums, Switch Expressions e Exceções em C#

## 📚 Conteúdo Estudado

### ✅ Enums (`enum`)
Utilização de enums para representar um conjunto fixo de estados de uma entidade, como por exemplo:
- `Pending`
- `Processing`
- `Shipped`
- `Delivered`
- `Cancelled`

Isso facilita a leitura e organização do código, substituindo valores mágicos por nomes descritivos.

---

### ✅ Switch Expression com `throw`
Exploração do `switch` moderno com `=>`, permitindo mapear valores diretamente e lançar exceções de forma concisa quando necessário.

Exemplo:

```csharp
OrderStatus status = codigo switch
{
    1 => OrderStatus.Pending,
    2 => OrderStatus.Processing,
    _ => throw new ArgumentOutOfRangeException("Código de status inválido")
};

