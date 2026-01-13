public class Program
{
    public static void Main()
    {
        //Inicializar uma variável
        int x = 10;
        Console.WriteLine("Valor inicial de x: " + x);

        //Operador de Atribuição Simples 
        x = 20;
        Console.WriteLine("Atribuição simples, x vale: " + x);

        //Atribuição Composta (Incremento) (++)
        x++; //x = x + 1
        Console.WriteLine("Atribuição Composta Incremento, x vale: " + x);

        //Atribuição Composta (+=)
        x += 10; //x = x + 10
        Console.WriteLine("Atribuição Composta, x vale: " + x);

        //Atribuição Composta (-=)
        x -= 10; //x = x - 10
        Console.WriteLine("Atribuição Composta, x vale: " + x);

        //Atribuição Composta (*=)
        x *= 10; //x = x * 10
        Console.WriteLine("Atribuição Composta, x vale: " + x);

        //Atribuição Composta (/=)
        x /= 10; //x = x / 10
        Console.WriteLine("Atribuição Composta, x vale: " + x);
    }
}