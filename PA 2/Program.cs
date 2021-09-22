using System;

namespace PA_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Character ronaldmcdonald = new RonaldMcDonald(){Name = "Ronald McDonald", Health = 100, Action = "Throws Stale Nuggets"};
            Character frykids = new FryKids(){Name = "The Fry Kids", Health = 100, Action = "Throws Hot French Fries"};
            Character hamburgler = new Hamburgler(){Name ="Hamburgler", Health = 100, Action = "Throws Stolen Hamburgers"};
           
           string choice = GetMenuChoice();
           string player1choice = DisplayPlayMenu();
           string player2choice = DisplayPlay2Menu();
           while (choice !="3")
           {
               if (choice == "1")
               {
                   DisplayPlayMenu();
                   DisplayPlay2Menu();
                   if (player1choice == "1")
                   {
                       //Hamburger
                   }
                   else if (player1choice == "2")
                   {
                       //Fry Kids
                   }
                   else if (player1choice == "3")
                   {
                       //Ronald
                   }
                   if (player2choice == "1")
                   {
                       //Ham
                   }
                   else if (player2choice == "2")
                   {
                       //Fry Kids
                   }
                   else if (player2choice == "3")
                   {
                       //Ronald
                   }
                   else if (player1choice == player2choice)
                   {
                       System.Console.WriteLine("Dont do that");
                       GetMenuChoice();
                   }

                   //PLAYERGAME METHOD
               }
               else if (choice == "2")
               {
                   DisplayStatsMenu();
               }
               else
               {
                   System.Console.WriteLine("Error, Invalid Choice!");
               }
               choice = GetMenuChoice();
           }
        }
        static string GetMenuChoice()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("BATTLE OF THE AGES");
            Console.ResetColor();
            System.Console.WriteLine("");
            System.Console.WriteLine("Please select an option below");
            System.Console.WriteLine("");
            System.Console.WriteLine("1) Play Game");
            System.Console.WriteLine("2) Show Stats");
            System.Console.WriteLine("3) Exit");
            string choice = Console.ReadLine();

            return choice;

        }
        
        public static void DisplayStatsMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("YOUR CHARACTERS:");
            Console.ResetColor();
            System.Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Magenta;
            System.Console.WriteLine("Hamburgler");
            Console.ResetColor();
            System.Console.WriteLine("Health: 100");
            System.Console.WriteLine("Special Attack: Throws Fradulent Hamburgers at alarming speeds!");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("Ronald McDonald");
            Console.ResetColor();
            System.Console.WriteLine("Health: 100");
            System.Console.WriteLine("Special Attack: Launches three year old fossilized Chicken McNuggets at Mach 1.3!");

            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("The Fry Kids");
            Console.ResetColor();
            System.Console.WriteLine("Health: 100");
            System.Console.WriteLine("Special Attack: Imaples the enemy with Sharpened French Frys!");
            
        }
        static string DisplayPlayMenu()
        {   
            System.Console.WriteLine("Player 1, please enter your name");
            string name2 = Console.ReadLine();
            System.Console.WriteLine(name2 + ", please choose a character to start");
            System.Console.WriteLine("1) Hamburgler");
            System.Console.WriteLine("2) The Fry Kids");
            System.Console.WriteLine("3) Ronald McDonald");
            string player1choice = Console.ReadLine();

            return player1choice;
        }
        static string DisplayPlay2Menu()
        {
            System.Console.WriteLine("Player 2, please enter your name");
            string name1 = Console.ReadLine();
            System.Console.WriteLine(name1 + ", please choose a character to start");
            System.Console.WriteLine("1) Hamburgler");
            System.Console.WriteLine("2) The Fry Kids");
            System.Console.WriteLine("3) Ronald McDonald");
            string player2choice = Console.ReadLine();

            return player2choice;
        }

        public static void PlayGame(Character Hamburgler, Character FryKids, Character RonaldMcDonald ,string player1choice, string player2choice)
        {
            
        }
    }  
}
