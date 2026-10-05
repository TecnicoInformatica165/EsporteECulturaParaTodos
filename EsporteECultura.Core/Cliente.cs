namespace EsporteECultura.Core;

public class Cliente : Usuario 
{
    public Cliente(string nome, string contato, string senhaUsuario, Endereco endereco) : base(nome, contato, senhaUsuario)
    {
    }
    
    public Endereco Endereco { get; private set; }
}