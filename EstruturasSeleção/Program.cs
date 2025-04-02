class Program
{

    public static void Main()
    {
        
        Console.WriteLine("Qual é sua idade");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Comando 1");


        //if realiza operações que retorna verdadeiro ou falso
        //true - verdadeiro 
        //falso - falso

        if (idade >= 18 )
        {
            Console.WriteLine("É maior de idade/Verdadeiro");
        }
        else 
        { 
            Console.WriteLine("É menor de idade/Falso");
        }



       
    }
}