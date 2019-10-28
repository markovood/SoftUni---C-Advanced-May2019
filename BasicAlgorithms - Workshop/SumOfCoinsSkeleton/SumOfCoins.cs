using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main()
    {
        var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
        var targetSum = 923;

        var selectedCoins = ChooseCoins(availableCoins, targetSum);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        var sortedCoins = coins.OrderByDescending(c => c);
        var choosenCoins = new Dictionary<int, int>();

        foreach (var coinValue in sortedCoins)
        {
            int coinsNeeded = targetSum / coinValue;
            if (coinsNeeded > 0)
            {
                choosenCoins.Add(coinValue, coinsNeeded);
                targetSum -= coinsNeeded * coinValue;
                if (targetSum == 0)
                {
                    return choosenCoins;
                }
            }
        }

        throw new InvalidOperationException("Error");
    }
}