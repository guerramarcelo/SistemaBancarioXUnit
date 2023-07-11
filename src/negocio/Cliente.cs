/**
 * Classe {@link Cliente} que representa um cliente real do banco.
 * @author Marcelo Guerra 
 */

public class Cliente 
{
	private int Id;
	private string Nome;	
	private int Idade;	
	private string Email;	
	private bool Ativo;	
	private int IdContaCorrente;
	public Cliente(int id, string nome, int idade, string email, int idContaCorrente, bool ativo)
    {
		Id = id;
		Nome = nome;
		Idade = idade;
		Email = email;
		IdContaCorrente = idContaCorrente;
		Ativo = ativo;
	}
        /**
	     * Método que retorna o Id do cliente. 
	     * @return Id do cliente
	    */
    public int GetId() 
    {
		return Id;
	}
        /**
	    * Método que atualiza o ID do cliente. 
	    */
    public void SetId(int id)
    {
		Id = id;
	}	
    	/**
	     * Método que retorna o nome do cliente. 
	     * @return nome do cliente
    	*/
	public string GetNome()
    {
		return Nome;
	}
	    /**
	     * Método que atualiza o nome do cliente. 
	    */	
    public void SetNome(string nome)
    {
		Nome = nome;
	}
	    /**
	     * Método que retorna a idade do cliente. 
	     * @return idade do cliente
	    */
	public int GetIdade()
    {
		return Idade;
	}
	    /**
	     * Método que atualiza a idade do cliente. 
	    */
	public void SetIdade(int idade)
    {
		Idade = idade;
	}	
	    /**
	     * Método que retorna o email do cliente. 
	     * @return email do cliente
	    */
	public string GetEmail() 
    {
		return Email;
	}
	    /**
	    * Método que atualiza o email do cliente. 
	    */	
    public void SetEmail(string email)
    {
		Email = email;
	}
	    /**
	     * Método que retorna o status (Ativo ou Inativo) do cliente. 
	     * @return status do cliente
	    */
	public bool IsAtivo()
    {
		return Ativo;
	}
	    /**
	     * Método que atualiza o status do cliente. 
	    */
	public void SetAtivo(bool ativo)
    {
		Ativo = ativo;
	}
	    /**
	     * Método que retorna o ID da conta corrente associada ao cliente. 
	     * @return ID da conta corrente associada ao cliente
	    */
	public int GetIdContaCorrente()
    {
		return IdContaCorrente;
	}
	    /**
	     * Método que atualiza o ID da conta corrente associada ao cliente. 
	    */       
	public void SetIdContaCorrente(int idContaCorrente)
    {
		IdContaCorrente = idContaCorrente;
	}	
	    /**
	     * Método que retorna a representação textual de um cliente. 
	     * @return representação textual de um cliente
	    */	
	public override string ToString()
    {		
		string str ="=========================" 
					+"Id: " + Id + "\n"
					+ "Nome: " + Nome + "\n"
					+ "Email: " + Email + "\n"
					+ "Idade: " + Idade + "\n"
					+ "Status: " + (Ativo?"Ativo":"Inativo") + "\n"
					+ "=========================";
		return str;
	}	
}
