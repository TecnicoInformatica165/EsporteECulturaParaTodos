namespace EsporteECultura.Core;

public class Endereco
{
    public Endereco(string logradouro, string cidade, string bairro, string UF, string CEP,
        string numero, string? complemento)
    {
        ValidarLogradouro(logradouro);
        ValidarCidade(cidade);
        ValidarBairro(bairro);
        ValidarUF(UF);
        ValidarCEP(CEP);
        Complemento = complemento;
        ValidarNumero(numero);
    }

    public string Logradouro { get; private set; }
    public string CEP { get; private set; }
    public string Numero { get; private set; }
    public string Complemento { get; private set; }
    public string Cidade { get; private set; }
    public string Bairro { get; private set; }
    public string UF { get; private set; }

    private void ValidarLogradouro(string logradouro)
    {
        if (string.IsNullOrWhiteSpace(logradouro))
            throw new EnderecoException("Lougradouro inválido!");


        Logradouro = logradouro;
    }

    private void ValidarCidade(string cidade)
    {
        if (string.IsNullOrWhiteSpace(cidade))
            throw new EnderecoException("Cidade não encontrada!");
        Cidade = cidade;
    }

    private void ValidarBairro(string bairro)
    {
        if (string.IsNullOrWhiteSpace(bairro))
            throw new EnderecoException("Bairro não encontrada!");

        Bairro = bairro;
    }

    private void ValidarUF(string UF)
    {
        if (string.IsNullOrWhiteSpace(UF))
            throw new EnderecoException("UF inválido!");

        UF = UF;
    }

    private void ValidarCEP(string CEP)
    {
        if (string.IsNullOrWhiteSpace(CEP))
            throw new EnderecoException("CEP não pode ser vazio!");

        CEP = CEP;
    }

    private void ValidarNumero(string numero)
    {
        if (string.IsNullOrWhiteSpace(numero))
            numero = "S/N";
    }
}