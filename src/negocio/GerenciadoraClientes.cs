/**
 * Classe de negócio para realizar operações sobre os clientes do banco.
 * @author Marcelo Guerra 
 */
public class GerenciadoraClientes
{
	private List<Cliente> ClientesDoBanco;
	public GerenciadoraClientes(List<Cliente> clientesDoBanco)
	{
		ClientesDoBanco = clientesDoBanco;
	}	
		/**
		 * Retorna uma lista com todos os clientes do banco.
		 * @return lista com todos os clientes do banco
		*/
	public List<Cliente> GetClientesDoBanco() 
	{
		return ClientesDoBanco;
	}	
		/**
		 * Pesquisa por um cliente a partir do seu ID.
		 * @param idCliente id do cliente a ser pesquisado
		 * @return o cliente pesquisado ou null, caso não seja encontrado
		*/
	public Cliente? PesquisaCliente (int idCliente)
	{
		foreach (Cliente cliente in ClientesDoBanco)
		{
			if(cliente.GetId() == idCliente)
			{
				return cliente;
			}			
		}
		return null;
	}	
		/**
		 * Adiciona um novo cliente à lista de clientes do banco.
		 * @param novoCliente novo cliente a ser adicionado
		*/
	public void AdicionaCliente (Cliente novoCliente)
	{
		ClientesDoBanco.Add(novoCliente);
	}
		/**
		 * Remove cliente da lista de clientes do banco.
		 * @param idCliente ID do cliente a ser removido 
		 * @return true se o cliente foi removido. False, caso contrário.
		*/
	public bool RemoveCliente (int idCliente) 
	{
		bool clienteRemovido = false;
		foreach (Cliente cliente in ClientesDoBanco.ToList())
		{
			if (cliente.GetId() == idCliente)
			{
				ClientesDoBanco.Remove(cliente);
				clienteRemovido = true;
			}			
		}
		return clienteRemovido;
	}
		/**
		 * Informa se um determinado cliente está ativo ou não.
		 * @param idCliente ID do cliente cujo status será verificado
		 * @return true se o cliente está ativo. False, caso contrário. 
		*/
	public bool ClienteAtivo (int idCliente) 
	{
		bool clienteAtivo = false;
		foreach(Cliente cliente in ClientesDoBanco.ToList())
		{
			if (cliente.GetId() == idCliente)
			{
				if (cliente.IsAtivo())
				{
					clienteAtivo = true;	
				}
			}	
		}
		return clienteAtivo;
	}
		/**
		 * Limpa a lista de clientes, ou seja, remove todos eles. 
		*/
	public void Limpa()
	{
		ClientesDoBanco.Clear();
	}	
		/**
		 * Valida se a idade do cliente está dentro do intervalo permitido (18 - 65).
		 * @param idade a idade do possível novo cliente
		*/	
	public bool ValidaIdade(int idade) 
	{
	
		if(idade < 18 || idade > 65)
		{
			throw new IdadeNaoPermitidaException(IdadeNaoPermitidaException.MSG_IDADE_INVALIDA);
		}		
		return true;
	}
}