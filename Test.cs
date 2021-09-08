
using System;
using System.Numerics;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int Reports = int.Parse(Console.ReadLine());
        string[] result = new string[Reports];
        

        for(int i=0;i<Reports;i++)
        {
            
            int ln = int.Parse(Console.ReadLine());
            int count=0;
            string[] test = new string[ln];
            string tests = Console.ReadLine();


            bool snake=true;

            for(int j=0;j<tests.Length;j++)
            {
                test[j] = tests.Substring(j, 1);
                if (test[j] == "H" || test[j] == "T")
                    count++;
            }

            if (count == 0)
                snake = true;
            else if (count % 2 != 0)
                snake = false;   
            else if(count%2==0)
            {
                int? Hindx=null , Tindx=null ;
                for (int k=0;k<test.Length;k++)
                {
                    test[k] = tests.Substring(k, 1);
                    if (test[k] == "H")
                    {
                        if (Hindx != null && k != 0)
                        {      
                            snake = false; break;
                        }
                        Hindx = k;
                    }

                    else if (test[k] == "T")
                    {
                        if (Tindx != null && k != 0)
                        {      
                            snake = false; break;
                        }
                        Tindx = k;
                    }

                    if (Hindx < Tindx)
                    {
                        Hindx = null; Tindx = null;
                        snake = true;
                    }
                    else if (Hindx > Tindx && Tindx!=null)
                    {
                        snake = false;
                        break;
                    }

                }
                
            }
            result[i] = snake == true ? "Valid" : "Invalid";


        }

        for (int j = 0; j < Reports; j++)
            Console.WriteLine(result[j]);
    }
  
}
