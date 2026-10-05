namespace EsporteECultura.Core;

public class Colaborador : Usuario
{
    public Colaborador(string nome, string contato, string senhaUsuario, string CNPJ ) : base(nome, contato, senhaUsuario)
    {
        
    }
    
    public string CNPJ { get; private set; }
}