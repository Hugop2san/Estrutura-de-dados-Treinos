## 🧠 Aprendizado: Interfaces, IComparable e Downcasting em C#
Durante meus estudos em orientação a objetos com C#, explorei conceitos fundamentais como:

# ✅ Interfaces: Implementei a interface IComparable<Produto> para permitir que objetos da classe Produto possam ser comparados entre si — por exemplo, ordenando por preço.

# 🔁 Método CompareTo(): Dentro do método, utilizei o recurso de downcasting para converter o objeto object para o tipo Produto, possibilitando a comparação correta dos valores de Preço.

# 🧬 GetHashCode(): Também utilizei esse método para gerar identificadores únicos dos objetos, reforçando o entendimento sobre como coleções baseadas em hash funcionam.

Produto produto = outro as Produto;
return this.Preco.CompareTo(produto.Preco);

Esses conceitos são essenciais para manipular coleções de objetos de forma eficiente e para compreender melhor os pilares da programação orientada a objetos.
