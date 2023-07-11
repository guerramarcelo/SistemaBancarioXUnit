public class GerenciadoraContasTest_Ex11 
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
		int idConta01 = 1;
		int idConta02 = 2;
		ContaCorrente conta01 = new ContaCorrente(idConta01, 200, true);
		ContaCorrente conta02 = new ContaCorrente(idConta02, 0, true);
		
		// inserindo os clientes criados na lista de clientes do banco
		List<ContaCorrente> contasDoBanco = new List<ContaCorrente>();
		contasDoBanco.Add(conta01);
		contasDoBanco.Add(conta02);
		
		gerContas = new GerenciadoraContas(contasDoBanco);

		/* ========== Execução ========== */
		bool sucesso = gerContas.TransfereValor(idConta01, 100, idConta02);
		
		/* ========== Verificações ========== */
		Assert.True(sucesso);
		Assert.Equal(conta02.GetSaldo(), 100.0);
		Assert.Equal(conta01.GetSaldo(), 100.0);
	}
	
	/**
	 * Teste básico da tentativa de transferência de um valor da conta de um cliente para outro
	 * quando não há saldo suficiente, mas o saldo é positivo.
	 * 
	 * @author Marcelo Guerra
	 * @date 10/07/2023
	 */

	[Fact]
	public void testTransfereValor_SaldoInsuficiente() 
	{
		/* ========== Montagem do cenário ========== */
		
		// criando alguns clientes
		int idConta01 = 1;
		int idConta02 = 2;
		ContaCorrente conta01 = new ContaCorrente(idConta01, 100, true);
		ContaCorrente conta02 = new ContaCorrente(idConta02, 0, true);
		
		// inserindo os clientes criados na lista de clientes do banco
		List<ContaCorrente> contasDoBanco = new List<ContaCorrente>();
		contasDoBanco.Add(conta01);
		contasDoBanco.Add(conta02);
		
		gerContas = new GerenciadoraContas(contasDoBanco);

		/* ========== Execução ========== */
		bool sucesso = gerContas.TransfereValor(idConta01, 200, idConta02);
		
		/* ========== Verificações ========== */
		Assert.True(sucesso);
		Assert.Equal(conta01.GetSaldo(), -100.0);
		Assert.Equal(conta02.GetSaldo(), 200.0);
	}

	/**
	 * Teste básico da tentativa de transferência de um valor da conta de um cliente para outro
	 * quando não há saldo suficientee o saldo é negativo.
	 * 
	 * @author Marcelo Guerra
	 * @date 10/07/2023
	 */
	[Fact]
	public void testTransfereValor_SaldoNegativo()
	{
		/* ========== Montagem do cenário ========== */
		
		// criando alguns clientes
		int idConta01 = 1;
		int idConta02 = 2;
		ContaCorrente conta01 = new ContaCorrente(idConta01, -100, true);
		ContaCorrente conta02 = new ContaCorrente(idConta02, 0, true);
		
		// inserindo os clientes criados na lista de clientes do banco
		List<ContaCorrente> contasDoBanco = new List<ContaCorrente>();
		contasDoBanco.Add(conta01);
		contasDoBanco.Add(conta02);
		
		gerContas = new GerenciadoraContas(contasDoBanco);

		/* ========== Execução ========== */
		bool sucesso = gerContas.TransfereValor(idConta01, 200, idConta02);
		
		/* ========== Verificações ========== */
		Assert.True(sucesso);
		Assert.Equal(conta01.GetSaldo(),-300.0);
		Assert.Equal(conta02.GetSaldo(),200.0);
	}
	
	/**
	 * Teste básico da tentativa de transferência de um valor da conta de um cliente para outro
	 * quando o saldo do cliente origem é negativo e do cliente destino também é negativo.
	 * 
	 * @author Marcelo Guerra
	 * @date 10/07/2023
	 */
	[Fact]
	public void testTransfereValor_SaldoNegativoParaNegativo() 
	{
		/* ========== Montagem do cenário ========== */
		
		// criando alguns clientes
		int idConta01 = 1;
		int idConta02 = 2;
		ContaCorrente conta01 = new ContaCorrente(idConta01, -100, true);
		ContaCorrente conta02 = new ContaCorrente(idConta02, -100, true);
		
		// inserindo os clientes criados na lista de clientes do banco
		List<ContaCorrente> contasDoBanco = new List<ContaCorrente>();
		contasDoBanco.Add(conta01);
		contasDoBanco.Add(conta02);
		
		gerContas = new GerenciadoraContas(contasDoBanco);

		/* ========== Execução ========== */
		bool sucesso = gerContas.TransfereValor(idConta01, 200, idConta02);
		
		/* ========== Verificações ========== */
		Assert.True(sucesso);
		Assert.Equal(conta01.GetSaldo(), -300.0);
		Assert.Equal(conta02.GetSaldo(), 100.0);
	}
	
	/**
	 * Teste básico da tentativa de transferência de um valor nulo da conta de um cliente para outro.
	 * 
	 * @author Marcelo Guerra
	 * @date 10/07/2023
	 */
	[Fact]
	public void testTransfereValor_Nenhum() 
	{
		/* ========== Montagem do cenário ========== */
		
		// criando alguns clientes
		int idConta01 = 1;
		int idConta02 = 2;
		ContaCorrente conta01 = new ContaCorrente(idConta01, -100, true);
		ContaCorrente conta02 = new ContaCorrente(idConta02, -100, true);
		
		// inserindo os clientes criados na lista de clientes do banco
		List<ContaCorrente> contasDoBanco = new List<ContaCorrente>();
		contasDoBanco.Add(conta01);
		contasDoBanco.Add(conta02);
		
		gerContas = new GerenciadoraContas(contasDoBanco);

		/* ========== Execução ========== */
		bool sucesso = gerContas.TransfereValor(idConta01, 2, idConta02);
		
		/* ========== Verificações ========== */
		Assert.True(sucesso);
		Assert.Equal(conta01.GetSaldo(), -102.0);
		Assert.Equal(conta02.GetSaldo(), -98.0);
	}	
}
// Cálculos matemáticos e financeiros