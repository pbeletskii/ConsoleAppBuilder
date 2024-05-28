namespace ConsoleAppBuilderVersion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog.Builder()
                .WithName("Buddy")
                .WithBreed("Golden Retriever")
                .WithAge(3)
                .WithToys(new List<string> { "Ball", "Bone" })
                .Build();
            Console.WriteLine($@"Имя: {dog.Name} 
Возраст: {dog.Age}
Порода: {dog.Breed}
Игрушки: {dog.Toys[0]}, {dog.Toys[1]}");
        }
    }
}
