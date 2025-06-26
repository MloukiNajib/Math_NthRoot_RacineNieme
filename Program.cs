// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Calcul de la racine n-ième en C#");
Console.WriteLine("la racine n-ième d'un nombre x est le nombre y tel que y^n = x ");
Console.WriteLine("------------------------");
Algorithm.Test(81, 4);        // 81^(1/4) = 3
Algorithm.Test(100, 3);       // 100^(1/3) ≈ 4.641588833612778
Algorithm.Test(25000, 15);    // 25000^(1/15) ≈ 1.9642465570320196
Algorithm.Test(81, 2);        // 81^(1/2) = 9
Algorithm.Test(11111, 11);   // 11111^(1/11) ≈ 2.3323608379671588
Algorithm.Test(2829383, 8);   // 2829383^(1/8) ≈ 6.404149586036538
Console.WriteLine("------------------------");

Console.ReadLine();


public class Algorithm
{
    public static double GetNthRoot(double number, int n)
    {
        double low = 1.0;
        double high = number;
        double epsilon = 1e-17;
        double distance = (high - low);
       // Console.WriteLine($"distance ({high} - {low}) \t =  {distance}");

        while (distance  > epsilon)
        {
            double mid = (low + high) / 2.0;
            double midPow = FastPower(mid, n);

            if (midPow < number)
                low = mid;
            else
                high = mid;
           
            if(distance != (high - low))
                distance = (high - low);
            else
                distance = 0.0; // pour éviter une boucle infinie si la distance ne change pas
            
           // Console.WriteLine($"distance ({high} - {low}) \t =  {distance}");
        }

        return RoundManual((low + high) / 2.0, 16);
    }

    /// <summary>
    /// Calcule base^exp avec l'exponentiation rapide
    /// </summary>
    private static double FastPower(double @base, int exp)
    {
        double result = 1.0;
        while (exp > 0)
        {
            if ((exp % 2) == 1) // exp impair
                result *= @base;

            @base *= @base;
            exp /= 2;
        }
        return result;
    }

    /// <summary>
    /// Arrondit un double à un nombre de décimales donné sans utiliser Math.Round.
    /// </summary>
    public static double RoundManual(double value, int decimals)
    {
        double factor = 1.0;

        // Construire 10^decimals
        for (int i = 0; i < decimals; i++)
            factor *= 10;

        // Décalage à gauche, arrondi, puis retour à droite
        if (value >= 0)
            return ((double)(value * factor + 0.5)) / factor;
        else
            return ((double)(value * factor - 0.5)) / factor;
    }

    public static void Test(double number, int n)
    {
        double calculated = GetNthRoot(number, n);
        double expected = Math.Pow(number, 1.0/n); // Référence (simulée)

        Console.WriteLine($"{number} ^ 1/{n} \t = Calculated: {calculated} \t \t | Expected: {expected}");
    }

}
