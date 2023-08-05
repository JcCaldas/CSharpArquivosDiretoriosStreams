Console.WriteLine("Exercício 05\n");

/*Escreva um programa que leia o conteúdo de um arquivo de imagem e converta-o para um arquivo de texto
usando o algoritmo de codificação Base64. Em seguida, salve o arquivo de texto em um novo arquivo. O
nome do arquivo de origem e destino deve ser fornecido pelo usuário.*/

try
{

    string caminho = @"..\txt\";

    Console.WriteLine("Digite o nome do aquivo de imagem:");
    string arquivoOrigem = Console.ReadLine() + ".jpg";
    string caminhoOrigem = Path.Combine(caminho, arquivoOrigem);

    if (!File.Exists(caminhoOrigem))
        Console.WriteLine("\nArquivo não existe!");
    else
        Console.WriteLine("\nArquivo encontrado.");

    Console.WriteLine("\nDigite o nome do arquivo de destino:");
    string arquivoDestino = Console.ReadLine() + ".txt";
    string caminhoDestino = Path.Combine(caminho, arquivoDestino);
    File.Create(caminhoDestino).Close();

    // Lê o conteúdo do arquivo de imagem
    byte[] imageBytes = File.ReadAllBytes(caminhoOrigem);
    // Converte o conteúdo para Base64
    string base64String = Convert.ToBase64String(imageBytes);
    // Escreve o conteúdo em um novo arquivo de texto
    File.WriteAllText(caminhoDestino, base64String);
    Console.WriteLine("Arquivo de texto salvo com sucesso!");



}
catch (IOException ex)
{
    Console.WriteLine($"IO Erro: {ex.Message}");
}

catch (Exception ex)
{

    Console.WriteLine($"Erro: {ex.Message}");
}

finally
{
    Console.WriteLine("\nFim do processamento...");
}

Console.ReadKey();