using Arquivo.Classes;

string enderecoDoArquivo = "contas.txt";
int numeroDeBytesLidos = -1;
FileStream fluxoDoArquivo = new(enderecoDoArquivo, FileMode.Open);

//1024 bytes = 1 KB
byte[] buffer = new byte[1024];

while(numeroDeBytesLidos != 0)
{
    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
    LeitorDeArquivos.EscreverBuffer(buffer);
}






