 namespace BusShuttle;
 
 public class ConsoleUI {
        FileSaver  fileSaver;

        public ConsoleUI() {
            fileSaver = new FileSaver("passenger-data.txt");
        }

        public void Show() {

            string mode = askForInput("Please select mode (driver OR manager): ");

            if (mode == "driver") {

                string command;

                do {

                    string stopName = askForInput ("Enter stop name: ");

                    int boarded = int.Parse(askForInput ("Enter number of boarded passengers: "));

                    fileSaver.AppendLine (stopName+":"+boarded);

                    command = askForInput ("Enter command (end OR continue): ");

                } while (command!= "end");

        }
    }
    public static string askForInput (string message) {
        Console.Write(message);
        return Console.ReadLine();
    }

}