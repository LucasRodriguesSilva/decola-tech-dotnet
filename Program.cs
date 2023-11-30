using Project.Models;

People pessoa1 = new People();

pessoa1.Name = "Lucas";
pessoa1.Age = 25;

pessoa1.Apresentar();

int transformandoLetraEmNumero = Convert.ToInt32("10");

string transformandoNumeroEmLetra = transformandoLetraEmNumero.ToString();

// resultado tem que ser 105
Console.WriteLine(transformandoNumeroEmLetra + 5);

string letra10 = "10";
int transfomarndoLetra10EmInteiro = int.Parse(letra10);

// tem que ser 20
Console.WriteLine(transfomarndoLetra10EmInteiro + 10);

string letraComInteiroErrado  = "10-";

int numeroParaSubstituirOErrado = 0;

int.TryParse(letraComInteiroErrado, out numeroParaSubstituirOErrado);

// Se o letra estiver errado, vai ser exibido o número 0
Console.WriteLine(numeroParaSubstituirOErrado);

// Compra de produto, verificando a quantidade no estoque
int quantidadeNoEstoque = 10;
int quantidadeDeCompra = 10;
bool quantidadeDeCompraInvalida = quantidadeDeCompra == 0;
bool quantidadeETemEstoqueValido = quantidadeNoEstoque >= quantidadeDeCompra;
if(quantidadeDeCompraInvalida)
{
    Console.WriteLine("Quantidade de compra incorreta");
}
else if(quantidadeETemEstoqueValido)
{
    Console.WriteLine("Obrigado pela compra!");
}
else
{
    Console.WriteLine("Não temos em estoque");
}