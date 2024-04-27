Console.Write("Qual a quantidade de nomes:");
string[] nomes = new string[int.Parse(Console.ReadLine())];
string pesquisa;
bool encontrado = false;

for (int i = 0; i < nomes.Length; i++)
{
    Console.Write($"Qual o {i + 1}º nome:");
    nomes[i] = Console.ReadLine();
}

Console.Write("Qual nome você quer pesquisar:");
pesquisa = Console.ReadLine();

for (int i = 0; i < nomes.Length; i++)
{
    if (pesquisa == nomes[i])
    {
        Console.WriteLine($"O nome {pesquisa} está na posição {i + 1}.");
        encontrado = true;
        break;
    }
}

if (!encontrado)
{
    Console.WriteLine("Nome não encontrado");
}