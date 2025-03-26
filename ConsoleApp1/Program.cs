class program
{
    public static void Main()
    {
        //tipo nomedavariavel


        //cria duas variaveis do tipo inteiro
        double numero1, numero2;

        //Escreve a informação na tela sem pular linha
      
        //Escreva a informação e depois pula 1 linha
        Console.WriteLine("Entre com o numero 1: ");

        //captura a informação do usuario
        string informacao = Console.ReadLine();

        //cole.readline() - le o que o usuario digitou
        //numero1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine(informacao);


        //converte o valor da variavel informação para inteiro e salva dentro da variavel numero1
        numero1 = Convert.ToDouble(informacao);

        Console.WriteLine("Entre com o numero 2: ");

        string informacao2 = Console.ReadLine();

        numero2 = Convert.ToDouble(informacao2);

        double soma = numero1 + numero2;
        double subtracao = numero1 - numero2;
        double div = (double)numero1 / numero2;
        double mult = numero1 * numero2;


        Console.WriteLine($"Soma: {soma}");


        Console.WriteLine("Subtração: {0}", subtracao);


        Console.WriteLine("Divisão: {0}", div);


        Console.WriteLine($"Multiplicação: {mult}");




    }

}
