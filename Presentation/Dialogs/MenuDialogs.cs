namespace Presentation.Dialogs;

public static class MenuDialogs
{
    public static void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Skapa projekt");
            Console.WriteLine("2. Visa projekt");
            Console.WriteLine("3. Uppdatera projekt");
            Console.WriteLine("Q. Avsluta");
            Console.Write("\nVälj ett alternativ: ");
            string option = Console.ReadLine()!.ToLower();
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
                case "q":
                    Console.Clear();
                    Console.WriteLine("Hej då!");
                    Environment.Exit(-1);
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Ogiltig inmatning. Försök igen!\n");
                    break;
            }
        }
    }

    public static void CreateProject()
    {
        Console.Clear();
        // Skapa projekt
        Console.WriteLine("--> Skapa projekt <--\n");
    }

    public static void ShowProjects()
    {
        Console.Clear();
        // Visar alla projekt
        Console.WriteLine("--> Visa projekt <--\n");
    }

    public static void UpdateProject()
    {
        Console.Clear();
        // Uppdatera projekt
        Console.WriteLine("--> Uppdatera projekt <--\n");
    }
}