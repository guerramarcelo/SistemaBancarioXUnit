/**
 * Exceção a ser lançada quando a idade de um possível novo cliente não for aceita. 
 * @author Marcelo Guerra 
 */
public class IdadeNaoPermitidaException : Exception
{
    public static string MSG_IDADE_INVALIDA = "A idade do cliente precisa estar entre 18 e 65 anos.";
    public IdadeNaoPermitidaException(string msg) : base(msg)
    {
    }
}
