namespace WebApiIDependency
{
    public class Teste : ITeste
    {
        public string MeuTeste()
        {
            return "Teste de DI executado com sucesso!";
        }
    }
}