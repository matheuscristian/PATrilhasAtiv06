// C# Script para a versão do .Net 9.0

struct Produto
{
    public string nome;
    public decimal preco;
    public int quantidade;
}

static void cadastrar_produto(Produto[] produtos, ref int quantidade_produtos) {
    if (quantidade_produtos == produtos.Length) {
        Console.WriteLine($"Não há mais espaço para cadastrar novos produtos (no máximo {produtos.Length})");
        return;
    }
    
    var _produto = new Produto();

    Console.Write("Digite o nome do produto: ");
    _produto.nome = Console.ReadLine().Trim();

    Console.Write("Digite o preco do produto: ");
    _produto.preco = decimal.Parse(Console.ReadLine().Trim());

    Console.Write("Digite a quantidade do produto no estoque: ");
    _produto.quantidade = int.Parse(Console.ReadLine().Trim());

    produtos[quantidade_produtos] = _produto;

    quantidade_produtos++;
}
static void exibir_valor_total(Produto[] produtos, int quantidade_produtos) {
    decimal valor_mercadorias = 0;
    for (int i = 0; i < quantidade_produtos; i++)
    {
        ref Produto produto = ref produtos[i];
        decimal valor_total_produto = produto.preco * produto.quantidade;
        
        Console.WriteLine($"{produto.nome} -- {valor_total_produto}");

        valor_mercadorias += valor_total_produto;
    }

    Console.WriteLine($"O valor total em mercadorias é {valor_mercadorias}");
}

static void exibir_menu() {
    Console.WriteLine("MENU");
    Console.WriteLine("1. Cadastrar mercadorias");
    Console.WriteLine("2. Exibir valor total em mercadorias da empresa");
    Console.WriteLine("3. Sair");
    Console.Write("> ");
}

var produtos = new Produto[40];
int quantidade_produtos = 0;

Console.Clear();
exibir_menu();

char e; 
while (true) {
    e = Console.ReadLine().Trim()[0];
    Console.Clear();

    if (e  == '1') {
        cadastrar_produto(produtos, ref quantidade_produtos);
    } else if (e == '2') {
        exibir_valor_total(produtos, quantidade_produtos);
    } else {
        break;
    }

    Console.Write("\n\n");
    exibir_menu();
}

