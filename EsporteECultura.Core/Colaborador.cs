namespace EsporteECultura.Core;

public class Colaborador : Usuario
{
    public const int TAMANHO_PADRAO_CNPJ = 14;


    public Colaborador(string nome, string contato, string senhaUsuario, string cnpj) : base(nome, contato,
        senhaUsuario)
    {
        ValidarCNPJ(cnpj);
    }

    public string CNPJ { get; private set; }

    public static bool ValidarCNPJ(string cnpj)
    {
        if (string.IsNullOrWhiteSpace(cnpj))
            return false;

        cnpj = new string(cnpj.Where(char.IsDigit).ToArray());


        if (cnpj.Length != 14)
            return false;

        if (cnpj.All(c => c == cnpj[0]))
            return false;

        int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        var soma = 0;

        for (var i = 0; i < 12; i++)
            soma += (cnpj[i] - '0') * peso1[i];

        var resto = soma % 11;
        var digito1 = resto < 2 ? 0 : 11 - resto;

        if (digito1 != cnpj[12] - '0')
            return false;

        soma = 0;

        for (var i = 0; i < 13; i++)
            soma += (cnpj[i] - '0') * peso2[i];

        resto = soma % 11;
        var digito2 = resto < 2 ? 0 : 11 - resto;

        return digito2 == cnpj[13] - '0';
    }
}