public class Program
{   
    public void Main()
    {
		GerenciadoraClientes? gerClientes;
    	GerenciadoraContas? gerContas;

         // criando lista vazia de contas e clientes
        List<ContaCorrente> contasDoBanco = new List<ContaCorrente>();
        List<Cliente> clientesDoBanco = new List<Cliente>();

        // criando e inserindo duas contas na lista de contas correntes do banco
        ContaCorrente conta01 = new ContaCorrente(1, 0, true);
        ContaCorrente conta02 = new ContaCorrente(2, 0, true);
        contasDoBanco.Add(conta01);
        contasDoBanco.Add(conta02);

        // criando dois clientes e associando as contas criadas acima a eles
        Cliente cliente01 = new Cliente(1, "Gustavo Farias", 31, "gugafarias@gmail.com", conta01.GetId(), true);
        Cliente cliente02 = new Cliente(2, "Felipe Augusto", 34, "felipeaugusto@gmail.com", conta02.GetId(), true);
        // inserindo os clientes criados na lista de clientes do banco
        clientesDoBanco.Add(cliente01);
        clientesDoBanco.Add(cliente02);

        gerClientes = new GerenciadoraClientes(clientesDoBanco);
        gerContas = new GerenciadoraContas(contasDoBanco);
        bool continua = true;

        while (continua)
        {
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                // Consultar por um cliente
                case 1:
                    Console.Write("Digite o ID do cliente: ");
                    int idCliente = Convert.ToInt32(Console.ReadLine());
                    Cliente? cliente = gerClientes.PesquisaCliente(idCliente);

                    if (cliente != null)
                        Console.WriteLine(cliente.ToString());
                    else
                        Console.WriteLine("Cliente não encontrado!");

                    PulaLinha();
                    break;

                // Consultar por uma conta corrente
                case 2:
                    Console.Write("Digite o ID da conta: ");
                    int idConta = Convert.ToInt32(Console.ReadLine());
                    ContaCorrente? conta = gerContas.PesquisaConta(idConta);

                    if (conta != null)
                        Console.WriteLine(conta.ToString());
                    else
                        Console.WriteLine("Conta não encontrada!");

                    PulaLinha();
                    break;

                // Ativar um cliente
                case 3:
                    Console.Write("Digite o ID do cliente: ");
                    int idCliente2 = Convert.ToInt32(Console.ReadLine());
                    Cliente? cliente2 = gerClientes.PesquisaCliente(idCliente2);

                    if (cliente2 != null)
                    {
                        cliente2.SetAtivo(true);
                        Console.WriteLine("Cliente ativado com sucesso!");
                    }
                    else
                        Console.WriteLine("Cliente não encontrado!");

                    PulaLinha();
                    break;

                // Desativar um cliente
                case 4:
                    Console.Write("Digite o ID do cliente: ");
                    int idCliente3 = Convert.ToInt32(Console.ReadLine());
                    Cliente? cliente3 = gerClientes.PesquisaCliente(idCliente3);

                    if (cliente3 != null)
                    {
                        cliente3.SetAtivo(false);
                        Console.WriteLine("Cliente desativado com sucesso!");
                    }
                    else
                        Console.WriteLine("Cliente não encontrado!");

                    PulaLinha();
                    break;

                // Sair
                case 5:
                    continua = false;
                    Console.WriteLine("################# Sistema encerrado #################");
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
            }
        }
	}

    private void PulaLinha()
    {
        Console.WriteLine();
    }
    /**
     * Imprime o menu de opções do nosso sistema bancário
     */
    private void PrintMenu()
    {
        Console.WriteLine("O que você deseja fazer?\n");
        Console.WriteLine("1) Consultar por um cliente");
        Console.WriteLine("2) Consultar por uma conta corrente");
        Console.WriteLine("3) Ativar um cliente");
        Console.WriteLine("4) Desativar um cliente");
        Console.WriteLine("5) Sair\n");
    } 	
}
