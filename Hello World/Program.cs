using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling method
            // Console.WriteLine("Hello World");

            //declared a variable message. String is datatype

            //part one greeting statement

            //  String messageOne = "Hello  World";
            String messageTwo = "I am Spartacus";

            ////part two set intial spartacus attributes

            int ageOne = 35;
            int ageTwo = 45;
            int ageThree = 80;
            double heightOne = 72.50;
            double heightTwo = 91.45;
            float weightOne = 210.0284606f;
            float weightTwo = 331.12345678f;
            bool isGodLikeOne = true;
            bool isGodLikeTwo = false;
            char genderMale = 'M';
            char genderFemale = 'F';

            ////part three display variable values

            //Console.WriteLine(messageOne);// display intial greeting to console
            //Console.WriteLine(messageTwo);

            ////part four mathematical operator,bool and char examples

            //Console.WriteLine(ageOne + ageTwo);

            ////part five variable reaassignment

            //ageTwo = 70;

            ////part six matematical operator examples

            //Console.WriteLine(ageOne + ageTwo);

            //Console.WriteLine(heightOne - heightTwo);
            //heightTwo = 35.12345;

            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);

            //weightTwo = -429.1234573f;
            //Console.WriteLine(weightOne / weightTwo);

            //Console.WriteLine(isGodLikeOne);
            //Console.WriteLine(genderMale);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            //part seven increment and decrement operator examples

            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);
            //Console.WriteLine(5 == 5);
            //Console.WriteLine(40 != 40);
            //Console.WriteLine(11 < 4);

            //part eight concatination example

            /* Console.WriteLine(messageOne + " " + messageTwo + ".");
             Console.WriteLine("I am " + ageOne + "and yes it's " + isGodLikeOne + " I am godlike");
             Console.WriteLine("I am around " + weightOne + " pounds" + " and I am around " + heightOne + " inches tall");
             //using index in Array
             Console.WriteLine("I am {0} years old and yes it's {1} I am godlike.", ageOne, isGodLikeOne);
             Console.WriteLine("I am around {0} pounds and i am arounf {1} inches tall", weightOne, heightOne);*/

            //part nine string equlity examples

            /*Console.WriteLine(messageOne.Equals(messageTwo));//messageOne.Equals() is a method.equal method
            Console.WriteLine(messageTwo.Equals("I am Spartacus"));
        
            // .ToUpper() and .ToLower() method
           String myGreetings = "Hello";
            Console.WriteLine(myGreetings.ToUpper());
            Console.WriteLine(myGreetings.ToLower());
            Console.WriteLine(myGreetings);*/

            //part Ten string length examples .lenght method

            //int messageOneLength = messageOne.Length;
            //int messageTwoLength = messageTwo.Length;
            //Console.WriteLine( "The length of messageOne is"+messageOne.Length );
            //Console.WriteLine("The length of messageTwo is" + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is" + messageOneLength);
            //Console.WriteLine("The length of messageTwo is" + messageTwoLength);

            //Part eleven conditional example

            //String city1 = "vesuvius";
            //String city2 = "Nola";
            //String city3 = "Nuceria";
            //int city1distance, city2distance, city3distance;

            ////solicit user input example
            //Console.WriteLine("what is your distance{0}",city1);
            //city1distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("what is the distance to"+city2+"?");
            // city2distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("what is the distace to nuceria");
            // city3distance = int.Parse(Console.ReadLine());
            //if((city1distance<=125)&& ((city1distance < city2distance)&& (city1distance < city3distance)))
            //{
            //     Console.WriteLine("we will march to vesuvius");
            //  }
            // if ((city2distance <= 125) && ((city2distance < city1distance) && (city2distance < city3distance)))
            // {
            // Console.WriteLine("we will march to Nola");
            // }
            // if ((city3distance <= 125) && ((city3distance < city1distance) && (city3distance < city1distance)))
            // {
            //     Console.WriteLine("we will march to Nuceria");
            //   }
            //part twelve if else statement

            //Console.WriteLine("What is your rank solider");
            //String rank = Console.ReadLine();
            //String rank1 = rank.ToLower();
            //Console.WriteLine("What is your age");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("what is your job");
            // String job = Console.ReadLine();

            //if((rank1=="officer") || (age<=26))
            //    {
            //    Console.WriteLine("Get your gear ,kiss goodbye,put on your marching boots");

            //}
            //else if((job=="cook") ||(age>=26))
            //    {
            //    Console.WriteLine("my army has to eat. pack your pots and pans");
            //}
            //else{
            //    Console.WriteLine("sorry, you are staying home");
            //}

            //part 13

             string[] foodList = new string[5];
             foodList[0] = "milk";
             foodList[1] = "fruit";
             foodList[2] = "meat";
             foodList[3] = "wine";
             foodList[4]="bread";
           //  Console.WriteLine("{0}, {1} ,{2} ,{3}, {4}",foodList[0],foodList[1],foodList[2],foodList[3],foodList[4]);
            // Console.WriteLine(foodList.Length);

             int[] foodAmount = new int[5];
             foodAmount[0] = 1000;
             foodAmount[1] = 100;
             foodAmount[2] = 2000;
             foodAmount[3] = 10000;
             foodAmount[4] = 1500;
           //  Console.WriteLine("{0},{1},{2},{3},{4}", foodAmount[0],  foodAmount[1], foodAmount[2], foodAmount[3], foodAmount[4]);
            // Console.WriteLine(foodList[0] +":"+foodAmount[0]+" "+ foodList[1]+":"+ foodAmount[1]+" "+ foodList[2]+":"+ foodAmount[2]+" "+ foodList[3]+":"+ foodAmount[3]+" "+ foodList[4]+":"+ foodAmount[4]);

           //  String[] element = messageTwo.Split(' ');
          //   Console.WriteLine(element[0]);//print I
            // Console.WriteLine(element[1]);//Print Am
           //  Console.WriteLine(element[2]);//Print Spartcus

             //String myName = "sue";
            // Char[] letters = myName.ToCharArray();
           //  Console.WriteLine("{0},{1},{2}", letters[0], letters[1], letters[2]);
             //Console.Write(letters[0]);
            // Console.Write(letters[1]);
            // Console.WriteLine(letters[2]);

            /* switch (job)
             { 


                 case "infantry":
                     Console.WriteLine("you will carry a sword");
                     break;

                 case "archers":
                     Console.WriteLine("you will  a bow and arrow");
                     break;

                 case "supply":
                     Console.WriteLine("you will carry pots and pan");
                     break;

                 case "specalist":
                     Console.WriteLine("you will operate the capital");
                     break;

                 default:
                     Console.WriteLine("you will ride horseback");
                     break;
             }*/


            // Part 13 loops(while)and do while()
          /*  string action = " ";
            while (action != "exit")
            {
                Console.WriteLine("What is your rank soldier?");
                string rank = Console.ReadLine();
                Console.WriteLine("What is your age soldier?");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your job soldier?");
                string job = Console.ReadLine();

                if ((rank == "officer") || (age <= 26))
                {
                    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
                }
                else if ((job == "cook") || (age >= 26))
                {
                    Console.WriteLine("My army has to eat. Pack your pots and pans");
                }
                else
                {
                    Console.WriteLine("Sorry you are staying home.");
                }
                Console.WriteLine("Add another? Type exit to quit");
                action = Console.ReadLine();
            }*/

          /*  string action = " ";
            do
            {
                Console.WriteLine("What is your rank soldier?");
                string rank = Console.ReadLine();

                Console.WriteLine("What is your age soldier?");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your job soldier?");
                string job = Console.ReadLine();

                if ((rank == "officer") || (age <= 26))
                {
                    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
                }
                else if ((job == "cook") || (age >= 26))
                {
                    Console.WriteLine("My army has to eat. Pack your pots and pans");
                }
                else
                {
                    Console.WriteLine("Sorry you are staying home.");
                }
                Console.WriteLine("Add another? Type exit to quit");
                action = Console.ReadLine();
            } 
            while (action != "exit");*/

    //Part 14 for loop

          /*  for(int i = 0; i < foodAmount.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(foodAmount[i]);
                Console.WriteLine("please enter the amount for "+foodList[i]);
                foodAmount[i] =int.Parse (Console.ReadLine());
                Console.WriteLine(foodAmount[i]);
            }*/

   //nested loops

         /*   int size = 5;    //Equals the max number of columns and rows
            int i, k;
            for (i = 0; i <= size; i++)
            {
                for (k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();*/

           /* int sum = 1;
            for (int i = 0; i <= 10; i++)
            {
                sum = sum + 1;
            }
            Console.WriteLine(sum);

            int sum = 1;
            for (int i = 0; i <= 10; i++)
            {
                sum = sum * 3;
            }
            Console.WriteLine(sum);
            for (int i = 0; i <= 10; i++)
            {
                sum *= 3;
            }
            Console.WriteLine(sum);

            for (int i = 0; i <= 10; i++)
            {
                sum += 3;
            }
            Console.WriteLine(sum);*/

   






        }

    }
}
