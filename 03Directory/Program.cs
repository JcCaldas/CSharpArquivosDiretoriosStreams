Console.WriteLine("03 Directory\n");

var caminhoDiretorio = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\03Directory\MeuDiretorio";
var caminhoDiretorio2 = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\03Directory\MeuDiretorio\teste";
Directory.CreateDirectory(caminhoDiretorio2);//criando apenas para excluir
var caminhoDiretorio3 = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\03Directory";
string caminhoArquivos = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\02FileInfo\arquivo";
var caminhoDiretorio4 = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\03Directory\MeuDiretorioNovo";



Console.WriteLine("\nCriando um novo diretório");
//Importante sempre tratar os erros e verificar se o diretório existe
try
{
    if (!Directory.Exists(caminhoDiretorio))
    {
        Directory.CreateDirectory(caminhoDiretorio);

        Console.WriteLine($"Diretório {caminhoDiretorio} criado com sucesso!");
    }
    else
    {
        Console.WriteLine($"O diretório {caminhoDiretorio} já existe!");
    }
}
catch (Exception ex)
{

    Console.WriteLine($"ERRO: {ex.Message}");
    Console.WriteLine($"ERRO: {ex.StackTrace}");
}

Console.WriteLine("\nExcluindo um diretório:");

try
{
    if (Directory.Exists(caminhoDiretorio2))
    {
        Directory.Delete(caminhoDiretorio2);//Se colocar 'true' após o diretório indicado, ele exclui todos os diretórios e subdiretórios
        Console.WriteLine($"O diretório {caminhoDiretorio2} foi excluido!");
    }
    else
    {
        Console.WriteLine($"O diretório {caminhoDiretorio2} não existe!");
    }
}
catch (Exception ex)
{

    Console.WriteLine($"ERRO: {ex.Message}");
    Console.WriteLine($"ERRO: {ex.StackTrace}");
}


Console.WriteLine("\nObtendo os subdiretórios de um diretório:");

try
{
    if (Directory.Exists(caminhoDiretorio3))
    {
        string[] subdiretorios = Directory.GetDirectories(caminhoDiretorio3);
        //Pode-se colocar um padrão de busca. Ex: Directory.GetDirectories(@"c:\","p*"); Vai exibir todos os subdiretórios do "c:", começados com a letra "p" e que contenham qualquer outro caracter após.
        foreach (var subdir in subdiretorios)
        {
            Console.WriteLine(subdir);
        }
    }
    else
    {
        Console.WriteLine($"O diretórios {caminhoDiretorio3} não existe!");
    }
}
catch (Exception ex)
{

    Console.WriteLine($"ERRO: {ex.Message}");
    Console.WriteLine($"ERRO: {ex.StackTrace}");
}

Console.WriteLine("\nObtendo todos os arquivos de um diretório:");

try
{
    if (Directory.Exists(caminhoArquivos))
    {
        string[] arquivos = Directory.GetFiles(caminhoArquivos);
        //pode-se utilizar um critério de busca.
        foreach (var arquivo in arquivos)
        {
            Console.WriteLine(arquivo);
        }
    }
    else
    {
        Console.WriteLine($"O diretório {caminhoArquivos} não existe!");
    }
}
catch (Exception ex)
{

    Console.WriteLine($"ERRO: {ex.Message}");
    Console.WriteLine($"ERRO: {ex.StackTrace}");
}

Console.WriteLine("\nMovendo e renomeando um diretório:");
//Move o diretório e todos os arquivos.
try
{
    if (!Directory.Exists(caminhoDiretorio4))
    {
        Directory.Move(caminhoDiretorio,caminhoDiretorio4);

        Console.WriteLine($"Diretório {caminhoDiretorio4} foi movido com sucesso!");
    }
    else
    {
        Console.WriteLine($"O diretório {caminhoDiretorio} já existe!");
    }
}
catch (Exception ex)
{

    Console.WriteLine($"ERRO: {ex.Message}");
    Console.WriteLine($"ERRO: {ex.StackTrace}");
}


Console.ReadKey();