class Program
{
    static void Main()
    {
        
        int playerCoins = 6000;
        
        int shirtPrice = 2500;
        int helmetPrice = 3000;
        int foodPrice = 500;
        int presentPrice = 1000;
        int shieldPrice = 1500;
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Welcome to the general store!");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");

        Console.WriteLine("What would you like to purchase?");

        Console.WriteLine("A: A nice shirt.");
        Console.WriteLine("B: A protective helmet.");
        Console.WriteLine("C: Some food.");
        Console.WriteLine("D: A present.");
        Console.WriteLine("E: A shield.");

        Console.WriteLine("");

        Console.WriteLine("Enter the letter for your purchase: ");
        string purchaseLetter = Console.ReadLine().ToUpper();

        Console.WriteLine("");

        switch (purchaseLetter) {
            case "A":
                Console.WriteLine("Do you have a discount code? (Y/N): ");
                string discountCode = Console.ReadLine();
                if (discountCode.ToUpper() == "Y")
                {
                    shirtPrice -= 500; // Apply a discount of 500 coins
                }
                playerCoins = playerCoins - shirtPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                break;
            case "B":
                Console.WriteLine("Do you have a discount code? (Y/N): ");
                discountCode = Console.ReadLine();
                if (discountCode.ToUpper() == "Y")
                {
                    helmetPrice -= 700; // Apply a discount of 700 coins
                }
                playerCoins = playerCoins - helmetPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                break;
            case "C":
                Console.WriteLine("Do you have a discount code? (Y/N): ");
                discountCode = Console.ReadLine();
                if (discountCode.ToUpper() == "Y")
                {
                    foodPrice -= 100; // Apply a discount of 100 coins
                }
                playerCoins = playerCoins - foodPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                break;
            case "D":
                Console.WriteLine("Do you have a discount code? (Y/N): ");
                discountCode = Console.ReadLine();
                if (discountCode.ToUpper() == "Y")
                {
                    presentPrice -= 200; // Apply a discount of 200 coins
                }
                playerCoins = playerCoins - presentPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                break;
            case "E":
                Console.WriteLine("Do you have a discount code? (Y/N): ");
                discountCode = Console.ReadLine();
                if (discountCode.ToUpper() == "Y")
                {
                    shieldPrice -= 300; // Apply a discount of 300 coins
                }
                playerCoins = playerCoins - shieldPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                break;
            default:
                Console.WriteLine("Invalid input. Please enter a valid purchase letter.");
                break;
                 
        }
    }
}

