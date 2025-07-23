## Equals e GetHashCode em C#

Durante o projeto, foram estudados e implementados os métodos `Equals` e `GetHashCode`, que fazem parte do comportamento fundamental de objetos em C#.

### 🔁 `Equals(object obj)`

Esse método é utilizado para comparar se dois objetos são logicamente equivalentes. A implementação padrão verifica se as referências são iguais, mas é possível sobrescrevê-lo para definir uma lógica de igualdade personalizada.

**Exemplo usado no projeto:**
```csharp
public override bool Equals(object obj)
{
    if (obj is not Client)
        return false;

    Client other = obj as Client;
    return Email.Equals(other.Email);
}
public override int GetHashCode()
    {
        return  Email.GetHashCode();
    }