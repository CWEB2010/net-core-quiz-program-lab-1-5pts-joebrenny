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
        string [, ] optionChoices  = {
                                     {"A) jjjjjj","B)kkkkkkk","C)kkkkkkkk","D)lllllllll"},
                                     {"A) uuuuuuu","B)ooooooo","C)choice2","D)pppppppp"},
                                     {"A) jjj","B)ooo","C)cho","D)ppp"},
                                     {"A) jjjj","B)oooo","C)choo","D)pppp"},
                                     {"A) jjjjj","B)ooooo","C)chooo","D)ppppp"},
                                     {"A) jjjjjj","B)oooooo","C)choool","D)pppppl"},
                                     {"A) 88","B)88","C)88","D)88"},
                                     {"A) 99","B)99","C)99","D)99"},
                                     {"A) 1010","B)1010","C)1010","D)1010"}
                                    };
        string primingValue; //primer
        string EXIT = "2";
        int x,y;  //looping vars
        int totalCorrect, inCorrect; 

        //welcome message and instructions for the program and end user 
            Console.WriteLine("Welcome to this program that is a Quiz for .NETCORE. \n PLease Awnser the questions You need seven out of TEN to pass");
            Console.WriteLine("To get started please type start and press ENTER");
            primingValue = Console.ReadLine();
        }//end of the main method
            
    }// class end
}
