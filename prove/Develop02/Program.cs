using System;

class Program
{
    static void Main(string[] args)
    {



        string choiceText = Console.ReadLine();
        int choice = int.Parse(choiceText);
        choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");


            Console.Write("What would you like to do? ");
            choiceText = Console.ReadLine();
            choice = int.Parse(choiceText);

            
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            if (choice == 1)
            {
            
                Journal type = new Journal();
                type._write = "What was something that I learned today? ";
                

                
                
                type.Write();




            }




            else if (choice == 2)
            {
        


                Journal show = new Journal();
                show.Display();



            }



            else if (choice == 3)
            {
        





            }


            else if (choice == 4)
            {
        



            }




            else if (choice == 5)
            {
        



            }


        }
    }
}