// using System;
//
// class RatedR
// {
//     static void Main()
//     {
//         Console.WriteLine("How old are you?");
//         string stringUserAge = Console.ReadLine();
//         int intUserAge = int.Parse(stringUserAge);
//
//         if (intUserAge >= 17)
//         {
//             Console.WriteLine("You can see the movie!");
//         }
//         else
//         {
//             Console.WriteLine("I'm sorry, you are too young to see the movie.");
//         }
//     }
// }
using System;
class ToKnowAge
{
  static void Main()
  {
    Console.WriteLine("what is your age?");
    string inputAge = Console.ReadLine();
    int convertedAge  = int.Parse(inputAge);
    if (convertedAge <=17)
    {
      Console.WriteLine("you will see the movie on Sunday");

    }
    else
    {
      Console.WriteLine("I am sorry you can only see the movie other days");
    }
  }


}
