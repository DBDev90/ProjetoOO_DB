// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ProjetoOO_DB;

Produto produto1 = new Produto(1, "Caneta", 1.50M);
Console.WriteLine(produto1.getDescricao() + " " + produto1.getValor());

Pessoa pessoa1 = new Pessoa(1, "Douglas", "16999999999");
Console.WriteLine(pessoa1.getNome() + " " + pessoa1.getTelefone());


