public class GerenciadoraClientesTest_Ex7 : IDisposable
{
    private GerenciadoraClientes? gerClientes;
    private int idCliente01 = 1;
    private int idCliente02 = 2;

    public GerenciadoraClientesTest_Ex7()
    {
        // Configuração inicial para todos os testes
        SetUp();
    }

    public void Dispose()
    {
        // Limpeza após os testes
        TearDown();
    }

    private void SetUp()
    {
        /* ========== Montagem do cenário ========== */

        // criando alguns clientes
        Cliente cliente01 = new Cliente(idCliente01, "Gustavo Farias", 31, "gugafarias@gmail.com", 1, true);
        Cliente cliente02 = new Cliente(idCliente02, "Felipe Augusto", 34, "felipeaugusto@gmail.com", 1, true);

        // inserindo os clientes criados na lista de clientes do banco
        List<Cliente> clientesDoBanco = new List<Cliente>();
        clientesDoBanco.Add(cliente01);
        clientesDoBanco.Add(cliente02);

        gerClientes = new GerenciadoraClientes(clientesDoBanco);

        Console.WriteLine("SetUp foi executado");
    }

    private void TearDown()
    {
        gerClientes?.Limpa();
        Console.WriteLine("TearDown foi executado");
    }

    /**
     * Teste básico da pesquisa de um cliente a partir do seu ID.
     */
    [Fact]
    public void TestPesquisaCliente()
    {
        /* ========== Execução ========== */
        Cliente? cliente = gerClientes?.PesquisaCliente(idCliente01);

        /* ========== Verificações ========== */
        Assert.Equal(cliente?.GetId(), idCliente01);
    }

    /**
     * Teste básico da remoção de um cliente a partir do seu ID.
     */
    [Fact]
    public void TestRemoveCliente()
    {
        /* ========== Execução ========== */
        bool clienteRemovido = gerClientes?.RemoveCliente(idCliente02) ?? false;

        /* ========== Verificações ========== */
        Assert.True(clienteRemovido);
        Assert.Equal(1, gerClientes?.GetClientesDoBanco()?.Count ?? 0);
        Assert.Null(gerClientes?.PesquisaCliente(idCliente02));
    }
}


































// using Xunit;
// using System;
// using System.Collections.Generic;

// public class GerenciadoraClientesTest_Ex7 {

// 	private GerenciadoraClientes? gerClientes;
// 	private int idCLiente01 = 1;
// 	private	int idCLiente02 = 2;
	
// 	[SetUp]
// 	public void SetUp() {
	
// 		/* ========== Montagem do cenário ========== */
		
// 		// criando alguns clientes
// 		Cliente cliente01 = new Cliente(idCLiente01, "Gustavo Farias", 31, "gugafarias@gmail.com", 1, true);
// 		Cliente cliente02 = new Cliente(idCLiente02, "Felipe Augusto", 34, "felipeaugusto@gmail.com", 1, true);
		
// 		// inserindo os clientes criados na lista de clientes do banco
// 		List<Cliente> clientesDoBanco = new List<Cliente>();
// 		clientesDoBanco.Add(cliente01);
// 		clientesDoBanco.Add(cliente02);
		
// 		gerClientes = new GerenciadoraClientes(clientesDoBanco);
	
// //		System.out.println("Before foi executado");
// 	}

// 	[TearDown]
// 	public void TearDown() {
// 		gerClientes.Limpa();
		
// //		System.out.println("After foi executado");
// 	}
	
// 	/**
// 	 * Teste básico da pesquisa de um cliente a partir do seu ID.
// 	 * 
// 	 * @author Gustavo Farias
// 	 * @date 21/01/2035
// 	 */
// 	[Fact]
// 	public void testPesquisaCliente() {

// 		/* ========== Execução ========== */
// 		Cliente? cliente = gerClientes.PesquisaCliente(idCLiente01);
		
// 		/* ========== Verificações ========== */
// 		Assert.Equal(cliente?.GetId(), idCLiente01);
		
// 	}
	
// 	/**
// 	 * Teste básico da remoção de um cliente a partir do seu ID.
// 	 * 
// 	 * @author Gustavo Farias
// 	 * @date 21/01/2035
// 	 */
// 	[Fact]
// 	public void testRemoveCliente() {
		
// 		/* ========== Execução ========== */
// 		bool clienteRemovido = gerClientes.RemoveCliente(idCLiente02);
		
// 		/* ========== Verificações ========== */
// 		Assert.Equal(clienteRemovido, true);
// 		Assert.Equal(gerClientes.GetClientesDoBanco().Count, 1);
// 		Assert.Null(gerClientes.PesquisaCliente(idCLiente02));
		
// 	}
	
// }
// // Como Ganhar Tempo e Otimizar Testes com Cenários Parecidos