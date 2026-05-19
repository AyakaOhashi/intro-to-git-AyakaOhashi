class Program
{
    static void Main()
    {
        Console.WriteLine("Select a difficulty (Easy, Medium, Hard):");
        string difficultyInput = Console.ReadLine();

         Console.WriteLine("Select a character class (Warrior, Mage, Rogue):");
        string classInput = Console.ReadLine();

        Console.WriteLine("You selected:");
        Console.WriteLine("Difficulty: " + difficultyInput);
        Console.WriteLine("Character Class: " + classInput);

    }
}