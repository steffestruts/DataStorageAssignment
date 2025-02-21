namespace ConsolePresentation.Dialogs;

public class MenuDialogs
{
    public static void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Skapa projekt");
            Console.WriteLine("2. Visa alla projekt");
            Console.WriteLine("3. Uppdatera projekt");
            Console.WriteLine("4. Avsluta");
            Console.Write("Välj ett alternativ: ");
            string option = Console.ReadLine()!;
            switch (option)
            {
                // Skapa projekt
                case "1":
                    CreateProject();
                    break;
                // Visa projekt
                case "2":
                    ShowProjects();
                    break;
                // Uppdatera projekt
                case "3":
                    UpdateProject();
                    break;
                // Avsluta
                case "4":
                    Console.Clear();
                    Console.WriteLine("Hej då!");
                    Environment.Exit(-1);
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Ogiltig inmatning. Försök igen!");
                    break;
            }
        }
    }

    private static void CreateProject()
    {
        // Skapa projekt
        Console.Clear();
        Console.WriteLine("--> Skapa projekt <--\n");
    }

    private static void ShowProjects()
    {
        // Visar alla projekt
        Console.Clear();
        Console.WriteLine("--> Visa alla projekt <--\n");
    }

    private static void UpdateProject()
    {
        // Uppdatera projekt
        Console.Clear();
        Console.WriteLine("--> Uppdatera projekt <--\n");
    }
}
