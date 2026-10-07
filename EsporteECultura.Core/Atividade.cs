namespace EsporteECultura.Core;

public class Atividade
{
    protected Atividade()
    {
    }

    public Atividade(string nome, int totalVagas, Admin admin, Colaborador colaborador)
    {
        ValidarNome(nome);
        ValidarTotalVagas(totalVagas);
        Admin = admin;
        Colaborador = colaborador;
    }

    public string Nome { get; private set; }
    public int TotalVagas { get; private set; }
    public int TotalDisponiveis { get; private set; }
    public Admin Admin { get; private set; }
    public Colaborador Colaborador { get; private set; }

    private void ValidarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome da atividade é obrigatório", nameof(nome));

        Nome = nome;
    }

    private void ValidarTotalVagas(int totalVagas)
    {
        if (totalVagas <= 0)
            throw new ArgumentOutOfRangeException(nameof(TotalVagas), "O total de vagas deve ser maior que zero");

        TotalVagas = totalVagas;
    }
}