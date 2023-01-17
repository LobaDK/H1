namespace H1GPDag1
{
    class Prorgam
    {
        internal static void Main(string[] args)
        {
            string menu = "";
            while (menu != "m" && menu != "yard" && menu != "inches" && menu != "c" && menu != "f") 
            {
                System.Console.Write("\nType 'M' to convert kilometers to miles\nType 'yard' to convert miles to yards\nType 'inches' to convert centimeters to inches\nType 'f' to convert celsius to farenheit\nType 'c' to convert farenheit to celsius\n: ");
                menu = System.Convert.ToString(System.Console.ReadLine()).ToLower();
            }

            if (menu == "m")
            {
                System.Console.Write("Distance in kilometers to convert to miles: ");
                double km = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine($"Distance in miles: {ConvertToMiles(km)}");
            }
            else if (menu == "yard")
            {
                System.Console.Write("Distance in miles to convert to yards: ");
                double m = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine($"Distance in yards: {ConvertToYards(m)}");
            }
            else if (menu == "inches")
            {
                System.Console.Write("Distance in centimeters to convert to inches: ");
                double i = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine($"Distance in inches: {ConvertToInches(i)}");
            }
            else if (menu == "c")
            {
                System.Console.Write("Temperature in Celsious to convert to Farenheit: ");
                double f = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine($"Temperature in Farenheit: {ConvertToFarenheit(f)}");
            }
            else if (menu == "f")
            {
                System.Console.Write("Temperature in Farenheit to convert to Celcius: ");
                double c = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine($"Temperature in Calsius: {ConvertToCelsius(c)}");
            }

            System.Console.ReadKey();
        }

        internal static double ConvertToMiles(double km)
        {
            return km * 0.62137;
        }
        internal static double ConvertToYards(double m)
        {
            return m * 1760;
        }
        internal static double ConvertToInches(double cm)
        {
            return cm * 0.3937;
        }
        internal static double ConvertToCelsius(double f)
        {
            return (f - 32) * 0.5556;
        }
        internal static double ConvertToFarenheit(double c)
        {
            return (c * 1.8) + 32;
        }
    }
}