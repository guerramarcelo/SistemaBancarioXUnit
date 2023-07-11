public class GerenciadoraClientesTest_Ex10 : IDisposable
{
    private GerenciadoraClientes? gerClientes;
    private int idCliente01 = 1;
    private int idCliente02 = 2;

    public GerenciadoraClientesTest_Ex10()
    {
        // Configuração inicial para todos os testes
    }

    public void Dispose()
    {
        // Limpeza após os testes
        gerClientes?.Limpa();
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
    }

    private void TearDown()
    {
        // Limpeza após os testes
        gerClientes?.Limpa();
    }

        /**
         * Teste básico da pesquisa de um cliente a partir do seu ID.
         */
    [Fact]
    public void TestPesquisaCliente()
    {
        // Configuração específica para este teste
        SetUp();

        /* ========== Execução ========== */
        Cliente? cliente = gerClientes?.PesquisaCliente(idCliente01);

        /* ========== Verificações ========== */
        Assert.Equal(cliente?.GetId(), idCliente01);

        // Limpeza específica após este teste
        TearDown();
    }

        /**
         * Teste básico da pesquisa por um cliente que não existe.
         */

    [Fact]
    public void TestPesquisaClienteInexistente()
    {
        // Configuração específica para este teste
        SetUp();

        /* ========== Execução ========== */
        Cliente? cliente = gerClientes?.PesquisaCliente(1001);

        /* ========== Verificações ========== */
        Assert.Null(cliente);

        // Limpeza específica após este teste
        TearDown();
    }

        /**
         * Teste básico da remoção de um cliente a partir do seu ID.
         */

    [Fact]
    public void TestRemoveCliente()
    {
        // Configuração específica para este teste
        SetUp();

        /* ========== Execução ========== */
        bool clienteRemovido = gerClientes?.RemoveCliente(idCliente02) ?? false;

        /* ========== Verificações ========== */
        Assert.True(clienteRemovido);
        Assert.Equal(1, gerClientes?.GetClientesDoBanco()?.Count ?? 0);
        Assert.Null(gerClientes?.PesquisaCliente(idCliente02));

        // Limpeza específica após este teste
        TearDown();
    }

        /**
         * Teste da tentativa de remoção de um cliente inexistente.
         */

    [Fact]
    public void TestRemoveClienteInexistente()
    {
        // Configuração específica para este teste
        SetUp();

        /* ========== Execução ========== */
        bool clienteRemovido = gerClientes?.RemoveCliente(1001) ?? false;

        /* ========== Verificações ========== */
        Assert.False(clienteRemovido);
        Assert.Equal(2, gerClientes?.GetClientesDoBanco()?.Count ?? 0);

        // Limpeza específica após este teste
        TearDown();
    }

        /**
         * Validação da idade de um cliente quando a mesma está no intervalo permitido.
         */

    [Fact]
    public void TestClienteIdadeAceitavel()
    {
        // Configuração específica para este teste
        SetUp();

        /* ========== Montagem do Cenário ========== */
        Cliente cliente = new Cliente(1, "Gustavo", 25, "guga@gmail.com", 1, true);

        /* ========== Execução ========== */
        bool idadeValida = gerClientes?.ValidaIdade(cliente.GetIdade()) ?? false;

        /* ========== Verificações ========== */
        Assert.True(idadeValida);

        // Limpeza específica após este teste
        TearDown();
    }

        /**
        * Validação da idade de um cliente quando a mesma está no intervalo permitido.
        */

    [Fact]
    public void TestClienteIdadeAceitavel_02()
    {
        // Configuração específica para este teste
        SetUp();

        /* ========== Montagem do Cenário ========== */
        Cliente cliente = new Cliente(1, "Gustavo", 18, "guga@gmail.com", 1, true);

        /* ========== Execução ========== */
        bool idadeValida = gerClientes?.ValidaIdade(cliente.GetIdade()) ?? false;

        /* ========== Verificações ========== */
        Assert.True(idadeValida);

        // Limpeza específica após este teste
        TearDown();
    }

    /**
     * Validação da idade de um cliente quando a mesma está no intervalo permitido.
     */
    [Fact]
    
    public void TestClienteIdadeAceitavel_03()
    {
        // Configuração específica para este teste
        SetUp();

        /* ========== Montagem do Cenário ========== */
        Cliente cliente = new Cliente(1, "Gustavo", 65, "guga@gmail.com", 1, true);

        /* ========== Execução ========== */
        bool idadeValida = gerClientes?.ValidaIdade(cliente.GetIdade()) ?? false;

        /* ========== Verificações ========== */
        Assert.True(idadeValida);

        // Limpeza específica após este teste
        TearDown();
    }

    /**
     * Validação da idade de um cliente quando a mesma está abaixo intervalo permitido.
     */

    [Fact]
    public void TestClienteIdadeAceitavel_04()
    {
        // Configuração específica para este teste
        SetUp();

        /* ========== Montagem do Cenário ========== */
        Cliente cliente = new Cliente(1, "Gustavo", 17, "guga@gmail.com", 1, true);

        /* ========== Execução ========== */
        try
        {
            gerClientes?.ValidaIdade(cliente.GetIdade());
            Assert.True(false, "Uma exceção deveria ser lançada.");
        }
        catch (IdadeNaoPermitidaException e)
        {
            /* ========== Verificações ========== */
            Assert.Equal(IdadeNaoPermitidaException.MSG_IDADE_INVALIDA, e.Message);
        }

        // Limpeza específica após este teste
        TearDown();
    }

     [Fact]
     public void TestClienteIdadeAceitavel_05()
     {
         /* ========== Montagem do Cenário ========== */
         Cliente cliente = new Cliente(1, "Gustavo", 66, "guga@gmail.com", 1, true);

         /* ========== Execução ========== */
         try
         {
             gerClientes?.ValidaIdade(cliente.GetIdade());
             Assert.True(false); // Se chegar aqui, o teste falhou
         }
         catch (Exception e)
         {
             /* ========== Verificações ========== */
             Assert.Equal( e.Message, IdadeNaoPermitidaException.MSG_IDADE_INVALIDA);       
         }
     }
}