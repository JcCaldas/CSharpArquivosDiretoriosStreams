Console.WriteLine("Exercício 01 - Streams\n");
/*Crie um programa que ofereça um menu de opções para manipulação de um arquivo texto
 utilizando as classes FileStream, StreamReader e StreamWriter.

 As opções do menu devem ser:
1 - Criar aquivo: permite criar um novo arquivo texto, caso ele não exista, ou
sobrescrever um arquivo existente.

 2 - Gravar no arquivo: permite adicionar conteúdo ao arquivo. O usuário deve poder
digitar o conteúdo que deseja adicionar ao arquivo.

 3 - Ler arquivo: exibe o conteúdo completo do arquivo na tela.

 4 - Procurar no arquivo: permite procurar um texto no arquivo e exibir a posição da
primeira ocorrência na tela. O usuário deve poder digitar o texto a ser procurado.

 Dado: \txt\exercicio.txt
Nota: Deve-se realizar o tratamento de exceções usando bloco try/catch
*/

try
{
    string caminhoArquivo = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\Exercicio01Streams\txt\exercicio.txt";
 
    while (true)
    {

        Console.WriteLine("\n-----------------------\n" +
            "\tMENU:\n" +
            "-----------------------\n" +
            "\n1 - Criar arquivo\n" +
            "2 - Adicionar conteúdo\n" +
            "3 - Exibir arquivo\n" +
            "4 - Procurar no arquivo\n" +
            "5 - Sair\n");

        Console.Write("Digite a opção desejada: ");
        string? opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1": 
                CriarArquivo(caminhoArquivo);
                break;

            case "2":
                    
                AdicionarConteudo(caminhoArquivo);
                break;

            case "3":
                
                ExibirArquivo(caminhoArquivo);
                break;

            case "4":
         
                ProcurarNoArquivo(caminhoArquivo);
                break;

            case "5":
                return;

            default:
                Console.WriteLine("\nOPÇÃO INVÁLIDA!\n");
                break;
        }
    }

    

}

catch (IOException ex)
{

    Console.WriteLine($"IOException Erro: { ex.Message}");

}

catch (Exception ex)
{

    Console.WriteLine($"Exception Erro: {ex.Message}");

}

finally

{

    Console.WriteLine("\nFIM DO PROCESSAMENTO...");

}

Console.WriteLine("\nPressione qualquer tecla para continuar...");


Console.ReadKey();

static void CriarArquivo(string caminho)
{
    try
    {
        
        using FileStream fs = new FileStream(caminho, FileMode.Create, FileAccess.Write);

    }
    catch (IOException ex)
    {

        Console.WriteLine($"IOException Erro: {ex.Message}");

    }

    catch (Exception ex)
    {

        Console.WriteLine($"Exception Erro: {ex.Message}");

    }
}

static void AdicionarConteudo(string caminho)
{
    try
    {

        Console.WriteLine("\nEscreva abaixo o que deseja inserir no arquivo:");
        string? texto = Console.ReadLine();

        using StreamWriter sw = new StreamWriter(caminho, true);//true indica que o que será escrito vai para o final do arquivo sem substituir o que já está escrito
        sw.WriteLine(texto);

    }
    catch (IOException ex)
    {

        Console.WriteLine($"IOException Erro: {ex.Message}");

    }

    catch (Exception ex)
    {

        Console.WriteLine($"Exception Erro: {ex.Message}");

    }
}

static void ExibirArquivo(string caminho)
{
    try
    {

        if (!File.Exists(caminho))
        {
            Console.WriteLine("O arquivo ainda não foi criado.");
        }
        else
        {

            Console.WriteLine("\nConteúdo do arquivo:\n");
            using StreamReader sr = new StreamReader(caminho);

            string? linha;
            while ((linha = sr.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }

        }

    }
    catch (IOException ex)
    {

        Console.WriteLine($"IOException Erro: {ex.Message}");

    }

    catch (Exception ex)
    {

        Console.WriteLine($"Exception Erro: {ex.Message}");

    }
}

static void ProcurarNoArquivo(string caminho)
{
    try
    {

        Console.WriteLine("\nDigite o termo que gostaria de localizar:");
        string? termo = Console.ReadLine();
        if (!File.Exists(caminho))
        {
            Console.WriteLine("O arquivo ainda não foi criado.");
        }
        else
        {
            bool encontrado = false;
            using StreamReader sr = new StreamReader(caminho);
            string? linha;
            int numLinha = 0;
            while ((linha = sr.ReadLine()) != null)
            {
                numLinha++;
                if ((linha.Contains(termo)))
                {
                    Console.WriteLine($"\nTexto encontrado na linha {numLinha}: {linha}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"\nTermo \"{termo}\" não encontrado!");
            }

        }

    }
    catch (IOException ex)
    {

        Console.WriteLine($"IOException Erro: {ex.Message}");

    }

    catch (Exception ex)
    {

        Console.WriteLine($"Exception Erro: {ex.Message}");

    }
}