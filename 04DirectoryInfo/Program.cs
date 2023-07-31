Console.WriteLine("04 DirectoryInfo\n");

var caminhoDiretorio = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\04DirectoryInfo";

var dirOrigem = new DirectoryInfo(caminhoDiretorio); //cria a instância da classe para acessar os métodos

Console.WriteLine($"Nome do diretório: {dirOrigem.Name}");
Console.WriteLine($"Caminho completo do diretório: {dirOrigem.FullName}");
Console.WriteLine($"Data da criação: {dirOrigem.CreationTime}");
Console.WriteLine($"Último acesso: {dirOrigem.LastAccessTime}");
Console.WriteLine($"Último acesso UTC: {dirOrigem.LastAccessTimeUtc}");
Console.WriteLine($"Última modificação: {dirOrigem.LastWriteTime}");
Console.WriteLine($"Última modificação UTC: {dirOrigem.LastWriteTimeUtc}");
Console.WriteLine($"Atributos: {dirOrigem.Attributes}");

Console.WriteLine("\nCriando um novo diretório:");
var novoDiretorio = new DirectoryInfo(@"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\04DirectoryInfo\NovoDiretorio");

try
{
    if (!novoDiretorio.Exists)
    {
        novoDiretorio.Create();
        Console.WriteLine($"\n{novoDiretorio} criado com sucesso!!");
    }
    else
    {
        Console.WriteLine("\nDiretório já existe.");
    }
}
catch (Exception ex)
{

    Console.WriteLine($"ERRO: {ex.Message}");
}

Console.WriteLine("\nExcluindo diretório:");

try
{
    if (novoDiretorio.Exists)
    {
        novoDiretorio.Delete();
        Console.WriteLine($"\n{novoDiretorio} deletado com sucesso!!");
    }
    else
    {
        Console.WriteLine("\nDiretório não existe.");
    }
}
catch (Exception ex)
{

    Console.WriteLine($"ERRO: {ex.Message}");
}

Console.WriteLine($"\nExibindo os subdiretorios de {caminhoDiretorio}:\n");

try
{
    foreach (var subdir in dirOrigem.GetDirectories())
    {
        Console.WriteLine(subdir.Name);
    }
}
catch (Exception ex)
{

    Console.WriteLine($"ERRO: {ex.Message}");
}

Console.WriteLine($"\nExibindo os arquivos de {caminhoDiretorio}:\n");

try
{
    foreach (var arquivo in dirOrigem.GetFiles())
    {
        Console.WriteLine(arquivo.Name);
    }
}
catch (Exception ex)
{

    Console.WriteLine($"ERRO: {ex.Message}");
}

Console.WriteLine($"\nCriar um subdiretório em {caminhoDiretorio}");

try
{
    
    dirOrigem.CreateSubdirectory("NovoSubDiretorio");
    Console.WriteLine("\nSubdiretório criado com sucesso!");
}
catch (Exception ex)
{

    Console.WriteLine($"ERRO: {ex.Message}");
}

Console.ReadKey();