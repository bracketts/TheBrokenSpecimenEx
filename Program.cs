using System;
using System.Collections.Generic;

class Program
{
    static void Main()

    {

        List<String?> rawUsers = ["Guillermo", "  ", "Al", "Carlos", null, "Ana", "Alex"];

        Console.WriteLine("Processing users...");


        for (int i = 0; i < rawUsers.Count; i++)
        {
            string? name = rawUsers[i];

            if (name == null)
            {
                continue;
            }

            string trimmedName = name.Trim();

            if (trimmedName.Length < 3 || trimmedName == "")
            {
                Console.WriteLine($"Skipping invalid name: {trimmedName}");
                continue;
            }


            Console.WriteLine($"Successfully registered: {trimmedName}");
        }
    }
}
