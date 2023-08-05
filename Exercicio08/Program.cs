Console.WriteLine("Exercício 08\n");

/*Criar um programa que permita ao usuário criar um novo diretório e, em seguida, criar um arquivo dentro
desse diretório usando a classe Directory e a classe Path.*/

string caminho = @"C:\Temp";

Console.WriteLine("Insira o nome do novo diretório:");
string nomeDiretorio = Console.ReadLine();
string caminhoCompleto = Path.Combine(caminho, nomeDiretorio);

Directory.CreateDirectory(caminhoCompleto);

Console.WriteLine("Insira o nome do arquivo que deseja criar:");
string nomeArquivo = Console.ReadLine();

Console.WriteLine("Insira a extenção do arquivo sem o ponto:");
string extensaoArquivo = "." + Console.ReadLine();

string arquivoCompleto = nomeArquivo + extensaoArquivo;

string caminhoArquivo = Path.Combine(caminhoCompleto, arquivoCompleto);

File.Create(caminhoArquivo).Close();

Console.ReadKey();