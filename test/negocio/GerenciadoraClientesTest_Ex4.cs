public class GerenciadoraClientesTest_Ex4 
{
	private GerenciadoraClientes? gerClientes;
	/**
	 * Teste básico da pesquisa de um cliente a partir do seu ID.
	 * 
	 * @author Marcelo Guerra
	 * @date 10/07/2023
	 */
	[Fact]
	public void testPesquisaCliente() 
    {
		/* ========== Montagem do cenário ========== */
		
		// criando alguns clientes
		Cliente cliente01 = new Cliente(1, "Gustavo Farias", 31, "gugafarias@gmail.com", 1, true);
		Cliente cliente02 = new Cliente(2, "Felipe Augusto", 34, "felipeaugusto@gmail.com", 1, true);
		
		// inserindo os clientes criados na lista de clientes do banco
		List<Cliente> clientesDoBanco = new List<Cliente>();
		clientesDoBanco.Add(cliente01);
		clientesDoBanco.Add(cliente02);
		
		gerClientes = new GerenciadoraClientes(clientesDoBanco);

		/* ========== Execução ========== */
		Cliente? cliente = gerClientes.PesquisaCliente(1);
		
		/* ========== Verificações ========== */
		Assert.Equal(cliente?.GetId(), 1);		
	}
	
	/**
	 * Teste básico da remoção de um cliente a partir do seu ID.
	 * 
	 * @author Marcelo Guerra
	 * @date 10/07/2023
	 */
	[Fact]
	public void testRemoveCliente() {

		/* ========== Montagem do cenário ========== */
		
		// criando alguns clientes
		Cliente cliente01 = new Cliente(1, "Gustavo Farias", 31, "gugafarias@gmail.com", 1, true);
		Cliente cliente02 = new Cliente(2, "Felipe Augusto", 34, "felipeaugusto@gmail.com", 1, true);
		
		// inserindo os clientes criados na lista de clientes do banco
		List<Cliente> clientesDoBanco = new List<Cliente>();
		clientesDoBanco.Add(cliente01);
		clientesDoBanco.Add(cliente02);
		
		gerClientes = new GerenciadoraClientes(clientesDoBanco);
		
		/* ========== Execução ========== */
		bool clienteRemovido = gerClientes.RemoveCliente(2);
		
		/* ========== Verificações ========== */
		Assert.Equal(clienteRemovido, true);
		Assert.Equal(gerClientes.GetClientesDoBanco().Count, 1);
		Assert.Null(gerClientes.PesquisaCliente(2));		
	}	
}