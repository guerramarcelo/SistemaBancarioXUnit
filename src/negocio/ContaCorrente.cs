/**
 * Classe {@link ContaCorrente} que representa uma conta corrente real
 * e que poderá ser associada a um cliente.
 * @author Marcelo Guerra
 */
public class ContaCorrente 
{
	private int Id;	
	private double Saldo;	
	private bool Ativa;
	public ContaCorrente(int id, double saldo, bool ativa)
    {
		Id = id;
		Saldo = saldo;
		Ativa = ativa;
	}
	    /**
	     * Método que retorna o ID da conta corrente. 
	     * @return ID da conta corrente
	    */
	public int GetId()
    {
		return Id;
	}
	    /**
	     * Método que atualiza o ID da conta corrente. 
	    */
	public void SetId(int id) 
    {
		Id = id;
	}
	    /**
	     * Método que retorna o saldo da conta corrente. 
	     * @return saldo da conta corrente
	    */
	public double GetSaldo()
    {
		return Saldo;
	}
	    /**
	     * Método que atualiza o saldo da conta corrente. 
	    */
	public void SetSaldo(double saldo)
    {
		Saldo = saldo;
	}
	    /**
	     * Método que retorna o status da conta corrente, podendo ser Ativa ou Inativa. 
	     * @return status da conta corrente
	    */
	public bool IsAtiva() 
    {
		return Ativa;
	}
	    /**
	     * Método que atualiza o status da conta corrente. 
	    */
	public void SetAtiva(bool ativa)
    {
		Ativa = ativa;
	}	
	    /**
	     * Método que retorna a representação textual de uma conta corrente. 
	     * @return representação textual da conta corrente
	    */	
	public override string ToString() 
	{		
		string str = "========================="
					+ "Id: " + Id + "\n"
					+ "Saldo: " + Saldo + "\n"
					+ "Status: " + (Ativa?"Ativa":"Inativa") + "\n"
					+ "=========================";
		return str;
	}	
}	