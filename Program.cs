/*
Visando cria ruma startup do sistema financeiro, trabalharemos para o cliente Lina

Primeira parte ( )
Criar um menu de usabilidade para o uso da aplicação.
Exemplo:
====================[ Seja bem vindo ]====================

Escolha a opção:
1 - Cadastrar clientes
2 - Ver conta corrente
3 - Fazer depósito em conta
4 - Fazer saque da conta
5 - Sair do sistema
*/

Console.WriteLine("""
    ====================[ Seja bem vindo ]====================

    Escolha a opção:
    1 - Cadastrar clientes
    2 - Ver conta corrente
    3 - Fazer depósito em conta
    4 - Fazer saque da conta
    5 - Sair do sistema
""");

int opcao = int.Parse(Console.ReadLine());

while(true)
{
    switch (opcao)
    {
        case 1:
            Console.WriteLine("1");
            break;
        case 2:
            Console.WriteLine("2");
            break;
        case 3:
            Console.WriteLine("3");
            break;
        case 4:
            Console.WriteLine("4");
            break;
        case 5:
            Console.WriteLine("5");
            break;
        default:
            Console.WriteLine("X");
            break;
    }
}