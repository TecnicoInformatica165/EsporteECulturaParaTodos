using System.Text.RegularExpressions;

namespace EsporteECultura.Core;

public class Usuario
{
    public Usuario(string nome, string senhaUsuario, string emailUsuario)
    {
        ValidarNomeUsuario(nome);
        ValidarSenhaUsuario(senhaUsuario);
        ValidarEmailUsuario(emailUsuario);
    }

    public Usuario(string nome, string senhaUsuario, string email, string? contato) : this(nome, senhaUsuario, email)
    {
        ValidarContato(contato);
    }

    public const int MINIMO_TAMANHO_NOME = 3;
    public const int MINIMO_TAMANHO_SENHA = 8;

    public void ValidarEmailUsuario(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new UsuarioException($"O nome do usuário não pode ser nulo estar vazio!");

        if (Regex.IsMatch(email, "^[^@]+$", RegexOptions.IgnoreCase))
            throw new UsuarioException($"O nome de usuário nao tem letras o suficiente.");
        
   
    }

    public int Id { get; private set; }
    public string? Contato { get; private set; }
    public string SenhaUsuario { get; private set; }
    public string NomeUsuario { get; private set; }
    public string EmailUsuario { get; private set; }

    private void ValidarNomeUsuario(string nomeUsuario)
    {
        if (string.IsNullOrWhiteSpace(nomeUsuario))
            throw new UsuarioException($"O nome do usuário não pode ser nulo estar vazio!");

        if (Regex.IsMatch(nomeUsuario, @"^[A-Za-zÀ-ÿ]{3,}$", RegexOptions.IgnoreCase))
            throw new UsuarioException($"O nome de usuário nao tem letras o suficiente.");

        if (nomeUsuario.Length < MINIMO_TAMANHO_NOME)
            throw new UsuarioException($"O nome do usuário deve conter no mínimo {MINIMO_TAMANHO_NOME} CARATERES!");

    
    }

    

    private void ValidarSenhaUsuario(string senhaUsuario)
    {
        if (string.IsNullOrWhiteSpace(senhaUsuario))
            throw new UsuarioException($"A senha não está segura!");

        if (Regex.IsMatch(senhaUsuario, "^( ? !.*\\s)(?!.* [A - Z])(?!.*\\d)(?!.* [^A - Za - z0 - 9]).*$", RegexOptions
                .IgnoreCase))
            throw new UsuarioException($"A senha não está segura!");
        
        if (senhaUsuario.Length < MINIMO_TAMANHO_SENHA)
            throw new UsuarioException($"A senha deve ter no minímo{MINIMO_TAMANHO_SENHA} CARATERES!");
    }
}