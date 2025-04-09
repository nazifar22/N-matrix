using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace oop_nazifa
{
    public class Menu
    {
        class negativeException : Exception { };
        class differentException : Exception { };
        class notnumberException : Exception { };
        class incorrectInputException : Exception { };
        private List<List<int>> matrix;
        public Menu() { }

        public void Run()
        {
            //m1
            int size = 0;
            int size2 = 0;
            int size3 = 0;

            bool tempvalue = false;
            while (!tempvalue)
            {
                try
                {
                    Console.Write("Size of matrix 1 and matrix 2: ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out size)) { throw new notnumberException(); }
                    if (size < 0) { throw new negativeException(); }
                    size = int.Parse(input);
                    tempvalue = true;
                }
                catch (negativeException)
                {
                    Console.WriteLine("Incorrect matrix size. Matrix cannot be negative.");
                    //return;
                }
                catch (notnumberException)
                {
                    Console.WriteLine("Incorrect input type. Has to be a (positive natural) number.");
                   //return;
                }
            }
            int[] first = new int[size];
            int[] second = new int[size];
            int[] third = new int[size];
            string[] secondaryTemp;
            string[] thirdTemp;
            string[] original;

            int[] resFirst = new int[size];
            int[] resSecond = new int[size];
            int[] resThird = new int[size];

            bool tempvalue1 = false;
            while(!tempvalue1)
            {
                try
                {
                    Console.WriteLine($"Enter {size} elements in diagonal, only separated by ',':");
                    original = Console.ReadLine().Split(',');
                    if (!(original.Length == size)) { throw new incorrectInputException(); }
                    else if (original.Length == size)
                    {
                        for (int i = 0; i < size; i++)
                        {
                            if (!int.TryParse(original[i], out size2)) { throw new notnumberException(); }
                            first[i] = int.Parse(original[i]);
                            second[i] = int.Parse(original[i]);
                            third[i] = int.Parse(original[i]);
                            tempvalue1 = true;
                        }
                    }
                }
                catch (incorrectInputException)
                {
                    Console.WriteLine("Incorrect input. Has to be the same length as stated above.");
                    //return;
                }
                catch (notnumberException)
                {
                    Console.WriteLine("Incorrect input. Has to be an integer number.");
                    //return;
                }
            }

            if (size == 1)
            {
                second = first;
            }
            else
            {
                bool tempvalue2 = false;
                while (!tempvalue2)
                {
                    try
                    {
                        Console.WriteLine($"Enter {size - 1} elements in the first coloumn (from the second number, as the first number is given when you gave the diagonal input), only seperated by ',':");
                        secondaryTemp = Console.ReadLine().Split(',');
                        if (!(secondaryTemp.Length == size - 1)) { throw new incorrectInputException(); }
                        else if (secondaryTemp.Length == size - 1)
                        {
                            int count = 0;
                            for (int i = 1; i < size; i++)
                            {
                                if (!int.TryParse(secondaryTemp[count], out size2)) { throw new notnumberException(); }
                                second[i] = int.Parse(secondaryTemp[count]);
                                count += 1;
                                tempvalue2 = true;
                            }
                        }
                    }
                    catch (incorrectInputException)
                    {
                        Console.WriteLine("Incorrect input. Has to be the same length as stated above.");
                       //return;
                    }
                    catch (notnumberException)
                    {
                        Console.WriteLine("Incorrect input. Has to be a (positive natural) number.");
                        //return;
                    }
                }
                bool tempvalue3 = false;
                while (!tempvalue3)
                {
                    try
                    {
                        Console.WriteLine($"Enter {size - 1} elements in the last coloumn (apart from the last number, as the last number is given when you gave the diagonal input), only seperated by ',':");
                        thirdTemp = Console.ReadLine().Split(',');
                        if (!(thirdTemp.Length == size - 1)) { throw new incorrectInputException(); }
                        else if (thirdTemp.Length == size - 1)
                        {
                            int count2 = 0;
                            for (int i = 0; i < size - 1; i++)
                            {
                                if (!int.TryParse(thirdTemp[count2], out size3)) { throw new notnumberException(); }
                                third[i] = int.Parse(thirdTemp[count2]);
                                count2 += 1;
                                tempvalue3 = true;
                            }
                        }
                    }
                    catch (incorrectInputException)
                    {
                        Console.WriteLine("Incorrect input. Has to be the same length as stated above.");
                        //return;
                    }
                    catch (notnumberException)
                    {
                        Console.WriteLine("Incorrect input. Has to be a (positive natural) number.");
                        //return;
                    }
                }
            }
            try
            {
                if (second.Length != first.Length || third.Length != second.Length || third.Length != first.Length)
                {
                    Console.WriteLine("Diagonal, first coloumn and last coloumn cannot be different lengths.");
                    throw new differentException();
                }
            }
            catch(incorrectInputException)
            {
                Console.WriteLine("The lengths of diagonal, first coloumn and last coloumn are not the same");
                return;
            }

            Matrix m1 = new Matrix(size, first, second, third);

            //m2
            int size2m2 = 0;
            int size3m2 = 0;

            int[] first2 = new int[size];
            int[] second2 = new int[size];
            int[] third2 = new int[size];
            string[] secondaryTemp2;
            string[] thirdTemp2;
            string[] original2;
            bool tempvalue4 = false;
            Console.WriteLine("\n**********");
            Console.WriteLine("\nMatrix 2");
            Console.WriteLine("\n**********");
            while (!tempvalue4)
            {
                try
                {
                    Console.WriteLine($"Enter {size} elements in diagonal, only separated by ',':");
                    original2 = Console.ReadLine().Split(',');
                    if (!(original2.Length == size)) { throw new incorrectInputException(); }
                    else if (original2.Length == size)
                    {
                        for (int i = 0; i < size; i++)
                        {
                            if (!int.TryParse(original2[i], out size2m2)) { throw new notnumberException(); }
                            first2[i] = int.Parse(original2[i]);
                            second2[i] = int.Parse(original2[i]);
                            third2[i] = int.Parse(original2[i]);
                            tempvalue4 = true;
                        }
                    }
                }
                catch (incorrectInputException)
                {
                    Console.WriteLine("Incorrect input. Has to be the same length as stated above.");
                    //return;
                }
                catch (notnumberException)
                {
                    Console.WriteLine("Incorrect input. Has to be a (positive natural) number.");
                    //return;
                }
            }
            if (size == 1)
            {
                second2 = first2;
            }
            else
            {
                bool tempvalue5 = false;
                while (!tempvalue5)
                {
                    try
                    {
                        Console.WriteLine($"Enter {size - 1} elements in the first coloumn (from the second number, as the first number is given when you gave the diagonal input), only seperated by ',':");
                        secondaryTemp2 = Console.ReadLine().Split(',');
                        if (!(secondaryTemp2.Length == size - 1)) { throw new incorrectInputException(); }
                        else if (secondaryTemp2.Length == size - 1)
                        {
                            int count = 0;
                            for (int i = 1; i < size; i++)
                            {
                                if (!int.TryParse(secondaryTemp2[count], out size3m2)) { throw new notnumberException(); }
                                second2[i] = int.Parse(secondaryTemp2[count]);
                                count += 1;
                                tempvalue5 = true;
                            }
                        }
                    }
                    catch (incorrectInputException)
                    {
                        Console.WriteLine("Incorrect input. Has to be the same length as stated above.");
                        //return;
                    }
                    catch (notnumberException)
                    {
                        Console.WriteLine("Incorrect input. Has to be a (positive natural) number.");
                        //return;
                    }
                }

                bool tempvalue6 = false;
                while (!tempvalue6)
                {
                    try
                    {
                        Console.WriteLine($"Enter {size - 1} elements in the last coloumn (apart from the last number, as the last number is given when you gave the diagonal input), only seperated by ',':");
                        thirdTemp2 = Console.ReadLine().Split(',');
                        if (!(thirdTemp2.Length == size - 1)) { throw new incorrectInputException(); }
                        else if (thirdTemp2.Length == size - 1)
                        {
                            int count2 = 0;
                            for (int i = 0; i < size - 1; i++)
                            {
                                if (!int.TryParse(thirdTemp2[count2], out size3m2)) { throw new notnumberException(); }
                                third2[i] = int.Parse(thirdTemp2[count2]);
                                count2 += 1;
                                tempvalue6 = true;
                            }
                        }
                    }
                    catch (incorrectInputException)
                    {
                        Console.WriteLine("Incorrect input. Has to be the same length as stated above.");
                        //return;
                    }
                    catch (notnumberException)
                    {
                        Console.WriteLine("Incorrect input. Has to be a (positive natural) number.");
                        //return;
                    }
                }
            }

            if (second2.Length != first2.Length || third2.Length != second2.Length || third2.Length != first2.Length)
            {
                Console.WriteLine("Diagonal, first coloumn and last coloumn cannot be different lengths.");
                throw new differentException();
            }

            Matrix m2 = new Matrix(size, first2, second2, third2);
            Matrix mR = new Matrix(size, resFirst, resSecond, resThird);
            bool tempvalue7 = false;
            int temp0 = 0;
            while (!tempvalue7)
            {
                try
                {
                    Console.WriteLine("1. Get the entry value at the specific index");
                    Console.WriteLine("2. Add 2 matrices");
                    Console.WriteLine("3. Multiply 2 matrices");
                    Console.WriteLine("4. Print the matrix");

                    string inputtemp0 = Console.ReadLine();

                    if (!int.TryParse(inputtemp0, out temp0)) { throw new notnumberException(); }
                    if (temp0 < 0) { throw new negativeException(); }

                    temp0 = int.Parse(inputtemp0);
                    if (temp0 >= 1 && temp0 <= 4) { tempvalue7 = false; }

                    switch (temp0)
                    {
                        case 1:
                            try
                            {
                                int temp2 = 0;
                                string inputtemp = "";
                                Console.Write("Choose matrix (1) or (2): ");
                                inputtemp = Console.ReadLine();

                                if (!int.TryParse(inputtemp, out temp2)) { throw new notnumberException(); }
                                if (temp2 < 0) { throw new negativeException(); }
                                temp2 = int.Parse(inputtemp);
                                switch (temp2)
                                {
                                    case 1: GetValue(m1); break;
                                    case 2: GetValue(m2); break;
                                }
                            }
                            catch (notnumberException)
                            {
                                Console.WriteLine("Incorrect input. Has to be a either 1 or 2.");
                                return;
                            }
                            break;
                        case 2:
                            GetAddition(size, m1, m2, mR);
                            break;
                        case 3:
                            GetMultiply(size, m1, m2, mR);
                            break;
                        case 4:
                            Console.Write("Print matrix (1) or matrix (2): ");
                            int temp3 = int.Parse(Console.ReadLine());
                            switch (temp3)
                            {
                                case 1:
                                    GetPrint(m1);
                                    break;
                                case 2:
                                    GetPrint(m2);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Wrong input.");
                            break;
                    }
                }
                catch (negativeException)
                {
                    Console.WriteLine("Incorrect input. Cannot be negative.");
                    //return;
                }
                catch (notnumberException)
                {
                    Console.WriteLine("Incorrect input. Has to be a (positive natural) number between 1 and 4 inclusive");
                    //return;
                }
            }
        }

        static private void GetPrint(Matrix m)
        {
            m.PrintMatrix();
        }

        public static void GetValue(Matrix m)
        {
            Console.Write("Enter row index: ");
            int rowIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter column index: ");
            int colIndex = int.Parse(Console.ReadLine());

            int value = m.GetValue(rowIndex, colIndex);
            Console.WriteLine("Value at index [{0}, {1}] is {2}\n\n\n", rowIndex, colIndex, value);
        }

        public static void GetAddition(int size, Matrix m1, Matrix m2, Matrix mR)
        {
            Console.WriteLine("Matrix 1:");
            m1.PrintMatrix();

            Console.WriteLine("Matrix 2:");
            m2.PrintMatrix();

            mR = m1.Add(m2);
            Console.WriteLine("Matrix 1 + Matrix 2:");
            mR.PrintMatrix();
        }

        public static void GetMultiply(int size, Matrix m1, Matrix m2, Matrix mR)
        {
            Console.WriteLine("Matrix 1:");
            m1.PrintMatrix();

            Console.WriteLine("Matrix 2:");
            m2.PrintMatrix();

            mR = m1.Multiply(m2);
            Console.WriteLine("Matrix 1 * Matrix 2:");
            mR.PrintMatrix();
        }
    }
}
