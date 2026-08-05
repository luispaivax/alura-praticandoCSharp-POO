/* Aula 01 e 02 - CLASSES, OBJETOS, ATRIBUTOS E MÉTODOS
class Produto
{
    public string nome;
    public string descricao;
    public decimal preco;
    public int estoque;

    public bool EstaDisponivel()
    {
        return estoque > 0;
    }

    public void AlterarPrecoComDesconto(decimal desconto)
    {
        preco = preco * (1 - desconto);
    }
}
*/

/* Ex 01
class Livro
{
    public string Titulo;
    public string Autor;
} 
*/

/* Ex 02 
class Passagem
{
    public string Passageiro { get; set; }
    public string Destino { get; set; }

    public Passagem(string passageiro, string destino)
    {
        Passageiro = passageiro;
        Destino = destino;
    }
}
*/

/* Ex 03
class ContaBancaria
{
    public string NumeroConta { get; set; }
    public double Saldo { get; set; }

    public ContaBancaria(string numeroConta, double saldoInicial)
    {
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
    }

    public void Depositar (double valor)
    {
        Saldo += valor;
    }
}
*/

/* Ex 04 
public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public Funcionario(string nomeFuncionario, string cargoAtual)
    {
        Nome = nomeFuncionario;
        Cargo = cargoAtual;
    }

    public void Promover(string novoCargo)
    {
        if (novoCargo != Cargo)
        {
            Cargo = novoCargo;
            Console.WriteLine("Promoção realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Erro: O novo cargo deve ser diferente do cargo atual.");
        }
    }
}
*/

/* Ex 05 
public class Retangulo
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public double CalcularArea()
    {
        return Altura * Largura;
    }
}
*/

/* Ex 06 
public class Filme
{
    public string Titulo { get; set; }
    public int ClassificacaoEtaria { get; set; }

    public Filme(string filmeTitulo, int clEtaria)
    {
        Titulo = filmeTitulo;
        ClassificacaoEtaria = clEtaria;
    }

    public bool PodeAssistir(int idadeUsuario)
    {
        return idadeUsuario >= ClassificacaoEtaria;
    }

    public void ExibirResultado(int idadeUsuario)
    {
        if (PodeAssistir(idadeUsuario))
        {
            Console.WriteLine($"Usuário com {idadeUsuario} anos pode assistir ao filme {Titulo}.");
        }
        else
        {
            Console.WriteLine($"Usuário com {idadeUsuario} anos não pode assistir ao filme {Titulo}.");
        }
    }
}
*/

/* Ex 07 

*/

public class Produto
{
    public string Nome { get; set; }
    private int quantidadeEstoque;

    public Produto(string nome, int quantidadeInicial)
    {
        Nome = nome;
        quantidadeEstoque = quantidadeInicial;
    }

    public void Retirar(int quantidade)
    {
        if (quantidade <= quantidadeEstoque)
        {
            quantidadeEstoque -= quantidade;
            Console.WriteLine($"Retirada de {quantidade} unidades realizada com sucesso.");
        }
        else
        {
            Console.WriteLine($"Erro: Estoque insuficiente para retirada de {quantidade} unidades.");
        }
    }

    public void ExibirEstoque()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Estoque: {quantidadeEstoque}");
    }
}
