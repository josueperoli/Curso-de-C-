public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num % 2 == 0){
            Console.WriteLine("É par!");
        }
        else
        {
            Console.WriteLine("É ímpar!");
        }
    }
}