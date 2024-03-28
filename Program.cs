using System;
using System.IO;

class Program {
    static void Main(string[] args){
        Console.WriteLine("Welcome to the stats side of basketball. This program "+
        "will help you to keep track of your basic counting and efficiency stats " +
        "This will help you to see where you could use improvement " +
        "and set goals off of that. We'll also build your dream profile if you were to" +
        "to make it to the NBA. Finally, it'll help you keep track of your record.");

        bool continueLoop = true;
        string dribble = "";
        string fileName = "";
        while (continueLoop) {
            Console.WriteLine("Please choose from the menu.\n" +
            "1 - Enter name\n" +
            "2 - Enter dream info\n" + 
            "3 - Enter new shot data\n" +
            "4 - Enter new record data\n" +
            "5 - Load profile\n" +
            "6 - Save data to file\n" +
            "7 - Delete data\n" +
            "8 - Quit program\n");
            string userInput = Console.ReadLine();
            switch (userInput) {
                case "1":
                    Console.WriteLine("Enter first name, followed by last name.");
                    string first = Console.ReadLine();
                    string last = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Enter dream team, followed by dream jersey number.");
                    string team = Console.ReadLine();
                    int jersey = int.Parse(Console.ReadLine());
                    break;
                case "3":
                     Console.WriteLine("Please enter type of dribble before shots. For example, 0 dribbles, 1 dribble " +
                    "2 dribbles, 3+ dribbles");
                    dribble = Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Enter type of game you wish to record your record for." +
                    "For example, Team Game, or One-on-One");
                    string type = Console.ReadLine();
                    if (type == "Team Game") {

                    }
                    else if (type == "One-on-One") {

                    }
                    else {
                        Console.WriteLine("Please enter response as shown in the examples.");
                    }
                    break;
                case "5":
                    Console.WriteLine("Enter the name of the file you wish to load.");
                    fileName = Console.ReadLine();
                    break;
                case "6":
                    Console.WriteLine("Enter filename you wish to save to.");
                    fileName = Console.ReadLine();
                    break;
                case "7":
                    Console.WriteLine("Enter filename you wish to delete the stats from.");
                    fileName = Console.ReadLine();
                    break;
                case "8":
                    continueLoop = false;
                    break;
            }
           
        }
    }
}
