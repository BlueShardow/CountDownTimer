using System;
using System.Diagnostics;

class Program 
{
 Program program; 
 string input;
 double inputN, inputNMinutes; // vars

 public Program ()
 {
  program = this;
  inputN = new double ();
  inputNMinutes = new double ();
 }
  
 public void TimerLength (string[] args) // TimerLength
 {
  Console.WriteLine (
    "\nPlease type in your desiered timer length in seconds, then hit enter.\n"
  );
  input = Console.ReadLine ();

  inputN = Convert.ToDouble (input);

  inputNMinutes = inputN / 60;
 } // end of TimerLength

  public void TimerDecimal (string[] args) // TimerDecimal
   {
    Program program = new Program ();
    Stopwatch stopwatch = new Stopwatch ();

    program.TimerLength (args);

    Console.WriteLine (
      "\nYour desired timer length is: " + program.input + " seconds, or " + program.inputNMinutes + " minutes.\n"
    );

    Console.WriteLine ("Type '1' and then hit enter to start the timer.\n");
    string key = Console.ReadLine ();

    if (key == "1") { // if start
      stopwatch.Start ();

      while (stopwatch.Elapsed < TimeSpan.FromSeconds (program.inputN)) { // while loop
        Console.WriteLine (
            "You have " + (program.inputN - stopwatch.Elapsed.TotalSeconds) + " seconds left."
        );
      } // end of while loop
      stopwatch.Stop ();

      Console.WriteLine ("\nYour timer is up!");
    } // end of if start

     else { // else
       Console.WriteLine ("\nYou did not type '1'. Please try again.");
     } // end of else
   } // end of TimerDecimal

  public void TimerWhole (string[] args) // TimeWhole
   {
    Program program = new Program ();
    Stopwatch stopwatch = new Stopwatch ();

    program.TimerLength (args);

    Console.WriteLine (
      "\nYour desired timer length is: " + program.input + " seconds, or " + program.inputNMinutes + " minutes.\n"
    );

    Console.WriteLine ("Type '1' and then hit enter to start the timer.\n");
    string key = Console.ReadLine ();

    if (key == "1") { // if start
      stopwatch.Start ();

      while (stopwatch.Elapsed < TimeSpan.FromSeconds (program.inputN)) { // while loop
        Console.WriteLine (
            "You have " + (program.inputN - Math.Floor (stopwatch.Elapsed.TotalSeconds)) + " seconds left."
        );
      } // end of while loop
      stopwatch.Stop ();

      Console.WriteLine ("\nYour timer is up!");
    } // end of if start

     else { // else
       Console.WriteLine ("\nYou did not type '1'. Please try again.");
     } // end of else
   } // end of TimerWhole
  
 public static void Main (string[] args) // Main___
 {
  Console.WriteLine (
    "Would you like a timer with decimal points or only the whole numbers of the seconds? Type 1 for decimal timer and 2 for whole number timer, then hit enter, thank you!\n"
  );
  string whichTimer = Console.ReadLine ();

  if (whichTimer == "1") { // if decimal
    Program program = new Program ();
    program.TimerDecimal (args);
  } // end of if decimal

  else if (whichTimer == "2") { // if whole number
    Program program = new Program ();
    program.TimerWhole (args);
  } // end of if whole number

  else { // else
    Console.WriteLine ("\nYou did not type '1' or '2'. Please try again.");
  } // end of else
 } // end of if decimal // end of Main
}