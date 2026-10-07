namespace EsporteECultura.Core;

public class Atividade
{
    private readonly List<string> _usuariosInscritos = new();
    
    public string Nome { get; private set; }
    public int TotalVagas { get; private set; }
    public int TotalDisponiveis { get; private set; }
    public IReadOnlyList<string> Usuarios => _usuariosInscritos;

    public Atividade(string nome, int totalVagas)
    {
        ValidarNome(nome);
        TotalVagas = totalVagas;
        
    }

    private void ValidarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new  ArgumentException("O nome da atividade é obrigatório", nameof(nome));
        
        
        
        Nome = nome;
        
    }

    private void ValidarVagas(int totalVagas)
    {
        if (totalVagas <= 0)
            throw new ArgumentOutOfRangeException(nameof(TotalVagas), "O total de vagas deve ser maior que zero");
        
        TotalVagas = totalVagas;
        
    }

    public bool InscreverUsuario(Usuario usuarioId)
    {
        if (string.IsNullOrWhiteSpace(usuarioId.Nome))
            throw new ArgumentException("O usuário é obrigatório", nameof(usuarioId));

        if (_usuariosInscritos.Contains(usuarioId.Nome))
            return false;
        
        if (VagasDisponiveis <= 0)
            return false;
        
        _usuariosInscritos.Add(usuarioId.Nome);
        return true;
    }

    public int VagasDisponiveis { get; set; }

    public bool CancelarInscricao(string usuarioId)
    {
        return _usuariosInscritos.Remove(usuarioId);
    }

    public bool UsuarioEstaInscrito(string usuarioId)
    {
        return _usuariosInscritos.Contains(usuarioId);
    }
    
}