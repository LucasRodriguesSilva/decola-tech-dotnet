// esse código é somente das aulas que estou aprendendo na DIO.

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

// Aqui é escolhido uma vogal

Console.WriteLine("Escolha uma vogal");
// string vogal = Console.ReadLine();
// Conmentei o código ReadLine, para ter um código contínuo
string vogal = "A";

// coloquei um ToLower para que a letra maiúscula se transoforme em minúscula e possa ser feita a verificação
switch (vogal.ToLower())
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Isso é uma vogal!");
        break;

    default:
        Console.WriteLine("Isso não é uma vogal");
        break;
}

// Operadores

bool maiorDeIdade = true;
bool possuiAutorizacaoDeUmResponsavel = false;

if(maiorDeIdade || possuiAutorizacaoDeUmResponsavel)
{
    Console.WriteLine("Entrada autorizada!");
}
else
{
    Console.WriteLine("Não possui autorização para entrar");
}

bool estavaPresenteNasAulas = false;
double qualFoiAMedia = 7.5;

if(estavaPresenteNasAulas && qualFoiAMedia == 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}


bool taChovendo = false;
bool taTarde = false;

if(!taChovendo && !taTarde)
{
    Console.WriteLine("Uhul, vamos pedalar de bicicleta!");
}
else
{
    Console.WriteLine("Hoje não tem como sair de bicicleta");
}

Calculadora calcular = new Calculadora();

calcular.Somar(5, 7);
calcular.Subtrair(1, 10);
calcular.Multiplicar(-1, 10);
calcular.Dividir(10, 3);
calcular.Potenciacao(3, 3);
calcular.Seno(30);
calcular.Conseno(30);
calcular.Tangente(30);