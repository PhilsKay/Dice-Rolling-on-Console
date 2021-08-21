using System;

namespace Dice_Rolling
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string restart = " ";
            do
            {
                // Call the method
                DiceGame();
                Console.WriteLine("Enter \"P\" to play again or any other key to quit");
                restart = Console.ReadLine().ToUpper();
            } while (restart == "P");
            // The dice rolling method
            static void DiceGame()
            {
                Random random = new Random();
                float value = (float)random.NextDouble();
                int diceRoll = 0;
                bool notRolledWell = true;
                while (notRolledWell)
                {
                    try
                    {
                        Console.Write("Roll the dice by entering from 0 - 6 : ");
                        diceRoll = Convert.ToInt32(Console.ReadLine());
                        //So we get a result from zero to six
                        switch (diceRoll)
                        {
                            case 0:
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                                notRolledWell = false;
                                break;
                            default:
                                Console.WriteLine("Roll the dice well");
                                break;
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message + " Roll the dice well");
                    }
                }
                //Boolean if the user inputs the correct number from the case above.
                if (notRolledWell == false)
                {
                    Console.WriteLine("You rolled {0}", (int)(value * diceRoll));
                }
            }
            Console.ReadLine();
        }
    }
}
