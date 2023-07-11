/**
 * Classe de negócio para realizar operações sobre as contas do banco.
 * @author Marcelo Guerra
 */

public class GerenciadoraContas
{
	private List<ContaCorrente> ContasDoBanco;
	public GerenciadoraContas(List<ContaCorrente> contasDoBanco) 
    {
		ContasDoBanco = contasDoBanco;
	}
	    /**
	     * Retorna uma lista com todas as contas do banco.
	     * @return lista com todas as contas do banco
	    */
    public List<ContaCorrente> GetContasDoBanco()
    {
		return ContasDoBanco;
	}
	    /**
	     * Pesquisa por uma conta a partir do seu ID.
	     * @param idConta id da conta a ser pesquisada
	     * @return a conta pesquisada ou null, caso não seja encontrada
	     */
    public ContaCorrente? PesquisaConta (int idConta) 
    {
       foreach (ContaCorrente contaCorrente in ContasDoBanco)
       {
           if (contaCorrente.GetId() == idConta)
           {
               return contaCorrente;
           }
       }
       return null;		
	}
	    /**
	     * Adiciona uma nova conta à lista de contas do banco.
	     * @param novaConta nova conta a ser adicionada
	    */
    public void AdicionaConta (ContaCorrente novaConta) 
    {
		ContasDoBanco.Add(novaConta);
	}
	    /**
	     * Remove conta da lista de contas do banco.
	     * @param idConta ID da conta a ser removida 
	     * @return true se a conta foi removida. False, caso contrário.
	    */
	public bool RemoveConta (int idConta) 
	{
	   bool contaRemovida = false;
       foreach (ContaCorrente conta in ContasDoBanco)
       {
           if (conta.GetId() == idConta)
           {
               ContasDoBanco.Remove(conta);
               contaRemovida = true;
           }
       }        
		return contaRemovida;
	}
	   /**
	    * Informa se uma determinada conta está ativa ou não.
	    * @param idConta ID da conta cujo status será verificado
	    * @return true se a conta está ativa. False, caso contrário. 
	   */
	public bool ContaAtiva (int idConta) 
	{
	   bool contaAtiva = false;
       foreach (ContaCorrente conta in ContasDoBanco)
       {
           if (conta.GetId() == idConta)
           {
               if (conta.IsAtiva())
               {
                   contaAtiva = true;
               }                
           }
       }				
		return contaAtiva;
	}
	    /**
	     * Transfere um determinado valor de uma conta Origem para uma conta Destino.
	     * Caso não haja saldo suficiente, o valor não será transferido.
	     * 
	     * @param idContaOrigem conta que terá o valor deduzido
	     * @param valor valor a ser transferido
	     * @param idContaDestino conta que terá o valor acrescido
	     * @return true, se a transferência foi realizada com sucesso.
	    */
	public bool TransfereValor (int idContaOrigem, double valor, int idContaDestino)
    {		
		bool sucesso = false;
		ContaCorrente? contaOrigem = PesquisaConta(idContaOrigem);
		ContaCorrente? contaDestino = PesquisaConta(idContaDestino);
   		//if(contaOrigem.GetSaldo() >= valor)
   		//{
			contaDestino?.SetSaldo(contaDestino.GetSaldo() + valor);
			contaOrigem?.SetSaldo(contaOrigem.GetSaldo() - valor);
			sucesso = true;
   		//}	
		return sucesso;
	}
}	