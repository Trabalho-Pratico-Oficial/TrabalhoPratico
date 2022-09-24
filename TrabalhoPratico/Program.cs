using TrabalhoPratico;

bool userUsing = true;
while (userUsing)
{
    Console.WriteLine("Bem vindo!\nO que deseja fazer hoje?");
    Console.WriteLine("1 - Registrar\n2 - Entrar\n3 - Encerrar");
    var userInputMenuChoice = Console.ReadLine();
    if (userInputMenuChoice == "1")
    {
        //IMPLEMENTAR CADASTRO
    }
    else if (userInputMenuChoice == "2")
    {
        //IMPLEMENTAR LOGIN
    }
    else if (userInputMenuChoice == "3")
    {
        //IMPLEMENTAR ENCERRAR O CODIGO
    }
    else
    {
        Console.WriteLine("Opção não disponível, tente novamente");
    }
}