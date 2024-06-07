using System;

class Hurricane { // class Huricane
  public static void Main (string[] args) {// 
// loop through the program 4 times in order to acheve 4 tests
    for(int i = 1; i <= 4; i++){// open for loop
// prompt user for wind speed
    Console.WriteLine("Enter the wind speed in MPH: ");
// variable windSpeed will hold user input
    string windSpeed = Console.ReadLine();
// this method will extract the numerical value from the string and trim the white space. allowing the user to type characters with out throwing an exception error
      string windSpeedValue = windSpeed.Split(' ')[0].Trim();
// use the .TryParse method to convert the user inputted string in to a double
    if (double.TryParse(windSpeedValue, out double windSpeedDBL))
// use a condtional statement to determine the wind speed and display the correct output
    if(windSpeedDBL >= 157){// open if
      Console.WriteLine("Category 5 Hurricane\n");
      Console. WriteLine("Test Passed\n");
      }// close if
    else if(windSpeedDBL >= 130){// open else if 1
      Console.WriteLine("Category 4 Hurricane\n");
      Console. WriteLine("Test Passed\n");
      }// close else if 1
    else if(windSpeedDBL >= 111){// open else if 2
      Console.WriteLine("Category 3 Hurricane\n");
      Console. WriteLine("Test Passed\n");
      }// close else if 2
    else if(windSpeedDBL >= 96){// open else if 3
      Console.WriteLine("Category 2 Hurricane\n");
      Console. WriteLine("Test Passed\n");
      }//close else if 3
    else if(windSpeedDBL >= 74){// open else if 4
      Console.WriteLine("Category 1 Hurricane\n");
      Console. WriteLine("Test Passed\n");
      }// close else if 4
    else{// open else
      Console.WriteLine("Not a Hurricane\n");
      Console. WriteLine("Test Passed\n");
      }// close else
    }// close for loop
  }// close Main
}// close class Hurricane
