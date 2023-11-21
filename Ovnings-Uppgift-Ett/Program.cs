internal class Program
{
    private static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Hello, User!");
            Console.WriteLine("1. Enter Credentials");
            Console.WriteLine("2. Exit");
            int switchSelector;
            while (!int.TryParse(Console.ReadLine(), out switchSelector))
            {
                Console.WriteLine("You Must Enter a Number, Please Try again");
            }
            switch (switchSelector)
            {
                case 1:
                    Console.WriteLine("Please Enter Your Firstname:");
                    string userFirstName = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("Please Enter Your Lastname:");
                    string userLastName = Console.ReadLine() ?? string.Empty;
                    string userFullName = userFirstName + " " + userLastName;
                    Console.WriteLine("Please Enter Your Age:");

                    int userAge;
                    while (!int.TryParse(Console.ReadLine(), out userAge))
                    {
                        Console.WriteLine("You Must Enter a Number As a Valid Age, Please Try again");
                    }

                    int currentYear = DateTime.Now.Year;
                    int userBirthYear = currentYear - userAge;

                    Console.WriteLine("Please Enter Your City or Town of Residence:");
                    string userCity = Console.ReadLine() ?? string.Empty;
                    string formattedCity = char.ToUpper(userCity[0]) + userCity.Substring(1).ToLower();
                    Console.Clear();
                    Console.WriteLine("Thank you, you Entered the following information:");
                    Console.WriteLine($"Full name: {userFullName}");
                    Console.WriteLine($"Age: {userAge}");
                    Console.WriteLine($"Birthyear: {userBirthYear}");
                    Console.WriteLine($"City: {formattedCity}");
                    break;
                case 2:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Please Select a valid option.");
                    break;
            }
        }
    }
}