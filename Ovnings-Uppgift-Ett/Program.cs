bool isRunning = true;
while (isRunning)
{
    Console.WriteLine("Hello, User!");
    Console.WriteLine("Please Enter Your Firstname:");
    string userFirstName = Console.ReadLine() ?? string.Empty;
    Console.WriteLine("Hello " + userFirstName);
    Console.WriteLine("Please Enter Your Lastname:");
    string userLastName = Console.ReadLine() ?? string.Empty;
    Console.WriteLine("Please Enter Your Age:");
    int userAge;
    while (!int.TryParse(Console.ReadLine(), out userAge))
    {
        Console.WriteLine("You Must Enter a Number As a Valid Age, Please Try again");
    }
    Console.WriteLine("Please Enter Your City or Town of Residence:");
    string userCity = Console.ReadLine() ?? string.Empty;
}