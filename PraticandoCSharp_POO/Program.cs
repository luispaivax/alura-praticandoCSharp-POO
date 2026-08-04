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

/* Ex02
Passagem passagem = new Passagem("Lucas", "Paris");

Console.WriteLine($@"
Passageiro: {passagem.Passageiro}
Destino: {passagem.Destino}
");
*/

/* Ex03
ContaBancaria conta = new ContaBancaria("78901-2", 1000.00);
conta.Depositar(500.00);

Console.WriteLine($@"
Conta: {conta.NumeroConta}
Saldo atual: R${conta.Saldo.ToString("F2")}
");
*/

/* Ex04 
class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario("Carlos Pereira", "Assistente Administrativo");

        Console.WriteLine($"Funcionário: {funcionario.Nome}");
        Console.WriteLine($"Cargo Atual: {funcionario.Cargo}");

        Console.WriteLine("");

        funcionario.Promover("Assistente Administrativo"); // Tentativa inválida

        Console.WriteLine("");

        funcionario.Promover("Analista de Projetos");       // Promoção válida

        Console.WriteLine("--- Após promoção ---");
        Console.WriteLine("Funcionário: " + funcionario.Nome);
        Console.WriteLine("Cargo Atual: " + funcionario.Cargo);
    }
}
*/

/* Ex05
class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();
        retangulo.Altura = 5;
        retangulo.Largura = 8;

        Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea()}");
    }
}
*/

/* Ex06
Filme filme = new Filme("Mad Max", 18);
filme.ExibirResultado(23);
filme.ExibirResultado(14);
*/



