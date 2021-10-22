using System;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("On va jouer a un jeu");
            Console.WriteLine("Je vais te poser 5 questions");
            Console.WriteLine("Si tu gagne c'est cool pour toi, si tu perd... Tu meurt :D");
            Console.WriteLine("Trop bien nan ?");
            Console.Write("Du coup quel est tom prénom ? : ");
            string prenom = Console.ReadLine();
            int NumQ = 0;
            int NBQ = 5;
            bool lose = false;

            while (NumQ != NBQ)
            {
                for (int i = 0; i < NBQ; i++)
                {
                    Console.WriteLine("Question n°" + (i + 1) + "/" + NBQ);
                    Random Rand = new Random();
                    int Num1 = Rand.Next(1, 11);
                    int Num2 = Rand.Next(1, 11);
                    int Signe = Rand.Next(1, 3);
                    NumQ = NumQ + 1;
                    if (Signe == 1)
                    {
                        void plus()
                        {
                            Console.Write(Num1 + " + " + Num2 + " = ");
                            string Sresult = Console.ReadLine();
                            try
                            {
                                int result = int.Parse(Sresult);
                                int RQ = Num1 + Num2;
                                if (RQ != result)
                                {
                                    NumQ = 5;
                                    i = 5;
                                    lose = true;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Tu ne peut pas mettre de texte !");
                                plus();
                            }
                        }
                        plus();
                    }
                    else if (Signe == 2)
                    {
                        Console.Write(Num1 + " X " + Num2 + " = ");
                        string Sresult = Console.ReadLine();
                        int result = int.Parse(Sresult);
                        int RQ = Num1 * Num2;
                        if (RQ != result)
                        {
                            NumQ = 5;
                            i = 5;
                            lose = true;
                        }
                    }
                }
                
            }
            
            if (lose = true)
            {
                Console.WriteLine("Dommage " + prenom + " tu a perdu...");
            }
            else
            {
                Console.WriteLine("Bravo " + prenom + " Tu a répondu juste a toutes les questions !");
            }
        }
    }
}
