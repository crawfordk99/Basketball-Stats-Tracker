using System;
using System.IO;

class Program {
    static void Main(string[] args){
        Console.WriteLine("Welcome to the stats side of basketball. This program "+
        "will help you to keep track of your basic counting and efficiency stats " +
        "This will help you to see where you could use improvement " +
        "and set goals off of that. We'll also build your dream profile if you were " +
        "to make it to the pros. Finally, it'll help you keep track of your record.");

        // reusable variables
        bool continueLoop = true;
        string dribble = "";
        string fileName = "";
        string content = "";
        string type = "";
        Files files = new Files();
        double trueShooting = 0;
        while (continueLoop) {
            Console.WriteLine("Please choose from the menu.\n" +
            "1 - Enter name\n" +
            "2 - Enter dream info\n" + 
            "3 - Enter new shot data\n" +
            "4 - Enter new record data\n" +
            "5 - Load profile\n" +
            "6 - Delete data\n" +
            "7 - Quit program\n");
            string userInput = Console.ReadLine();
            switch (userInput) {
                case "1":
                    Console.WriteLine("Enter first name, followed by last name. File will be created based on name.");
                    string first = Console.ReadLine();
                    string last = Console.ReadLine();
                    Person person = new Person(first, last);
                    fileName = ($"{person.FirstName}{person.LastName}.txt");
                    content = ($"Name: {person.FirstName} {person.LastName}");
                    files = new Files(fileName, content);
                    files.WriteToFile();
                    break;
                case "2":
                    Console.WriteLine("Enter name of file you wish to update.");
                    fileName = Console.ReadLine();
                    Console.WriteLine("Enter dream team, followed by dream jersey number.");
                    string team = Console.ReadLine();
                    int jersey = int.Parse(Console.ReadLine());
                    DreamTeam dt = new DreamTeam(team, jersey);
                    content = ($"Dream Team: {dt.Team}, Jersey Number: {dt.JerseyNumber}");
                    files = new Files(fileName, content);
                    files.WriteToFile();
                    break;
                case "3":
                    Console.WriteLine("Enter name of file you wish to update.");
                    fileName = Console.ReadLine();
                     Console.WriteLine("Please enter type of dribble before shots. For example, 0, 1, " +
                    "2, 3+.");
                    dribble = Console.ReadLine();
                    Console.WriteLine("Please enter type of shot. Two or Three.");
                    type = Console.ReadLine();
                    TypeOfShot tos = new TypeOfShot(dribble, type);
                    if (tos.PointsType == "Two") {
                        Console.WriteLine("Please enter shots made, followed by number of attempts");
                        int makes = int.Parse(Console.ReadLine());
                        int trys = int.Parse(Console.ReadLine());
                        TwoPoints two = new TwoPoints(makes, trys);
                        trueShooting = two.CalculateTrueShooting();
                        content = ($"Dribbles: {tos.Dribbles} 2FG: {two.ShotsMade} 2FGA: {two.ShotsAttempted} TS%: {trueShooting: 0.000}");
                        files = new Files(fileName, content);
                        files.WriteToFile();
                    }
                    else if (tos.PointsType == "Three") {
                        Console.WriteLine("Please enter shots made, followed by number of attempts");
                        int makes = int.Parse(Console.ReadLine());
                        int trys = int.Parse(Console.ReadLine());
                        ThreePoints three = new ThreePoints(makes, trys);
                        trueShooting = three.CalculateTrueShooting();
                        content = ($"Dribbles: {tos.Dribbles} 3FG: {three.ShotsMade} 3FGA: {three.ShotsAttempted} TS%: {trueShooting: 0.000}");
                        files = new Files(fileName, content);
                        files.WriteToFile();
                    }
                    
                    break;
                case "4":
                    Console.WriteLine("Please enter name of file you wish to update.");
                    fileName = Console.ReadLine();
                    Console.WriteLine("Enter type of game you wish to record your record for." +
                    "For example, Team Game, or One-on-One");
                    type = Console.ReadLine();
                    Record record = new Record();
                    Console.WriteLine("Please enter a number for win and loss. 1 for won if you won, 0 if you lost for won" +
                    " and 1 for lost.");
                    int win = int.Parse(Console.ReadLine());
                    int loss = int.Parse(Console.ReadLine());
                    record = new Record(type, win, loss);
                    content = ($"Game Type- {record.Type}:{record.Wins} - {record.Loses}");
                    files = new Files (fileName, content);
                    break;
                case "5":
                    Console.WriteLine("Enter the name of the file you wish to load.");
                    fileName = Console.ReadLine();
                    files = new Files(fileName);
                    files.ReadFile();
                    break;
                case "6":
                    Console.WriteLine("Enter filename you wish to delete the stats from.");
                    fileName = Console.ReadLine();
                    files = new Files(fileName);
                    files.DeleteFileContent();
                    break;
                case "7":
                    continueLoop = false;
                    break;
            }
           
        }
    }
}
