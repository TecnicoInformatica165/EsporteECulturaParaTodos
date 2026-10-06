namespace EsporteECultura.Core;

public class Admin : Usuario
{
    public Admin(string nome, string contato, string email, string senhaUsuario) : base(nome, contato, senhaUsuario)
    {
        ValidarEmail(email);
    }

    private void ValidarEmail(string email)
    {
        throw new NotImplementedException();
    }
}