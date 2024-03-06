// World Sound

List<string> ListaDasBandas = new List<string> { "Deftones", "Guru", "Larrodi" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());
void ExibirLogo()
{
    Console.WriteLine(@"

░██╗░░░░░░░██╗░█████╗░██████╗░██╗░░░░░██████╗░  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
░██║░░██╗░░██║██╔══██╗██╔══██╗██║░░░░░██╔══██╗  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
░╚██╗████╗██╔╝██║░░██║██████╔╝██║░░░░░██║░░██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░░████╔═████║░██║░░██║██╔══██╗██║░░░░░██║░░██║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
░░╚██╔╝░╚██╔╝░╚█████╔╝██║░░██║███████╗██████╔╝  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
░░░╚═╝░░░╚═╝░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═════╝░  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao World Sound");
}

void OpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :) ");
            break;

        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    ExibitTitulo("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    OpcoesMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibitTitulo("Exibindo todas as bandas registradas na nossa opção\n");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar para o menu principal");
    Console.ReadKey();
    Console.Clear();
    OpcoesMenu();
}

void ExibitTitulo(string titulo)
{
    int qntLetras = titulo.Length;
    string astericos = string.Empty.PadLeft(qntLetras, '*');
    Console.WriteLine(astericos);
    Console.WriteLine(titulo);
    Console.WriteLine(astericos);
}

void AvaliarUmaBanda()
{
    // digite qual banda deseja avaliar
    // se a banda existir no dicionario >> atribuir uma nota
    // senão, volta para o menu principal

    Console.Clear();
    ExibitTitulo("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        OpcoesMenu();
    }else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar para o menu principal");
        Console.ReadKey();
        Console.Clear();
        OpcoesMenu();
    }
}

void ExibirMedia()

{
    Console.Clear();
    ExibitTitulo("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        OpcoesMenu();

    }else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        OpcoesMenu();
    }
}

OpcoesMenu();
