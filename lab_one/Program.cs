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
        String [] anwserKey1 = new String [10];  //empty array to store awnsers
        String userSelection;
        String [] questions ={"What Company maintains the .NETCORE? ","What platforms is it supported on ?","What version of .NETCORE ?","What year did .NETCORE release?","What does CTS stand for? ","WHen is .netcore project to be released?","What is the commandline text to start the console build?","What other platforms does Microsoft make?","what is one thing that make the compliers special","What is the .NETCORE complier platform?"};
            // muti dimensional array
            String[,] optionChoices = {
                                     {"A) AWS","B)Microsoft","C)Google","D)Apple"},
                                     {"A) Linux","B)ALL A,B,C","C)Apple","D)Windows"},
                                     {"A) 10.0","B)3.0","C)3.1 3.1","D)4.0"},
                                     {"A) 2016","B)2001","C)1998","D)1994"},
                                     {"A) Contextual Tools System","B)Console tools stem","C)cool type stuff","D)Common Type System"},
                                     {"A) 2020","B)2021","C)2022","D)2023"},
                                     {"A) Dotnet new Console","B)console build","C).net console build","D)build console"},
                                     {"A) asp.netcore","B).netcore","C)A B and D","D).netcore framework"},
                                     {"A) they are acures","B)they are apple","C)they are amd","D)they are cross platform"},
                                     {"A) Roslyn","B) crm","C) ten","D)TEEEEN4.0" }
                                    };
        string primingValue; //primer
        string EXIT = "2";
        int x,y;  //looping vars
        double totalCorrect, inCorrect; 

        //welcome message and instructions for the program and end user 
            Console.WriteLine("Welcome to this program that is a Quiz for .NETCORE. \n PLease Awnser the questions \n You need seven out of TEN to pass");
            Console.WriteLine("To get started please type start and press ENTER ");
            primingValue = Console.ReadLine();

            while (primingValue != EXIT)
            {
                //reseting for next round
                totalCorrect = 0;
                inCorrect = 0;
                //loop to out put questions 
                for (x = 0; x < questions.Length; x++)
                {
                    Console.WriteLine(questions[x]);
                    //nested loop for options choices
                    for (y = 0; y < optionChoices.GetLength(1); y++) //optionChoices.GetLength(y)
                    {

                        Console.WriteLine(optionChoices[x, y]);
                    }//end for loop for awnsers
                    Console.WriteLine("Please Enter your awnser");
                    userSelection = Console.ReadLine();

                    //decision making logic to determine if they got the question correct or not 
                    Console.Clear();

                    if (userSelection.ToUpper() == answerkey[x])
                    {
                        totalCorrect++; //adding to correct 
                    }
                    else inCorrect++;

                    Console.WriteLine($"you have {totalCorrect} correct awnsers and got {inCorrect} Wrong");
                }//end questions loop
                double POSSIABLEPOINT = 10;
                //Console.WriteLine($"you have {totalCorrect} correct awnsers and got {inCorrect} Wrong");
                //math to find out the % of the score 
                double precentage = 0;
                precentage = (100 * (totalCorrect / POSSIABLEPOINT));

                Console.WriteLine($"{precentage}%");
                if (totalCorrect >= 7) { Console.WriteLine("you passed"); }
                
                else { Console.WriteLine("you failed try again "); }

                //reask the primer 
                Console.WriteLine("To take Quiz again type ENTER of 2 to quit");
                
                primingValue = Console.ReadLine();
                    

            }//end while loop 
        }//end of the main method
            
    }// class end
}
