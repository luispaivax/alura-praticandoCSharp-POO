/* Aula 01 e 02 - CLASSES, OBJETOS, ATRIBUTOS E MÉTODOS

Produto item1 = new Produto();
item1.nome = "Teclado";
item1.descricao = "Modelo compacto e silencioso," + " perfeito para produtividade diária.";
item1.preco = 80.00m;
item1.estoque = 15;

Console.WriteLine($@"Dados do item 1:
Nome: {item1.nome};
Descricao: {item1.descricao};
Preço: R${item1.preco};
Estoque: {item1.estoque}.
");

if (item1.EstaDisponivel())
{
    Console.WriteLine("Produto está disponível!");
}

item1.AlterarPrecoComDesconto(0.2m);

Console.WriteLine($@"Dados do item 1:
Nome: {item1.nome};
Descricao: {item1.descricao};
Preço: R${item1.preco};
Estoque: {item1.estoque}.
");

*/

/* Ex01
Livro livro1 = new Livro();
livro1.Titulo = "Dom Casmurro";
livro1.Autor = "Machado de Assis";

Console.WriteLine(@$"Dados do livro 1: 
Livro: {livro1.Titulo}
Autor: {livro1.Autor}
");
*/


