class Program
{

    public static void Main()
    {
       /* 
        Console.WriteLine("Qual é sua idade");
        int idade = Convert.ToInt32(Console.ReadLine());
       */

        //Console.WriteLine("Comando 1");


        //if realiza operações que retorna verdadeiro ou falso
        //true - verdadeiro 
        //falso - falso

        /*
        if (idade >= 18 )
        {
            Console.WriteLine("É maior de idade/Verdadeiro");
        }
        else 
        { 
            Console.WriteLine("É menor de idade/Falso");
        }
        */

        //else if

        /*
        if (idade <= 14)
        {
            Console.WriteLine("Criança");
        }
        else if (idade < 18)
        {
            Console.WriteLine("Adolescente");
        }
        else if(idade < 30)
        {
            Console.WriteLine("Jovem adulto");
        }
        else if (idade < 60)
        {
            Console.WriteLine("adulto");
        }
        else if (idade <= 150)
        {
            Console.WriteLine("Idoso");
        }
        else if (idade > 150)
        {
            Console.WriteLine("Cadaver");
        }
        */

        Console.WriteLine("Dia da semana: ");
        string dia = Console.ReadLine();

        switch(dia)
        {
            case "segunda":
                Console.WriteLine("É segunda-feira");
                                break;

            case "terça":
                Console.WriteLine("É terça-feira");
                                break;

             case "quarta":
                Console.WriteLine("É quarta-feira");
                                break;

            case "quinta":
                Console.WriteLine("É quinta-feira");
                                break;

            case "sexta":
                Console.WriteLine("É sexta-feira");
                                break;

            case "sabado":
                Console.WriteLine("É sabado");
                                break;

            case "domingo":
                Console.WriteLine("É domingo");
                                break;

                default:
                Console.WriteLine("Bobão");
                break;

        }

    }
}