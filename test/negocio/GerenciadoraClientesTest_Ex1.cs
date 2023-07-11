public class GerenciadoraClientesTest_Ex1
{
	[Fact]
	public void TestPesquisaCliente()
	{
		// criando alguns clientes
		Cliente cliente01 = new Cliente(1, "Gustavo Farias", 31, "gugafarias@gmail.com", 1, true);
		Cliente cliente02 = new Cliente(2, "Felipe Augusto", 34, "felipeaugusto@gmail.com", 2, true);
		
		// inserindo os clientes criados na lista de clientes do banco
		List<Cliente> clientesDoBanco = new List<Cliente>();
		clientesDoBanco.Add(cliente01);
		clientesDoBanco.Add(cliente02);
		
		GerenciadoraClientes gerClientes = new GerenciadoraClientes(clientesDoBanco);
		
		Cliente? cliente = gerClientes.PesquisaCliente(1);
		
		Assert.Equal(cliente?.GetId(), 1);
		Assert.Equal(cliente?.GetEmail(), "gugafarias@gmail.com");
    }
}

