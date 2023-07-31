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
    bool controle = true;
 
    while (controle)
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
            //Obs: Transformar tudo em método statico e que não retorna nada (void)
            case "1": 
                {

                    using FileStream fs = new FileStream(caminhoArquivo, FileMode.Create, FileAccess.Write);

                }
                break;

            case "2":
                {
                    
                    Console.WriteLine("\nEscreva abaixo o que deseja inserir no arquivo:\n");
                    string? texto = Console.ReadLine();
                    
                    using StreamWriter sw = new StreamWriter(caminhoArquivo, true);//true indica que o que será escrito vai para o final do arquivo sem substituir o que já está escrito
                    sw.WriteLine(texto);
                    
                }
                break;

            case "3":
                {
                    //Obs: verificar se o arquivo existe
                    Console.WriteLine("\nConteúdo do arquivo:\n");
                    using StreamReader sr = new StreamReader(caminhoArquivo);
                    
                    string? linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
                break;

            case "4":
                {
                    Console.WriteLine("\nDigite o termo que gostaria de localizar:");
                    string? termo = Console.ReadLine();
                    //obs: verfifica se o arquivo existe antes

                    using FileStream fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
                    fs.Seek(0, termo);
                    
                }
                break;

            case "5":
                controle = false;
                break;

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