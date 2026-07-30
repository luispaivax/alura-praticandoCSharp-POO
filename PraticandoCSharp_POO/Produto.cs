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



