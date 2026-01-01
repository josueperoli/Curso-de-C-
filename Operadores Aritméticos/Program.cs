public class Program
{
    public static void Main ()
    {   

        Console.WriteLine("Digite o número 1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o número 2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        //Adição
        int soma = n1 + n2;
        Console.WriteLine("A soma é: " + soma);

        //Subtração
        int subtracao = n1 - n2;
        Console.WriteLine("A subtração é: " + subtracao);

        //Multiplicação
        int multiplicacao = n1 * n2;
        Console.WriteLine("A multiplicação é: " + multiplicacao);

        //Divisão
        int divisao = n2 / n1;
        Console.WriteLine("A divisão é: " + divisao);

        //Módulo
        int modulo = n2 % n1;
        Console.WriteLine("O modulo é: " + modulo);
    }
}