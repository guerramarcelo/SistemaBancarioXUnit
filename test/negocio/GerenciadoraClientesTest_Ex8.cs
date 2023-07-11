public class GerenciadoraClientesTest_Ex8 : IDisposable
{
    private GerenciadoraClientes? gerClientes;
    private int idCliente01 = 1;
    private int idCliente02 = 2;

    public GerenciadoraClientesTest_Ex8()
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
        Assert.Equal(cliente.GetId(), idCliente01);
    }

    /**
     * Teste básico da remoção de um cliente a partir do seu ID.
     */
    [Fact]
    public void TestRemoveCliente()
    {        
        /* ========== Execução ========== */      
        bool clienteRemovido = gerClientes.RemoveCliente(idCliente02);

        /* ========== Verificações ========== */
        Assert.True(clienteRemovido);
        Assert.Equal(1, gerClientes.GetClientesDoBanco().Count);
        Assert.Null(gerClientes?.PesquisaCliente(idCliente02));
    }
}
