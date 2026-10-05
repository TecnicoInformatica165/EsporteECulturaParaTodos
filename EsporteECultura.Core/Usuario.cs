namespace EsporteECultura.Core;

public class Usuario
{
    public Usuario(string nome, string contato, string senhaUsuario)
    {
        Nome = nome;
        Contato = contato;
        SenhaUsuario = senhaUsuario;
    }


    public int Id { get; set; }
    public string Contato { get; set; }
    public string SenhaUsuario { get; set; }
    public string Nome { get; set; }
    
}