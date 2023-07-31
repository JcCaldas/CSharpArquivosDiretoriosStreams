Console.WriteLine("01 File\n");

/*Cria uma variavel com o caminho de origem do arquivo. Isso facilita pois
 não precisa ficar escrevendo o caminho toda vez que precisar.
Obs: '@' antes do caminho, torna a string literal.*/

string caminhoOrigem = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\01File\arquivo\txt\arquivo01.txt";
string caminhoDestino = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\01File\arquivo\arquivo01_copia.txt";

/*Importante ao manipular arquivos, sempre verificar se eles existem e tratar*/

//Criar arquivo
var arquivo = File.Create(caminhoOrigem);

//Fechar arquivo

arquivo.Close();//Importante sempre fechar após criar.


if (!File.Exists(caminhoDestino))// Se não existir esse arquivo faça...
{

    try
    {


        /*Escrever no arquivo:
         Caso o arquivo esteja aberto dará uma exceção.
        Caso o arquivo não esteja criado, será criado com a string escrita.*/
        File.WriteAllText(caminhoOrigem, "Fernando Pessoa \r\n"); // \r\n -> nova linha, somente no windows.

        string novoTexto = "O poeta é um fingidor" +
                            Environment.NewLine + // cria nova linha em todos os SO (similar a \r\n).
                            "Finge tão completamente\r\n" +
                            "Que chega a fingir que é dor\r\n" +
                            "A dor que deveras sente.\r\n";

        //Adiciona algo ao arquivo
        File.AppendAllText(caminhoOrigem, novoTexto);

        //Lê o conteúdo do arquivo
        Console.WriteLine("Conteúdo e informações do arquivo:\n");
        string conteudo = File.ReadAllText(caminhoOrigem);
        Console.WriteLine(conteudo);

        //Variação de leitura do conteúdo do arquivo
        Console.WriteLine();
        string[] linhas = File.ReadAllLines(caminhoOrigem); //cria um array com as linhas do arquivo como cada elemento
        foreach (var linha in linhas)
        {
            Console.WriteLine(linha);
        }
        Console.WriteLine();

        //Obter última modificação
        Console.WriteLine($"Última modificação feita em: {File.GetLastWriteTime(caminhoOrigem)}");

        //Obter último acesso
        Console.WriteLine($"Último acesso feito em: {File.GetLastAccessTime(caminhoOrigem)}");

        //Copiar aquivos
        var caminhoCopia = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\01File\arquivo\txt\arquivo01_copia.txt";
        Console.WriteLine($"\nCopiando de: {caminhoOrigem}\npara: {caminhoCopia}");
        File.Copy(caminhoOrigem, caminhoCopia);
        /*Se o arquivo no caminh de copia já existe ele não sobrescreve.
         Para sobrescrever deve-se inserir 'true' após o indicação do caminho da cópia. ex:
        File.Copy(caminhoOrigem, caminhoCopia, true);
        */

        //Mover arquivo. Caso o nome do arquivo no caminho de destino não seja o mesmo da origem, ocorre a renomeação
        Console.WriteLine($"\nMovendo cópia de: {caminhoOrigem}\npara: {caminhoDestino}");
        File.Move(caminhoCopia, caminhoDestino);

        //Excluindo arquivo
        Console.WriteLine($"\nExcluindo {caminhoOrigem}");
        File.Delete(caminhoOrigem);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nErro: {ex.Message}");
    }
}
else
{
    Console.WriteLine("Concluido!");
}

Console.WriteLine("Pressione alguma tecla para finalizar...");
Console.ReadKey();