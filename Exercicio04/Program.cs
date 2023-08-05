using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Exercício 04\n");
/*Escreva um programa que leia o conteúdo de um arquivo de texto e o criptografe usando o algoritmo de
criptografia AES. Em seguida, salve o arquivo criptografado em um novo arquivo. O nome do arquivo de
origem e destino deve ser fornecido pelo usuário*/

try
{

    string caminhoOrigem = @"..\txt";

    Console.WriteLine("Digite o nome do arquivo de origem:");
    string arquivoOrigem = Console.ReadLine() + ".txt";
    string caminhoCompletoOrigem = Path.Combine(caminhoOrigem, arquivoOrigem);

    using StreamReader sr = new StreamReader(caminhoCompletoOrigem);
    Console.WriteLine("\nConteúdo do arquivo:");
    Console.WriteLine($"'{sr.ReadToEnd()}'\n");

    Console.WriteLine("Digite o nome do arquivo de cópia:");
    string arquivoDestino = Console.ReadLine() + ".txt";
    string caminhoCompletoDestino = Path.Combine(caminhoOrigem, arquivoDestino);

    string chave = "minhachave123456";
    // Lê o conteúdo do arquivo
    string conteudo = File.ReadAllText(caminhoCompletoOrigem);
    // Criptografa o conteúdo com o algoritmo AES
    byte[] conteudoCriptografado;
    using (Aes aes = Aes.Create())
    {
        aes.Key = Encoding.UTF8.GetBytes(chave);
        aes.Mode = CipherMode.CBC;
        ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        using (MemoryStream memoryStream = new MemoryStream())
        {
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor,
           CryptoStreamMode.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                {
                    streamWriter.Write(conteudo);
                }
                conteudoCriptografado = memoryStream.ToArray();
            }
        }
    }
    // Salva o conteúdo criptografado em um novo arquivo
    File.WriteAllBytes(caminhoCompletoDestino, conteudoCriptografado);
    Console.WriteLine("Arquivo criptografado com sucesso.");

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