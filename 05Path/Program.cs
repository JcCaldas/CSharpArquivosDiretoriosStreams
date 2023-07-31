Console.WriteLine("05 Path\n");

Console.WriteLine("Directory Separator Char\n");
var caminho = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\05Path\txt\texto.txt";

char dirSeparador = Path.DirectorySeparatorChar;
Console.WriteLine($"O separar de diretório padrão é: {dirSeparador}");

string[] diretorios = caminho.Split(dirSeparador);

Console.WriteLine("\nOs diretórios e arquivo no caminho são:\n");

foreach (var  diretorio in diretorios)
{
    Console.WriteLine(diretorio);
}

Console.WriteLine("\nMétodo Combine");

string path1 = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti"; //caminho absoluto
string path2 = @"ArquivosDiretoriosStreams\05Path\txt\texto.txt"; //caminho relativo
string pathCombinado = Path.Combine(path1, path2); //só combina do absoluto para o relativo. Se inverter ele apresenta somente o absoluto
Console.WriteLine($"\nCaminho Combinado: {pathCombinado}");

Console.WriteLine($"\nNome do diretório: {Path.GetDirectoryName(pathCombinado)}");
Console.WriteLine($"\nExtensão do arquivo: {Path.GetExtension(pathCombinado)}");
Console.WriteLine($"\nNome do arquivo: {Path.GetFileName(pathCombinado)}");
Console.WriteLine($"\nNome do arquivo sem extensão: {Path.GetFileNameWithoutExtension(pathCombinado)}");
Console.WriteLine($"\nPossui Extensão?: {Path.HasExtension(pathCombinado)}");
Console.WriteLine($"\nContém a raiz?: {Path.IsPathRooted(pathCombinado)}");
Console.WriteLine($"\nNova extensão do arquivo: {Path.ChangeExtension(pathCombinado, ".docx")}");
Console.WriteLine($"\nRaiz: {Path.GetPathRoot(pathCombinado)}");
//
Console.WriteLine($"\nNome de arquivo aleatório: {Path.GetRandomFileName()}");
Console.WriteLine($"\nNome de arquivo temporário: {Path.GetTempFileName()}");
Console.WriteLine($"\nCaminho Temporário: {Path.GetTempPath()}");

char[] caracteresInvalidosEmArquivo = Path.GetInvalidFileNameChars();
Console.WriteLine($"\nCaracteres inválidos em nome de arquivo: {new string(caracteresInvalidosEmArquivo)}");//cria uma string do array de caracteres
Console.ReadKey();