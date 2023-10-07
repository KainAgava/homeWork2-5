using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandRubToUsd = "1";
            const string CommandRubToEuro = "2";
            const string CommandUsdToRub = "3";
            const string CommandUsdToEuro = "4";
            const string CommandEuroToRub = "5";
            const string CommandEuroToUsd = "6";
            const string CommandMenuBalanse = "7";
            const string CommandExit = "8";

            float rublesInWallet;
            float dollarsInWallet;
            float euroInWallet;
            float rubToUsd = 0.0099f, rubToEuro = 0.0094f;
            float usdToRub = 100.5f, usdToEuro = 0.95f;
            float euroToRub = 106, euroToUsd = 1.05f;
            float exchengeCurrencyCount;

            string desiredOperatin;
            bool isCommandExit = true;
            
            Console.WriteLine("Добро пожаловать в обменник валют");
            Console.WriteLine("Введите баланс рублей: ");
            rublesInWallet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс долларов: ");
            dollarsInWallet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс евро: ");
            euroInWallet = Convert.ToInt32(Console.ReadLine());


            while (isCommandExit)
            {
                Console.WriteLine("Выберите необходимую операцию");
                Console.WriteLine($"{CommandRubToUsd} - обмен рубли на доллары");
                Console.WriteLine($"{CommandRubToEuro}- обмен рубли на евро");
                Console.WriteLine($"{CommandUsdToRub} - обмен доллары на рубли");
                Console.WriteLine($"{CommandUsdToEuro}- обмен доллары на евро");
                Console.WriteLine($"{CommandEuroToRub} - обмен евро на рубли");
                Console.WriteLine($"{CommandEuroToUsd}- обмен евро на доллары");
                Console.WriteLine($"{CommandMenuBalanse} - баланс");
                Console.WriteLine($"{CommandExit} - выход");
                Console.WriteLine("Ващ выбор: ");
                desiredOperatin = Console.ReadLine();
                switch (desiredOperatin)
                {
                    case CommandRubToUsd:
                        Console.Write("обмен рубли на доллары");
                        Console.Write("сколько вы хотите обменять? ");
                        exchengeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rublesInWallet >= exchengeCurrencyCount)
                        {
                            rublesInWallet -= exchengeCurrencyCount;
                            dollarsInWallet += exchengeCurrencyCount * rubToUsd;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей");
                            break;
                        }
                    case CommandRubToEuro:
                        Console.WriteLine("обмен рубли на евро");
                        Console.WriteLine("сколько вы хотите обменять? ");
                        exchengeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rublesInWallet >= exchengeCurrencyCount)
                        {
                            rublesInWallet -= exchengeCurrencyCount;
                            euroInWallet += exchengeCurrencyCount * rubToEuro;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество рублей");
                            break;
                        }
                    case CommandUsdToRub:
                        Console.WriteLine("обмен доллары на рубли");
                        Console.WriteLine("сколько вы хотите обменять? ");
                        exchengeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rublesInWallet >= exchengeCurrencyCount)
                        {
                            dollarsInWallet -= exchengeCurrencyCount;
                            rublesInWallet += exchengeCurrencyCount * usdToRub;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество долларов");
                            break;
                        }
                    case CommandUsdToEuro:
                        Console.WriteLine("обмен доллары на евро");
                        Console.WriteLine("сколько вы хотите обменять? ");
                        exchengeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rublesInWallet >= exchengeCurrencyCount)
                        {
                            dollarsInWallet -= exchengeCurrencyCount;
                            euroInWallet += exchengeCurrencyCount * usdToEuro;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество долларов");
                            break;
                        }
                    case CommandEuroToRub:
                        Console.WriteLine("обмен евро на рубли");
                        Console.WriteLine("сколько вы хотите обменять? ");
                        exchengeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rublesInWallet >= exchengeCurrencyCount)
                        {
                            euroInWallet -= exchengeCurrencyCount;
                            rublesInWallet += exchengeCurrencyCount * euroToRub;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество евро");
                            break;
                        }
                    case CommandEuroToUsd:
                        Console.WriteLine("обмен евро на доллары");
                        Console.WriteLine("сколько вы хотите обменять? ");
                        exchengeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rublesInWallet >= exchengeCurrencyCount)
                        {
                            euroInWallet -= exchengeCurrencyCount;
                            dollarsInWallet += exchengeCurrencyCount * euroToUsd;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое количество евро");
                            break;
                        }
                    case CommandMenuBalanse:
                        {
                            Console.WriteLine($"Ваш балан: Рубли - {rublesInWallet} , Доллары - {dollarsInWallet} , Евро - {euroInWallet}");
                            break;
                        }
                    case CommandExit:
                        {
                            Console.WriteLine("Выход");
                            isCommandExit = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Не верная операция");
                        break;

                }
            }
        }
    }
}
