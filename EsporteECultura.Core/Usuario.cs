namespace EsporteECultura.Core;

public class Usuario
{
    public Usuario(string nome, string contato, string id, string senhaUsuario)
    {
        Nome = nome;
        Contato = contato;
        Id = id;
        SenhaUsuario = senhaUsuario;
    }

    
    public string Contato { get; set; }
    public string Id { get; set; }
    public string SenhaUsuario { get; set; }
    public string Nome { get; set; }
    
}
