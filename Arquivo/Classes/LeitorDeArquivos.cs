namespace Arquivo.Classes;

public static class LeitorDeArquivos
{


    // Devoluções:
    // 0 número total de bytes lidos do buffer. Isso poderá ser menor que o número de
    // bytes solicitado se esse número de bytes não estiver disponível no momento, ou
    //zero, se o final do fluxo for atingido
    public static void Read(byte[] arrayBuffer, int offset, int count)
    {
        // Implementação fictícia para ilustrar o método:

        //ArrayBuffer: Buffer onde os dados serão armazenados,
        //Offset: Posição inicial,
        //Count: Quantidade de bytes a serem lidos
    }

    public static void EscreverBuffer(byte[] buffer)
    {
        foreach (byte meuByte in buffer)
        {
            Console.Write(System.Text.Encoding.UTF8.GetString(buffer));
            Console.Write(" ");
        }
    }
}
