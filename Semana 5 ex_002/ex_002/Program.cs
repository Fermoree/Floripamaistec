FileInfo arquivo = null;

try
{

    Console.Write("Digite o nome do arquivo que você irá criar:  ");
    string nomeArquivo = Console.ReadLine();

    arquivo = new FileInfo(nomeArquivo);

    using (StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
    {
        gravadorFluxo.WriteLine("Texto de dentro do arquivo");
    }
}

catch (Exception ex)
{
    Console.WriteLine($"Ocorreu o erro: {ex.Message}");
}

finally
{
    Console.WriteLine("Encerrando programa.");
    arquivo = null;
}