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
Segunda parte ( Concluído )
Fazer o cadastro do cliente. Ao selecionar a opção serão pedidos os seguintes dados do cliente:
-Id (guid);
-Nome;
-Telefone;
-Email;

- - - - - - - - - - - - - - - - - - - - - -
Terceiro ()

Inserir credito e débito na conta corrente do cliente

*/

string? opcao;

List<string[]> clientes = new List<string[]>();
List<string[]> contaCorrente = new List<string[]>();

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
    Console.Clear();
    
    switch (opcao)
    {
        case "1":
            Console.Clear();
            cadastrarCliente();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("2");
            consultaContaCorrente();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("3");
            realizarDeposito();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("4");
            break;
        case "5":
            Console.Clear();
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

void consultaContaCorrente()
{
    foreach (var item in contaCorrente)
    {
        
        Console.WriteLine(item[0] +' '+ item[1] +' '+item[2]);
    }
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

void realizarDeposito()
{
    Console.WriteLine("Informe o Id do favorecido: ");
    mostrarClientes();
    string? idCliente = Console.ReadLine();
    
    foreach (var item in clientes)
    {
        if(item[0] == idCliente){
            string[] conta = new string[3];
            System.Console.Write("Informe o valor a depositar: R$");
            double valorDeposito = double.Parse(Console.ReadLine());
            DateTime hora = DateTime.Now;

            conta[0] = idCliente;
            conta[1] = valorDeposito.ToString();
            conta[2] = hora.ToString();

            contaCorrente.Add(conta);
        }
    }
}

// iniciando programa lina