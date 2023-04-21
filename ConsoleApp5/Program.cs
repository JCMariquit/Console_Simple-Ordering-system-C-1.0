class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("                    Choose Your Ice Cream");
        Console.WriteLine("    Item Number                Item              Price");
        Console.WriteLine("");
        Console.WriteLine("        S1      -       small ice cream     -   10pesos");
        Console.WriteLine("        M2      -       medium ice cream    -   15pesos");
        Console.WriteLine("        L3      -       Large ice cream     -   20pesos");
        Console.WriteLine("");

        Console.WriteLine("Enter your Name");
        Console.ReadLine();
        Console.WriteLine("Choose your ice cream");
        Console.WriteLine("Enter Item number");
        String size = Console.ReadLine();
        int price;
        if (size == "S") price = 10;
        else if (size == "M") price = 15;
        else price = 20;
        Console.Write("Quantity: ");
        int amount = Convert.ToInt32(Console.ReadLine());
        int total = price * amount;
        System.Console.Write("Enter payment: ");
        int payment = Convert.ToInt32(Console.ReadLine());
        int change = payment - total;
        System.Console.Write("change: " + change);

    }
}