using System;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
        //need to delcare Variables and Intialize
        
        //DECLARATIONS 
        String [] answerkey = {"B","B","C","A","D","A","A","C","D","A"};
        String [] anwserKey = new String [10];  //empty array to store awnsers
        String userSelection;
        String [] questions ={"question one ","question Two","Question Three","Question Four","Question Five ","Question SIX","Question Seven","Question Eight","Question Nine","Question Ten"};
            // muti dimensional array
            String[,] optionChoices = {
                                     {"A) jjjjjj","B)kkkkkkk","C)kkkkkkkk","D)lllllllll"},
                                     {"A) uuuuuuu","B)ooooooo","C)choice2","D)pppppppp"},
                                     {"A) jjj","B)ooo","C)cho","D)ppp"},
                                     {"A) jjjj","B)oooo","C)choo","D)pppp"},
                                     {"A) jjjjj","B)ooooo","C)chooo","D)ppppp"},
                                     {"A) jjjjjj","B)oooooo","C)choool","D)pppppl"},
                                     {"A) 88","B)88","C)88","D)88"},
                                     {"A) 99","B)99","C)99","D)99"},
                                     {"A) 1010","B)1010","C)1010","D)1010"},
                                     {"A) ten","B) ten","C) ten","D)TEEEEN" }
                                    };
        string primingValue; //primer
        string EXIT = "2";
        int x,y;  //looping vars
        int totalCorrect, inCorrect; 

        //welcome message and instructions for the program and end user 
            Console.WriteLine("Welcome to this program that is a Quiz for .NETCORE. \n PLease Awnser the questions You need seven out of TEN to pass");
            Console.WriteLine("To get started please type start and press ENTER");
            primingValue = Console.ReadLine();
            while(primingValue != EXIT)
            {
                //reseting for next round
                totalCorrect = 0;
                inCorrect = 0;
                //loop to out put questions 
                for (x = 0; x < questions.Length; x++)
                {
                    Console.WriteLine(questions[x]);
                    //nested loop for options choices
                    for (y = 0; y < 4; y++)
                    {
                        Console.WriteLine(optionChoices[x,y]);
                    }//end for loop for awnsers
                    Console.WriteLine("Please Enter your awnser");
                    userSelection=Console.ReadLine();
                    //decision making logic to determine if they got the question correct or not 
                    Console.Clear();
                        
                }//end questions loop
                Console.WriteLine("To take Quiz again type ENTER of 2 to quit");
                //reask the primer 
                primingValue = Console.ReadLine();
                    

            }//end while loop 
        }//end of the main method
            
    }// class end
}
