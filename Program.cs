// Screen Sound

using System.ComponentModel;
using System.Runtime.ExceptionServices;

string MsgWelcome = ("Digite uma das opções para prosseguir!");
string FirstTextContent = (@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");

string opc1 = (@"
██████╗░███████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██████╔╝█████╗░░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██╔══██╗██╔══╝░░██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
██║░░██║███████╗╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝
██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░
");

string opc2 = (@"
████████╗░█████╗░██████╗░░█████╗░░██████╗  ░█████╗░░██████╗  ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔════╝  ██╔══██╗██╔════╝  ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
░░░██║░░░██║░░██║██║░░██║███████║╚█████╗░  ███████║╚█████╗░  ██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
░░░██║░░░██║░░██║██║░░██║██╔══██║░╚═══██╗  ██╔══██║░╚═══██╗  ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
░░░██║░░░╚█████╔╝██████╔╝██║░░██║██████╔╝  ██║░░██║██████╔╝  ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
░░░╚═╝░░░░╚════╝░╚═════╝░╚═╝░░╚═╝╚═════╝░  ╚═╝░░╚═╝╚═════╝░  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░
");

string opc3 = (@"

░█████╗░██╗░░░██╗░█████╗░██╗░░░░░██╗░█████╗░██████╗░  ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██║░░░██║██╔══██╗██║░░░░░██║██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
███████║╚██╗░██╔╝███████║██║░░░░░██║███████║██████╔╝  ██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██║░╚████╔╝░██╔══██║██║░░░░░██║██╔══██║██╔══██╗  ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██║░░██║░░╚██╔╝░░██║░░██║███████╗██║██║░░██║██║░░██║  ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝╚═╝░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░
");

string opc4 = (@"
███╗░░░███╗███████╗██████╗░██╗░█████╗░  ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
████╗░████║██╔════╝██╔══██╗██║██╔══██╗  ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██╔████╔██║█████╗░░██║░░██║██║███████║  ██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██║╚██╔╝██║██╔══╝░░██║░░██║██║██╔══██║  ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██║░╚═╝░██║███████╗██████╔╝██║██║░░██║  ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░
");

// List<string> ListBandas = new List<string>();
Dictionary<string, List<int>> ListBandas = new Dictionary<string, List<int>>();


void ShowMsgWelcome()
{
    Console.WriteLine(FirstTextContent);
    Console.WriteLine(MsgWelcome);
}

void BackMenu()
{
    Console.WriteLine("\nPressione qualquer tecla para voltar");
    Console.ReadLine();
    Console.Clear();
    ShowOpcMenu();
}
void ShowOpcMenu()
{
    ShowMsgWelcome();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média das bandas");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nDigite um numero: ");
    string SelectOpcMenu = Console.ReadLine();

    if (int.TryParse(SelectOpcMenu, out int SelectOpcMenuNumber))
    {
        Console.WriteLine("\n");

        switch (SelectOpcMenuNumber)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Você escolheu a opção " + SelectOpcMenuNumber);
                RegBanda();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Você escolheu a opção " + SelectOpcMenuNumber);
                AllBanda();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Você escolheu a opção " + SelectOpcMenuNumber);
                EvalBanda();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Você escolheu a opção " + SelectOpcMenuNumber);
                AverBanda();
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("Você escolheu sair do programa com a opção " + SelectOpcMenuNumber);
                break;
            default:
                Console.WriteLine("Opção " + SelectOpcMenuNumber + " invalida!");
                break;
        }
    }
    else
    {
        Console.WriteLine("Opção inválida, tente novamente!");
        BackMenu();
    }
}

void RegBanda()
{
    Console.WriteLine(opc1);
    Console.Write("Digite o nome da banda: ");
    string NameBanda = Console.ReadLine()!;
    ListBandas.Add(NameBanda, new List<int>());
    Console.WriteLine("\nO nome da banda criada foi " + NameBanda);
    BackMenu();
};

void AllBanda()
{
    Console.WriteLine(opc2);
    Console.WriteLine("Segue todas as bandas registradas!\n");
    
    foreach (string banda in ListBandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    BackMenu();
};

void EvalBanda()
{
    Console.WriteLine(opc3);
    Console.Clear();
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string NameOfBanda = Console.ReadLine()!;
    if (ListBandas.ContainsKey(NameOfBanda))
    {
        Console.Write($"Qual a nota que a banda {NameOfBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        ListBandas[NameOfBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {NameOfBanda}");
        BackMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {NameOfBanda} não foi encontrada!");
        BackMenu();
    }
};

void AverBanda()
{
    Console.WriteLine(opc4);
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string NameOfBanda = Console.ReadLine()!;
    if (ListBandas.ContainsKey(NameOfBanda))
    {
        List<int> notasDaBanda = ListBandas[NameOfBanda];
        Console.WriteLine($"\nA média da banda {NameOfBanda} é {notasDaBanda.Average()}.");
        BackMenu();
    }
    else
    {
        Console.WriteLine($"\n A banda {NameOfBanda} não foi encontrada.");
        BackMenu();
    }
};

ShowOpcMenu();