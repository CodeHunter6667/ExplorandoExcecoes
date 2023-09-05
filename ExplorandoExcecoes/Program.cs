
try
{
    string[] linha = File.ReadAllLines("D:\\Projetos Programacao\\Projetos C Sharp\\Projetos Dio\\ExcecoesEColecoes\\ExplorandoExcecoes\\NovaPasta\\Arquivo_Leitura.txt");

    foreach (string linhas in linha)
    {
        Console.WriteLine(linhas);

    }
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma excecao generica {ex.Message}");
}