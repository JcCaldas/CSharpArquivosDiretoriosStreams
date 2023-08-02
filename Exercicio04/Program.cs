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

    //Falta criptografar
    //lembrete, criptografar o caminhoCompletoDestino antes de copiar.

    File.Copy(caminhoCompletoOrigem, caminhoCompletoDestino);






}

catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}

catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

finally
{
    Console.WriteLine("\nFim do processamento...");
}



Console.ReadKey();