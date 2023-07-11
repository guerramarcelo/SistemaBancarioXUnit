public class GerenciadoraClientesTest_Ex5 
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
		int idCLiente01 = 1;
		int idCLiente02 = 2;
		Cliente cliente01 = new Cliente(idCLiente01, "Gustavo Farias", 31, "gugafarias@gmail.com", 1, true);
		Cliente cliente02 = new Cliente(idCLiente02, "Felipe Augusto", 34, "felipeaugusto@gmail.com", 1, true);
		
		// inserindo os clientes criados na lista de clientes do banco
		List<Cliente> clientesDoBanco = new List<Cliente>();
		clientesDoBanco.Add(cliente01);
		clientesDoBanco.Add(cliente02);
		
		gerClientes = new GerenciadoraClientes(clientesDoBanco);

		/* ========== Execução ========== */
		Cliente? cliente = gerClientes.PesquisaCliente(idCLiente01);
		
		/* ========== Verificações ========== */
		Assert.Equal(cliente?.GetId(), idCLiente01);		
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
		int idCLiente01 = 1;
		int idCLiente02 = 2;
		Cliente cliente01 = new Cliente(idCLiente01, "Gustavo Farias", 31, "gugafarias@gmail.com", 1, true);
		Cliente cliente02 = new Cliente(idCLiente02, "Felipe Augusto", 34, "felipeaugusto@gmail.com", 1, true);
		
		// inserindo os clientes criados na lista de clientes do banco
		List<Cliente> clientesDoBanco = new List<Cliente>();
		clientesDoBanco.Add(cliente01);
		clientesDoBanco.Add(cliente02);
		
		gerClientes = new GerenciadoraClientes(clientesDoBanco);
		
		/* ========== Execução ========== */
		bool clienteRemovido = gerClientes.RemoveCliente(idCLiente02);
		
		/* ========== Verificações ========== */
		Assert.Equal(clienteRemovido, true);
		Assert.Equal(gerClientes.GetClientesDoBanco().Count, 1);
		Assert.Null(gerClientes.PesquisaCliente(idCLiente02));
		
	}	
}