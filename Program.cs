using System;


namespace Test1
{
    class Program
    {
        static void Main()
        {
            System.Int64 Ta = Int64.Parse(Console.ReadLine());
            System.Int64[] Ti = new Int64[Ta];
            int[] count = new int[Ta];


            for (int i=0;i<Ta;i++)
            {
                Ti[i] = Int64.Parse(Console.ReadLine());
                string num = Ti[i].ToString();                
                int ln = num.Length;
                string[] num1 = new string[ln];
                for (int j=0;j<ln;j++)
                {
                    num1[j] = num.Substring(j, 1);
                    if (num1[j] == "4")
                        count[i] = count[i] + 1;
                }

            }

            for (int i=0;i<Ta;i++)
            {
                Console.WriteLine(count[i]);
            }


        }
    }
}
