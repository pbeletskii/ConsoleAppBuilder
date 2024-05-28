namespace ConsoleAppBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogBuilder builder = new ConcreteDogBuilder();
            Seller seller = new Seller(builder);
            seller.Construct();
            Dog dog = builder.GetInfo();
            Console.WriteLine($@"Имя: {dog.Name} 
Возраст: {dog.Age}
Порода: {dog.Breed}
Игрушки: {dog.Toys[0]}");
        }
    }
}
