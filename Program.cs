using System.Drawing;


namespace assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("please enter an integer number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i = 1; i < number; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("please enter an integer number:  ");
            //int.TryParse(Console.ReadLine() , out int number);
            //int count = 12;
            //for (int i = 1; i <= count; i++) {
            //    Console.WriteLine($"{number} * {i} = {i* number}");

            //}

            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("please enter an integer number: ");
            //int.TryParse(Console.ReadLine() , out int number);

            //    for (int i = 1; i <= number; i++)
            //    {
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    }

            #endregion

            #region 4- Write a program that takes two integers then prints the power.

            //Console.Write("please enter first enteger number: ");
            //int.TryParse(Console.ReadLine(), out var num1);
            //Console.Write("please enter power: ");
            //int.TryParse(Console.ReadLine(), out var power);
            //int result = 1;
            //for (int i = 1; i <= power; i++)
            //{
            //    result *= num1;
            //}
            //Console.WriteLine(result);
            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.Write("first subject: ");
            //int.TryParse(Console.ReadLine(), out int first );
            //Console.Write("second subject: ");
            //int.TryParse(Console.ReadLine(), out int second);
            //Console.Write("third subject: ");
            //int.TryParse(Console.ReadLine(), out int third);
            //Console.Write("forth subject: ");
            //int.TryParse(Console.ReadLine(), out int forth);
            //Console.Write("fifth subject: ");
            //int.TryParse(Console.ReadLine(), out int fifth);

            //double total = first + second + third + forth + fifth;
            //double average = total / 5 ;
            //double percentage = (total / 5 )* 1 ;
            //Console.WriteLine(total);
            //Console.WriteLine(average);
            //Console.WriteLine($"{percentage}%");
            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("please enter string: ");
            //    string name = Console.ReadLine();
            //string reversed = "";
            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    reversed += name[i];

            //}
            //Console.WriteLine(reversed);
            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("please enter an integer number : ");
            //string number = Console.ReadLine();
            //string reversed = " " ;
            //for (int i = number.Length -1; i >= 0; i--)
            //{
            //    reversed += number[i];
            //}
            //Console.Write(reversed);

            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //int num1 = 1;
            //int num2 = 50;
            //for (int i = num1; i <= num2; i++)
            //{
            //    if (i>1)
            //    {
            //        bool prime = true;
            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i% j == 0)
            //            {

            //                prime = false;
            //                break;
            //            }
            //        }
            //        if (prime)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion

            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("enter a decimal number : ");
            //int.TryParse(Console.ReadLine(), out int decNumber);
            //string binNumber = " ";

            //if (decNumber == 0)
            //{                
            //    return;

            //}while (decNumber > 0)
            //{
            //    int dec = decNumber % 2;
            //    binNumber = dec.ToString() + binNumber;
            //    decNumber = decNumber / 2;

            //}
            //Console.WriteLine( binNumber );

            #endregion

            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.WriteLine("Enter the coordinates for the first point (x1, y1):");
            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates for the second point (x2, y2):");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates for the third point (x3, y3):");
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());
            //if ((x2 - x1) * (y3 - y1) == (y2 - y1) * (x3 - x1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}



            #endregion

            #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("please enter the size : ");
            //int.TryParse(Console.ReadLine(), out int number);

            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = 0; j < number; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }

            //}
            //Console.WriteLine();

            #endregion
            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] number = [1, 2, 3, 4, 5];
            //int sum = 0;
            //foreach (int i in number)
            //{
            //    sum += i;

            //}
            //Console.WriteLine($"sum = {sum}");

            #endregion

            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.Write("Enter the size of the arrays: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] ar1 = new int[size];
            //int[] ar2 = new int[size];
            //Console.WriteLine("Enter elements for the first array:");
            //for (int i = 0; i < size; i++)
            //{
            //    ar1[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter elements for the second array:");
            //for (int i = 0; i < size; i++)
            //{
            //    ar2[i] = int.Parse(Console.ReadLine());
            //}
            //int[] mergedAr = new int[2 * size];
            //int index = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    mergedAr[index++] = ar1[i];
            //    mergedAr[index++] = ar2[i];
            //}
            //Array.Sort(mergedAr);
            //Console.WriteLine("Merged and sorted array:");
            //for (int i = 0; i < mergedAr.Length; i++)
            //{
            //    Console.Write(mergedAr[i] + " ");
            //}

            //Console.WriteLine();

            #endregion

            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("\nFrequency of each element:");

            //for (int i = 0; i < size; i++)
            //{
            //    if (array[i] != -1)
            //    {
            //        int count = 1;
            //        for (int j = i + 1; j < size; j++)
            //        {
            //            if (array[i] == array[j])
            //            {
            //                count++;
            //                array[j] = -1;
            //            }
            //        }
            //        Console.WriteLine($"Element {array[i]} appears {count} times.");
            //    }
            //}

            #endregion

            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] number = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            //int max = 0;
            //int min = 0;
            //foreach (int i in number)
            //{
            //    if (i > max)
            //    {
            //        max = i;
            //    }
            //    else
            //    {
            //        min = i;
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            #endregion

            #region 16- Write a program in C# Sharp to find the second largest element in an array.
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int largest = int.MinValue;
            //int secondLargest = int.MinValue;

            //for (int i = 0; i < size; i++)
            //{
            //    if (array[i] > largest)
            //    {
            //        secondLargest = largest;
            //        largest = array[i];
            //    }
            //    else if (array[i] > secondLargest && array[i] != largest)
            //    {
            //        secondLargest = array[i];
            //    }
            //}

            //if (secondLargest == int.MinValue)
            //{
            //    Console.WriteLine("There is no second largest element.");
            //}
            //else
            //{
            //    Console.WriteLine("The second largest element is: " + secondLargest);
            //}
            #endregion

            #region 17-. Consider an Array of Integer values with size N, having values as    
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int longestDistance = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > longestDistance)
            //            {
            //                longestDistance = distance;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("The longest distance between two equal cells is: " + longestDistance);

            #endregion

            #region 18- Given a list of space separated words, reverse the order of the words.
            //     Console.Write("Enter a list of space-separated words: ");
            //string name = Console.ReadLine();

            //int length = name.Length;
            //string word = "";
            //string[] words = new string[length];  

            //int wordCount = 0;

            //for (int i = 0; i < length; i++)
            //{
            //    if (name[i] != ' ')
            //    {
            //        word += name[i];
            //    }
            //    else if (word != "")
            //    {
            //        words[wordCount++] = word;
            //        word = "";
            //    }
            //}

            //if (word != "")
            //{
            //    words[wordCount++] = word;
            //}

            //Console.Write("Reversed words: ");
            //for (int i = wordCount - 1; i >= 0; i--)
            //{
            //    Console.Write(words[i]);
            //    if (i > 0)
            //        Console.Write(" ");
            //}

            //Console.WriteLine();
            #endregion

            #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns: ");
            //int columns = int.Parse(Console.ReadLine());
            //int[,] array1 = new int[rows, columns];
            //int[,] array2 = new int[rows, columns];

            //Console.WriteLine("Enter the values for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"Enter value for array1[{i},{j}]: ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}
            //Console.WriteLine("\nThe second array after copying the elements from the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region 20-Write a Program to Print One Dimensional Array in Reverse Order
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] array = new int[size];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("\nArray in reverse order:");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            #endregion

        }


    }

}






