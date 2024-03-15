/*
Visando cria ruma startup do sistema financeiro, trabalharemos para o cliente Lina

Atividade do treinamento: Lógica de programação | .Net 7 - C# 11
Github: desafio-dotnet7-csharp-11

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
Segunda parte ( Concluído )
Fazer o cadastro do cliente. Ao selecionar a opção serão pedidos os seguintes dados do cliente:
-Id (guid);
-Nome;
-Telefone;
-Email;

- - - - - - - - - - - - - - - - - - - - - -
Terceiro (concluido)

Inserir credito e débito na conta corrente do cliente (aula 07)

*/

string opcao;

List<string[]> clientes = new List<string[]>();
List<string[]> contaCorrente = new List<string[]>();

menuPrincipal();

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

void consultaContaCorrente()
{
    Console.Clear();
    Console.WriteLine("Informe o Id a consultar: ");
    mostrarClientes();
    string idCliente = Console.ReadLine();

    double saldo = 0;

    foreach (var item in contaCorrente)
    {
        if(item[0] == idCliente)
        {         
            Console.WriteLine(item[0] + ' ' + item[1] + " R$" + item[2] + ' ' + item[3]);

            if(item[1] == "C")
            { 
                saldo += double.Parse(item[2]);
            }
            
            if(item[1] == "D")
            { 
                saldo -= double.Parse(item[2]);
            }
            
        }        
    }
    Console.WriteLine("- - - - - - - - - - - - -");
    Console.WriteLine("Saldo atual: " + saldo);
}

void mensagem(string msg)
{
    Console.WriteLine(msg);
}

void menuPrincipal()
{
    Console.Clear();
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
    """);

        opcao = Console.ReadLine();
        Console.Clear();

        switch (opcao)
        {
            case "1":
                Console.Clear();
                cadastrarCliente();
                break;
            case "2":
                Console.Clear();
                consultaContaCorrente();
                break;
            case "3":
                Console.Clear();
                realizarDeposito();
                break;
            case "4":
                Console.Clear();
                realizarSaque();
                break;
            case "5":
                Console.Clear();
                sair = true;
                break;
            default:
                Console.WriteLine("Opção inválida, tente novamente.");
                break;
        }

        if (sair) break;
    }
}

void mostrarClientes()
{

    if (clientes.Count == 0)
    {
        verificaExistenciaCliente();
    }

    foreach (var item in clientes)
    {
        Console.WriteLine(item[0] + ' ' + item[1] + ' ' + item[2] + ' ' + item[3]);
    }

    Console.WriteLine("-------------------------------------------");
}

void realizarDeposito()
{
    Console.WriteLine("Informe o Id do favorecido: ");
    mostrarClientes();
    string idCliente = Console.ReadLine();

    foreach (var item in clientes)
    {
        if (item[0] == idCliente)
        {
            string[] conta = new string[4];
            Console.Write("Informe o valor a depositar: R$");
            double valorDeposito = double.Parse(Console.ReadLine());

            conta[0] = idCliente;
            conta[1] = "C";
            conta[2] = valorDeposito.ToString();
            conta[3] = DateTime.Now.ToString("dd/MM/yyyy HH:MM");

            contaCorrente.Add(conta);
        }
    }
}

void realizarSaque()
{
    Console.WriteLine("Informe o Id: ");
    mostrarClientes();
    string idCliente = Console.ReadLine();

    foreach (var item in clientes)
    {
        if (item[0] == idCliente)
        {
            string[] conta = new string[4];
            Console.Write("Informe o valor a sacar: R$");
            double valorDeposito = double.Parse(Console.ReadLine());

            conta[0] = idCliente;
            conta[1] = "D";
            conta[2] = valorDeposito.ToString();
            conta[3] = DateTime.Now.ToString("dd/MM/yyyy HH:MM");

            contaCorrente.Add(conta);
        }
    }
}

void verificaExistenciaCliente()
{
    Console.WriteLine("Sem clientes cadastrados. Deseja cadastrar agora? [S/N]");
    char resp = char.Parse(Console.ReadLine());
    string respMaiusculo = char.ToUpper(resp).ToString();

    (respMaiusculo == "S" ? (Action)cadastrarCliente : menuPrincipal)();
}
