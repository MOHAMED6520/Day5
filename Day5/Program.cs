namespace Day5
{
    internal class Program
    {
        #region Exception Handling And Protective Code
        //static void DoSomeCode()
        //{
        //    int x, y, z;
        //    x = int.Parse(Console.ReadLine());
        //    y = int.Parse(Console.ReadLine());
        //    z = x / y;
        //    int[] arr = { 1, 2, 3 };
        //    arr[99] = 10;
        //}

        //static void DoSomeCode()
        //{
        //    try
        //    {
        //        int x, y, z;
        //    x = int.Parse(Console.ReadLine());
        //    y = int.Parse(Console.ReadLine());
        //    z = x / y;
        //    int[] arr = { 1, 2, 3 };
        //    arr[99] = 10;
        //    }
        //    catch (Exception e)
        //    { 
        //        Console.WriteLine(e.Message); 
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Finally");
        //    }
        //}

        //static void DoSomeProtectiveCode()
        //{ 
        //    try {
        //int X, Y, Z;
        //    bool flag;
        //    do
        //    {
        //        Console.Write(" Enter First Number : ");
        //        flag = int.TryParse(Console.ReadLine(), out X);
        //    }
        //    while (!flag);

        //    do
        //    {
        //        Console.Write(" Enter First Number");

        //    }
        //    while (!int.TryParse(Console.ReadLine(), out Y)||Y==0);
        //    Z = X / Y;
        //    int[]arr = { 1, 2, 3 };
        //    if (99<arr.Length)
        //    {
        //        arr[99] = 10;
        //    }
        //    } catch (Exception e)
        //    { Console.WriteLine(e.Message); }
        //} 
        #endregion


        static void Main(string[] args)
        {
            #region 1.Boxing And UnBoxing
            //Boxing And UnBoxing

            //object o1;
            //o1=2;                 //Cast From ValueType [int] To ReferenceType [object]      Boxing
            //o1 = 1.5;             //Cast From ValueType [double] To ReferenceType [object]   Boxing
            //o1 = 'm';             //Cast From ValueType [char] To ReferenceType [object]     Boxing
            //o1 = true;            //Cast From ValueType [bool] To ReferenceType [object]     Boxing
            //o1 = new DateTime();  //Cast From ValueType [DateTime] To ReferenceType [object] Boxing


            //int x = 5;
            //object o1 = x;

            //// UnBoxing
            //object o1 = 5;
            //int x =(int) o1; 
            #endregion

            #region Nullable Type
            //Nullable Type
            #region   Nullable Value Type
            ////Nullable Value Type

            //int x = 5;
            //x = null; //invalid

            //int? Age  = 25; //Nullable <int>
            //Age = null; 

            //double? salary =21525.5 ; //Nullable<double>
            //salary = null;  

            //int X = 5;
            //int? Y = /*(int?)*/ X;

            //Console.WriteLine(Y);

            //int? x = 5;

            //x = null;
            //int y;
            //int y = (int)x;

            //Explicit Casting

            //Console.WriteLine(y);


            //if (x != null)
            //    y = (int)x;
            //else
            //    y = 0;

            //==============


            //if (x is not null)
            //    y = (int)x;
            //else
            //    y = 0;
            //Console.WriteLine(y);

            //=============

            //if (x.HasValue)
            //    y=x.Value;
            //else
            //    y = 0;
            //Console.WriteLine(y);

            //=======================

            //y= x.HasValue? x.Value : 0;
            // y=x is not null ? x.Value : 0;

            //==================
            //y = x ?? 0;
            //Console.WriteLine(y); 
            #endregion

            #region Nullable Reference Type
            //Nullable Reference Type

            //string Message01=null;   //Required
            //string? Message02=null;  //Nullable

            //Console.WriteLine(Message01);
            //Console.WriteLine(Message02.Length); 
            #endregion
            #endregion

            #region Null Propagation Operator
            ///*Null Propagation Operator*/ ?

            //double x = default;
            //Console.WriteLine(x);

            //int[] arr = default;
            //int[] arr = { 1, 2, 3 };
            //if (arr != null)
            //{
            //    for (int i = 0;  i < arr.Length; i++)
            //     Console.WriteLine(arr[i]);
            //}

            //for (int i = 0;arr is not null && i<arr.Length;i++)
            //    Console.WriteLine(arr[i]);

            //for (int i = 0;  i < arr?.Length; i++)
            //  Console.WriteLine(arr[i]);

            // int len = arr.Length;
            // int len = arr?.Length is not null ? arr.Length:0
            //int len = arr?.Length ?? -1;

            //Console.WriteLine(len); 
            #endregion

            #region Exception Handling And Protective Code

            //// Exception Handling And Protective Code

            //DoSomeCode();

            //Console.WriteLine("Hello After Excepion "); 
            #endregion



        }
    }
}
