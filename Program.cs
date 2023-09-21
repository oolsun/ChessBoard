namespace ChessBoard
{
    // Olov Olsson Sundqvist .NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            // Unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Welcomes user to program and asks to input a number.
            Console.WriteLine("Välkommen!\nJag kommer rita ut ett schackbräde som du väljer designen på!");
            Console.WriteLine("Vänligen välj antalet rader och kolumner som schackbrädet ska bestå av:");

            // Create an integer that will get its real value in the while loop.
            int number = 0;
            // Convert input to integer and using while loop with if-else to make sure the user inputs a number and not a letter.
            while (true)
            {
                string input = Console.ReadLine();
                int numberInput;
                bool success = int.TryParse(input, out numberInput);
                // If input is an integer, add that integer to 'number' int and exit loop.
                if (success)
                {
                    number = numberInput;
                    break;
                }
                // If input is not an integer, give error message and restart loop.
                else
                {
                    Console.WriteLine("Du måste välja en siffra!");
                }
            }

            // Set default value to chessboard squares
            string whiteBox = "□";
            string blackBox = "■";

            // Ask user if it wants to change the look of the chessboard squares.
            // Using a while loop for exceptions handling and if-else to see what choice the user makes and makes sure it doesn't crash program.
            while (true)
            {
                Console.WriteLine("Vill du välja utseende på schackrutorna? [y/n]");
                string answer = Console.ReadLine();
                // If user answers 'y', let the user choose the look of the squares and exit loop.
                if (answer.ToLower() == "y")
                {
                    Console.WriteLine("Vänligen välj utseende på vit ruta");
                    whiteBox = Console.ReadLine();
                    Console.WriteLine("Vänligen välj utseende på svart ruta");
                    blackBox = Console.ReadLine();
                    break;
                }
                // If user answers 'n', exit the loop and keep default value on whiteBox and blackBox.
                else if (answer == "n")
                {
                    break;
                }
                // If user makes a wrong input, show error message and restart loop.
                else
                {
                    Console.WriteLine("Felaktigt val. Vänligen svara bara med 'y' eller 'n'");
                }
            }

            Console.WriteLine("\nHär är ditt schackbräde!\n");


            // Nested for loop that counts the number the user input.
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    // Prints white and black boxes one after the other on a line of the chessboard.
                    if ((i + j) % 2 == 0)
                        Console.Write(whiteBox);
                    else
                        Console.Write(blackBox);
                }
                // Start at new line of the chessboard
                Console.WriteLine();
            }
            // Closing program
            Console.WriteLine("\nTryck på valfri tangent för att avsluta...");
            Console.ReadKey();
        }
    }
}