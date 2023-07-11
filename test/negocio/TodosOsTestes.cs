// Classe de coleção de testes
public class TestCollection : ICollectionFixture<GerenciadoraClientesTest_Ex1>,
                               ICollectionFixture<GerenciadoraClientesTest_Ex2>,
                               ICollectionFixture<GerenciadoraClientesTest_Ex3>,
                               ICollectionFixture<GerenciadoraClientesTest_Ex4>,
                               ICollectionFixture<GerenciadoraClientesTest_Ex5>,
                               ICollectionFixture<GerenciadoraClientesTest_Ex7>,
                               ICollectionFixture<GerenciadoraClientesTest_Ex8>,
                               ICollectionFixture<GerenciadoraClientesTest_Ex10>,
                               ICollectionFixture<GerenciadoraContasTest_Ex3>,
                               ICollectionFixture<GerenciadoraContasTest_Ex4>,
                               ICollectionFixture<GerenciadoraContasTest_Ex6>,
                               ICollectionFixture<GerenciadoraContasTest_Ex11>
{
    // Nenhuma implementação necessária
}

// Classe de teste para todos os testes
[Collection("Test Collection")]
public class TodosOsTestes
{
    // Métodos de teste aqui
}
