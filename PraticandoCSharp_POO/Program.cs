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