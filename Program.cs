/*
 Övning 3: Skriva ett program som frågar efter användarens namn och ålder för att sedan ange i
vilken grupp som användaren hamnar i flygbolagets speciella ordning.
1.Alla som heter Felicia och Felix eftersom de har namnsdag.
2.Alla som är äldre än 75 år.
3. Alla som är från 18 t.o.m 25 år
4.Övriga passagerare
 */


namespace moreIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the airport!");
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine().ToLower();
                if (name == "felix" || name == "felicia")
                {
                    Console.WriteLine("Congratulations! You may enter the plane first.");
                    break;
                }
                else 
                {
                    while (true)
                    {
                        Console.WriteLine("How old are you?");
                        if (int.TryParse(Console.ReadLine(), out int age))
                        {
                            if (age > 74)
                            {
                                Console.WriteLine("You may abord the plane second!");
                                break;
                            }
                            else if (age > 17 && age < 26)
                            {
                                Console.WriteLine("You may abord third on the plane!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you have to wait til everyone is onboard!");
                                break;
                            }

                        }
                        else { Console.WriteLine("Wrong input.."); continue; }
                    }
                    
                }
            }   
        }
    }
}
