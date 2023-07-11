/**
 * Classe de teste criada para garantir o funcionamento das principais operações
 * sobre contas, realizadas pela classe {@link GerenciadoraContas}.
 * 
 * @author Marcelo Guerra
 * @date 10/07/2023 
 */
public class GerenciadoraContasTest_Ex4 
{
	private GerenciadoraContas? gerContas;
	
	/**
	 * Teste básico da transferência de um valor da conta de um cliente para outro,
	 * estando ambos os clientes ativos e havendo saldo suficiente para tal transferência
	 * ocorrer com sucesso.	 
	 * @author Marcelo Guerra
	 * @date 10/07/2023
	 */

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
		bool sucesso = gerContas.TransfereValor(1, 100, 2);
		
		/* ========== Verificações ========== */
		Assert.True(sucesso);
		Assert.Equal(conta02.GetSaldo(), 100.0);
	}
}

// Documentação e comentários