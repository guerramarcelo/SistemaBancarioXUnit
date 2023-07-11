public class GerenciadoraContasTest_Ex3 
{
	private GerenciadoraContas? gerContas;
	
	[Fact]
	public void testTransfereValor() 
	{
		/* ========== Montagem do cenário ========== */
		
		// criando alguns clientes
		ContaCorrente conta01 = new ContaCorrente(1, 200, true);
		ContaCorrente conta02 = new ContaCorrente(2, 0, true);
		
		// inserindo os clientes criados na lista de clientes do banco
		List<ContaCorrente> contasDoBanco = new List<ContaCorrente>();
		contasDoBanco.Add(conta01);
		contasDoBanco.Add(conta02);
		
		gerContas = new GerenciadoraContas(contasDoBanco);

		/* ========== Execução ========== */
		gerContas.TransfereValor(1, 100, 2);
		
		/* ========== Verificações ========== */
		Assert.Equal(conta02.GetSaldo(), 100.0);
		Assert.Equal(conta01.GetSaldo(), 100.0);
	}
}