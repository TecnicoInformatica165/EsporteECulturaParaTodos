namespace EsporteECultura.Core;

public class Cliente : Usuario 
{
    public Cliente(string nome, string contato, string senhaUsuario, Endereco endereco, string documentos) : base(nome, contato, senhaUsuario)
    {
        
    }
    
    public Endereco Endereco { get; private set; }
}