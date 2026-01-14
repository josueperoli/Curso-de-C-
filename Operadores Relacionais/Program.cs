public class Program()
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite um segundo número: ");
        int y = Convert.ToInt32(Console.ReadLine());

        //Operador de igualdade (==)
        if(x == y)
        {
            Console.WriteLine("x é igual a y");
        } 
        else
        {
            if(x != y)
            {
                Console.WriteLine("x é diferente de y");
                if(x > y)
                {
                    Console.WriteLine("x é maior que y");
                }
                else
                {
                    Console.WriteLine("y é maior que x");
                }
            }
        } 
    }
}