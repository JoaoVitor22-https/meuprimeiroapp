class Program
{
    public static void Main()
    {
        int idade;
        double frequencia, nota1, nota2, nota3, nota4;
        string nomeEscola, nomeAluno, sexo;
  

        Console.WriteLine("Nome da escola: ");
        string informacao = Console.ReadLine();
        nomeEscola = Convert.ToString(informacao);

        Console.WriteLine("Seu nome: ");
        string informacao2 = Console.ReadLine();
        nomeAluno = Convert.ToString(informacao2);

        Console.WriteLine("Sua Idade: ");
        string informacao3 = Console.ReadLine();
        idade = Convert.ToInt32(informacao3);

        Console.WriteLine("Seu sexo M ou F?: ");
        string informacao4 = Console.ReadLine();
        sexo = Convert.ToString(informacao4);

        Console.WriteLine("Sua Frequência ?: ");
        string informacao5 = Console.ReadLine();
        frequencia = Convert.ToDouble(informacao5);

        Console.WriteLine("Nota1: ");
        string informacao6 = Console.ReadLine();
        nota1 = Convert.ToDouble(informacao6);

        Console.WriteLine("Nota2: ");
        string informacao7 = Console.ReadLine();
        nota2 = Convert.ToDouble(informacao7);

        Console.WriteLine("Nota3: ");
        string informacao8 = Console.ReadLine();
        nota3 = Convert.ToDouble(informacao8);

        Console.WriteLine("Nota4: ");
        string informacao9 = Console.ReadLine();
        nota4 = Convert.ToDouble(informacao9);


        double soma = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine("Escola: {0}", nomeEscola);
        Console.WriteLine("Nome: {0}", nomeAluno);
        Console.WriteLine("Idade: {0}", idade);
        Console.WriteLine("Sexo: {0}", sexo);
        Console.WriteLine("Frequência é: {0}", frequencia);
        Console.WriteLine("Nota1: {0}", nota1);
        Console.WriteLine("Nota2: {0}", nota2);
        Console.WriteLine("nota3: {0}", nota3);
        Console.WriteLine("Nota4: {0}", nota4);
        Console.WriteLine("Sua media é: {0}", soma);
        

    }
}