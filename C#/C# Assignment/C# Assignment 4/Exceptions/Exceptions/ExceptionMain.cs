using System;

namespace Exceptions {

    // main class to play the quiz
    class ExceptionMain {
        static void Main(string[] args) {
            int inputNumber=0;
            int outputNumber=0;
            
            // this for loop is ued for taking input for five time
            forloop:
            for (int variable = 0; variable <  6; variable++) {
                // try catch is for check whether it is executed for 5 time or not
                try {
                    if(variable==5) {
                        throw new Limit("You have crossed your limit of 5");
                    }

                inputValid: Console.WriteLine("Enter number between 1 to 5");
                    try {
                        inputNumber = Convert.ToInt32(Console.ReadLine());
                    } catch(Exception e) {
                        Console.WriteLine("Invalid input");
                    }

                    // it is used to inpur check between 1-5
                    try {
                        if (inputNumber > 5 || inputNumber < 1) {
                            throw new InputFormativalid("Enter number in correct format");
                        } else {
                            QuizClass Quiz = new QuizClass();
                            outputNumber = Quiz.GetData(inputNumber);
                            Quiz.ShowData(outputNumber);

                        }
                    } catch (InputFormativalid e) {
                        Console.WriteLine(e.Message);
                        goto inputValid;
                    }
                } catch (Limit e) {
                    Console.WriteLine(e.Message);
                    string temp;
                    Console.WriteLine("Do you want to continue[y/n]");
                    temp = Console.ReadLine();
                    if (temp=="y") {
                        goto forloop;
                    }
                }
            }
        }
    }
}