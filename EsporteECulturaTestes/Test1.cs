namespace EsporteECulturaTestes;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void CriarUsuario_QuandoTodasInformacoesCorretas_RetornaObjeto()
    {
        const string nomeEsperado = "Manoella Silva";
        const string emailEsperado = "manu5@gmail.com";
        const string senhaEsperado = "manu123#";
        const string contatoEsperado = "27990763467";

        var usuarioCriado = new Usuario(nomeEsperado, emailEsperado, senhaEsperado, contatoEsperado);

        Assert.IsNotNull(usuarioCriado);
        Assert.AreEqual(nomeEsperado, usuarioCriado.Nome);
        Assert.AreEqual(emailEsperado, usuarioCriado.Email);
        Assert.AreEqual(contatoEsperado, usuarioCriado.Contato);
    }

    [TestMethod]
    public void CriarUsuario_QuandoNomeNulo_retornaException()
    {
        const string nomeEsperado = null!;
        const string emailEsperado = "manu5@gmail.com";
        const string senha = "manu123#";
        const string contatoEsperado = "27990763467";


        var exception = Assert.Throws<UsuarioException>(() =>
        {
            new Usuario(nomeEsperado!, contatoEsperado, emailEsperado, senha);
        });

        Assert.Contains("O nome de usuário não pode ser vazio!", exception.Message);
    }
        
}