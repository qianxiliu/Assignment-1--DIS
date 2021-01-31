using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            Console.WriteLine("Q1 : Enter the number of rows for the traingle:");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintTriangle(n);
            Console.ReadKey();


            //Q2
            Console.WriteLine("\nQ2 : Enter the number of terms in the Pell Series:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            printPellSeries(n2);
            Console.WriteLine();

            //Q3
            Console.WriteLine("\nQ3 : Enter the number to check if squareSums exist:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            bool flag = squareSums(n3);
            if (flag)
            {
                Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
            }
            else
            {
                Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
            }

            Console.ReadKey();

            //Q4
            int[] arr = { 3, 1, 4, 1, 5 };
            Console.WriteLine("\nQ4 : Enter the absolute difference to check");
            int k = Convert.ToInt32(Console.ReadLine());
            int n4 = diffPairs(arr, k);
            Console.WriteLine("There exists {0} pairs with the given difference", n4);
            Console.ReadKey();

            //Q5
            List<string> emails = new List<string>();
            emails.Add("dis.email+ bull@usf.com");
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail+david@us.f.com");
            int ans5 = UniqueEmails(emails);
            Console.WriteLine("\nQ5 :");
            Console.WriteLine("The number of unique emails is " + ans5);
            Console.ReadKey();

            //Q6
            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                        { "Delhi", "London" } };
            //List<string> destination = new List<string>();
            string destination = DestCity(paths);
            Console.WriteLine("\nQ6 :");
            Console.WriteLine("Destination city is " + destination);
            Console.ReadKey();


        }

        //Question 1 

        //It takes 3 hours to find out the relationship between space and "*" and how to control the count of lines in the for loop.
        //It takes more time in setting up the environment, finding out how to use Main and Private and print the result correctly.
        //But I think it serves as a pretty good starter for me to have deep understanding of main program and it's function call.

        private static void PrintTriangle(int n)//create a new method which invoke by the method PrintPattern
        {


            try
            {
                int i, j, k;



                for (i = 1; i <= n; i++)
                {
                    for (j = n; j >= i; j--)//space is decreasing
                    {
                        Console.Write(" ");//number of space of " " before the "*"
                    }

                    for (k = 1; k <= (2 * i - 1); k++)//"*" is increasing
                    {
                        Console.Write("*");//number of "*"
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 2

        //It takes 6 hours to solve the problem, I first tried to solve it by using array, but it cannot print as int n2 
        //therefore I tried to solve it by reassigning variable value using while loop
        //At first time I forgot to consider the condition of n2== 1 or n2 == 2, when I tried to running the program, the problem showed itself.
        //It reminds me to think more thoroughtly in the future.

        private static void printPellSeries(int n2)
        {
            try
            {

                int temp = n2 - 2;//Length is n2 minus 0 and 1
                if (n2 <= 2)
                {
                    if (n2 == 1)
                        Console.Write("0");
                    if (n2 == 2)
                        Console.Write("0 1");
                }
                else
                    Console.Write("0 1 ");//To make sure print first two numbers with space.


                int firstNum = 1;
                int SecondNum = 0;// define the number before the first Num

                while (temp > 0)

                {
                    int n = firstNum * 2 + SecondNum;
                    Console.Write(n + " ");//Print the last one in the array
                    temp -= 1;
                    SecondNum = firstNum;//Reassign
                    firstNum = n;//Reassign

                }
                Console.ReadKey();


            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 3

        //It takes 6 hours to solve the problem and I learn how to write if statement with boolean and loop statement for nested structures.
        //If bool meet the condition then return ture and it will reflect in the main program as flag equals true.

        private static bool squareSums(int n3)
        {
            try
            {
                for (long i = 0; i * i <= n3; i++)

                    for (long j = 0; j * j <= n3; j++)//Nested loop

                        if (i * i + j * j == n3)//To decide if n3 to meet the condition
                        {
                            return true;

                        }

                return false;



            }

            catch (Exception)
            {

                throw;
            }
        }


        //Question 4

        //It takes 6 hours to solve the problem and I learn how to define array and count counts in for loop and if statement.
        //Except that, I occoured to some exception problems and file couldn't load in the debugging process.
        //I tried to modified with microsoft packages and download dotnet, it seems work fine but couldn't sure if i solve this problem completely.

        private static int diffPairs(int[] nums, int k)
        {
            try
            {
                int count = 0;
                // search array
                for (int i = 0; i < nums.Length; i++)//get length

                    for (int j = i + 1; j < nums.Length; j++)

                        if (nums[i] - nums[j] == k || nums[j] - nums[i] == k)//decide if absolute difference in array equals to k

                        {
                            count++;//count counts
                        }


                return count;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }


        //Question 5

        //It takes me 7 hours to learn string variables and list & split method
        //Also, I find that HashSet is really useful and convenient, it can save the variables and doesn't maintains the order

        private static int UniqueEmails(List<string> emails)
        {
            try

            {
                var h = new HashSet<string>();

                foreach (var e in emails)
                {
                    var p = e.Split('@');//split the email with the part before and after @
                    var t = p[0].Split('+')[0].Replace(".", string.Empty);//with the first part, split it again with +, remove part after + and replace"." with empty
                    h.Add($"{t}@{p[1]}");//adding new part 0 with part 1
                    //Console.Write(t);//Using this to try find out what is wrong when the result is not correct
                }

                return h.Count;//count counts
            }

            catch (Exception)
            {

                throw;
            }
        }

        //Question 6

        //It takes 6 hour to solve the problem and I learn how to traverse an array
        //It looks like following--
        // 0 1  2  3
        // 1 L  NY D
        // 2 NY T  L
        //We need to find out the destination which can't be the first one and only be the last one in each path
        

        private static string DestCity(string[,] paths)
        {

            try
            {

                for (int j = 0; j < paths.GetLength(0); j++)
                {
                    int d = 0;

                    for (int i = 0; i < paths.GetLength(0); i++)
                    {
                        if (paths[i, 0] == paths[j, 1])// check if it is match with [j,1]
                        {
                            d = 1;
                            break;// if find the match, then continue to find the next city in the path
                        }
                    }
                   
                    if (d == 0)
                    {
                        return paths[j, 1];//Get the destination
                    }
                }
                return "";


            }
            catch (Exception)
            {

                throw;
            }

        }
    }

}

