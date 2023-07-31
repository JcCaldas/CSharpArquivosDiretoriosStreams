Console.WriteLine("02 FileInfo\n");

string caminhoOrigem = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\02FileInfo\arquivo\poesia.txt";
string caminhoDestino = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\02FileInfo\arquivo\txt\poesia.txt";
string caminhoCopia = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\02FileInfo\arquivo\poesia_copia.txt";

//Cria a instância da flasse FileIInfo para trabalhar com ele
FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);

//Obter informações
Console.WriteLine($"Nome do arquivo: {arquivoOrigem.Name}");
Console.WriteLine($"\nCaminho completo do arquivo: {arquivoOrigem.FullName}");
Console.WriteLine($"\nO arquivo é somente leitura (true/false): {arquivoOrigem.IsReadOnly}");

var diretorioPai = arquivoOrigem.Directory;
Console.WriteLine($"\nNome do diretório: {diretorioPai.Name}");
Console.WriteLine($"\nTamanho do aquivo: {arquivoOrigem.Length} bytes");
Console.WriteLine($"\nÚltima gravação: {arquivoOrigem.LastWriteTime}");

//verifica se o arquivo existe
if (arquivoOrigem.Exists)
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo existe. Copiando para {caminhoCopia}");
    arquivoOrigem.CopyTo(caminhoCopia);
}
else
{
    Console.WriteLine($"O {caminhoOrigem} arquivo não existe.");
}

Console.WriteLine($"\nMovendo {caminhoOrigem} para {caminhoDestino}");
arquivoOrigem.MoveTo(caminhoDestino);


Console.ReadKey();