/*
Visando cria ruma startup do sistema financeiro, trabalharemos para o cliente Lina

- - - - - - - - - - - - - - - - - - - - - -
Primeira parte ( Concluído )
Criar um menu de usabilidade para o uso da aplicação.
Exemplo:
====================[ Seja bem vindo ]====================

Escolha a opção:
1 - Cadastrar clientes
2 - Ver conta corrente
3 - Fazer depósito em conta
4 - Fazer saque da conta
5 - Sair do sistema

- - - - - - - - - - - - - - - - - - - - - -
Segunda parte ()
Fazer o cadastro do cliente. Ao selecionar a opção serão pedidos os seguintes dados do cliente:
-Id (guid);
-Nome;
-Telefone;
-Email;

*/

string? opcao;

List<string[]> clientes = new List<string[]>();

bool sair = false;

while (true)
{
    Console.WriteLine("""
    ====================[ Seja bem vindo ]====================
    Escolha a opção:
    1 - Cadastrar clientes
    2 - Ver conta corrente
    3 - Fazer depósito em conta
    4 - Fazer saque da conta
    5 - Sair do sistema
    6 - Mostrar clientes cadastrados
    """);

    opcao = Console.ReadLine();
    //Console.Clear();
    switch (opcao)
    {
        case "1":
            //Console.Clear();
            cadastrarCliente();
            break;
        case "2":
            //Console.Clear();
            Console.WriteLine("2");
            break;
        case "3":
            //Console.Clear();
            Console.WriteLine("3");
            break;
        case "4":
            //Console.Clear();
            Console.WriteLine("4");
            break;
        case "5":
            //Console.Clear();
            sair = true;
            Console.WriteLine("5");
            break;
        case "6":
            mostrarClientes();
            Thread.Sleep(1500);
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }

    if (sair) break;
}

void cadastrarCliente()
{
    Console.WriteLine("Cadastro de cliente:");

    string[] cliente = new string[4];

    cliente[0] = Guid.NewGuid().ToString();

    Console.WriteLine("Nome completo");
    cliente[1] = Console.ReadLine() ?? " ";

    Console.WriteLine("Telefone");
    cliente[2] = Console.ReadLine() ?? " ";

    Console.WriteLine("E-mail");
    cliente[3] = Console.ReadLine() ?? " ";

    clientes.Add(cliente);
    
    mensagem($"""Cliente {cliente[1]} cadastrado com sucesso!""");

}

void mensagem(string msg)
{
    Console.WriteLine(msg);
}

void mostrarClientes()
{
    foreach (var item in clientes)
    {
        Console.WriteLine(item[0] +' '+ item[1] +' '+item[2] +' '+item[3]);
    }
}
