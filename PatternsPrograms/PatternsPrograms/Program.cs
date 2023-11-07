namespace PatternsPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //problem1(4);
            //problem2(4);
            //problem3(5);
           // problem4(5);
           // problem5(5);
            // problem6(5);
            //problem7(5);
            //problem8(5);
           // problem9(5);
            //problem10(5);
            //problem11(5);
            //problem12(5);
            //problem13(5);
            problem14(5);
        }

        public static void problem1( int a)
        {
            for(int row = 1; row <= a; row++)
            {
                for(int col = 1; col <= row; col++)
                {
                    Console.Write(row);

                }
                Console.WriteLine();
            }
            
        }
        /*  1
            22
            333
            4444*/
        public static void problem2(int a)
        {
            for (int row = 1; row <= a; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col);

                }
                Console.WriteLine();
            }

        }

        /*1
          12
          123
          1234
        */

        public static void problem3(int a)
        {
            int count=1;
            for (int row = 1; row <= a; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(count+" ");
                    count++;
                }
                Console.WriteLine();
            }

        }

        /*1
          2 3
          4 5 6
          7 8 9 10
          11 12 13 14 15*/

        public static void problem4(int a)
        {
            int count = 1;
            for (int row = 1; row <= a; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(count + " ");
                    
                }
                Console.WriteLine();
            }

        }

        /*1
          1 1
          1 1 1
          1 1 1 1
          1 1 1 1 1 */


        public static void problem5(int a)
        {
            
            for (int row = 1; row <= a; row++)
            {
                for (int col = row; col>= 1; col--)
                {
                    Console.Write(col + " ");

                }
                Console.WriteLine();
            }

        }

        /*1
          2 1
          3 2 1
          4 3 2 1
          5 4 3 2 1 */

        public static void problem6(int a)
        {

            for (int row = a; row >= 1; row--)
            {
                for (int col = row; col <= a; col++)
                {
                    Console.Write(col + " ");

                }
                Console.WriteLine();
            }

        }

        /*5
          4 5
          3 4 5
          2 3 4 5
          1 2 3 4 5 */

        public static void problem7(int a)
        {

            for (int row = a; row >= 1; row--)
            {
                for (int col = row; col <= a; col++)
                {
                    Console.Write(row + " ");

                }
                Console.WriteLine();
            }

        }
        /*
           5
           4 4
           3 3 3
           2 2 2 2
           1 1 1 1 1
         */

        public static void problem8(int a)
        {

            for (int row = a; row >= 1; row--)
            {
                for (int col = a; col >=row; col--)
                {
                    Console.Write(col + " ");

                }
                Console.WriteLine();
            }

        }
        /*  5
            5 4
            5 4 3
            5 4 3 2
            5 4 3 2 1 */

        public static void problem9(int a)
        {

            for (int row = 1; row <=a ; row++)
            {
                for (int col = a; col >= row; col--)
                {
                    Console.Write(col + " ");

                }
                Console.WriteLine();
            }

        }


        /*  5 4 3 2 1
            5 4 3 2
            5 4 3
            5 4
            5  */

        public static void problem10(int a)
        {

            for (int row = a; row >=1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");

                }
                Console.WriteLine();
            }

        }

        /*  5 5 5 5 5
            4 4 4 4
            3 3 3
            2 2
            1 
        */

        public static void problem11(int a)
        {

            for (int row = 1; row <=a ; row++)
            {
                for (int col = a; col >= row; col--)
                {
                    Console.Write(col + " ");

                }
                Console.WriteLine();
            }

        }
        /*  5 4 3 2 1
            5 4 3 2
            5 4 3
            5 4
            5  */

        public static void problem12(int a)
        {

            for (int row = 1; row <= a; row++)
            {
                for (int col = a; col >= row; col--)
                {
                    Console.Write(row + " ");

                }
                Console.WriteLine();
            }

        }

        /*  1 1 1 1 1
            2 2 2 2
            3 3 3
            4 4
            5 */

        public static void problem13(int a)
        {

            for (int row = a; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");

                }
                Console.WriteLine();
            }

        }
        /*  1 2 3 4 5
            1 2 3 4
            1 2 3
            1 2
            1 */

        public static void problem14(int a)
        {

            for (int row = 1; row <=a ; row++)
            {
                for (int col = row; col <= a; col++)
                {
                    Console.Write(col + " ");

                }
                Console.WriteLine();
            }

        }

        /*
         *  1 2 3 4 5
            2 3 4 5
            3 4 5
            4 5
            5  */
    }
}