public class Program
{
    public static void Main()
    {
        Console.WriteLine("---------Cadastro de usuário---------");

        //Solicitar o nome do usuário
        Console.WriteLine("Digite seu nome: ");
        //lê o nome  
        string name = Console.ReadLine();
    
        //Solicitar idade do usuário
        Console.WriteLine("Digite sua idade: ");

        //Lê idade
        //Convert to Int é usado pois ReadLine só funciona para string
        int age = Convert.ToInt32(Console.ReadLine());


        //Saídas
        Console.WriteLine("Nome do usuário: " + name);
        Console.WriteLine("Idade do usuário: " + age);
    }
}