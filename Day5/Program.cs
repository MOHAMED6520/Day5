using System.Runtime.Intrinsics.X86;
using System.Threading;
using Common;
namespace Day5
{
    #region Enum
    //enum season : byte
    //{
    //    Spring = 10,
    //    Winter,
    //    Summer,
    //    Autumn
    //}
    //enum WeekDay
    //{
    //    Saturday,
    //    Sunday,
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday


    //}
    //enum Gender
    //{
    //    M=1,
    //    F=0,
    //    Male=1,
    //    female=0

    //}
    //[Flags]
    //enum Permission 
    //{ 
    //    Read =8,
    //    Write =4,
    //    Execute =2,
    //    Delete =1

    //} 
    #endregion
      #region Q01
  //enum WeekDays
  //{

  //    Monday,
  //    Tuesday,
  //    Wednesday,
  //    Thursday,
  //    Friday,
  //    Saturday,
  //    Sunday


  //} 
  #endregion

  #region Q02
  //enum Season 
  //{
  //    Spring ,
  //    Winter,
  //    Summer,
  //    Autumn
  //} 
  #endregion

  #region Q03
  //[Flags]
  //enum Permission
  //{
  //    Read = 8,
  //    Write = 4,
  //    Execute = 2,
  //    Delete = 1
  //} 
  #endregion

  #region Q04
  //enum Color
  //{ 
  //  Red,
  //  Green, 
  //  Blue 
  //} 
  #endregion

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

            #region Access Modifier 
            // //Access Modifier
            // //Common.TypeA = new TypeA(); //Invalid
            // TypeB typeB = new Common.TypeB();
            //// typeB.X = 5;  //invalid
            //// typeB.Y = 10; //invalid
            // typeB.Z = 20;
            #endregion

            //Enum
            #region EnumEx01
            ////season S01 = new season();
            ////S01 = season.Spring;
            ////Console.WriteLine(S01);
            ////Console.WriteLine((int)S01);

            ////Gender G01 = new Gender();
            ////G01 = (Gender) 10;

            ////  Gender G01 = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(),true);
            //Gender G01 = new Gender();

            //object o1;
            //Enum.TryParse(typeof(Gender), Console.ReadLine(),  true, out o1);

            //G01 =(Gender) o1;
            //Console.WriteLine(G01); 
            #endregion

            #region EnumEx02
            //Permission Per01 = Permission.Read;
            //Per01^= Permission.Delete;
            ////Per01|= Permission.Delete;
            ////Console.WriteLine(Per01);

            ////Per01 |= Permission.Delete;
            ////Console.WriteLine(Per01);

            //Per01 &= ~(Permission.Delete);
            //Console.WriteLine(Per01);

            //if ((Per01 & Permission.Delete) == Permission.Delete)
            //    Console.WriteLine("Exists");
            //else
            //    Console.WriteLine("Not Exisits"); 
            #endregion

 #region Q01
 //string[] g = {"0" ,"1" , "2" , "3", "4", "5", "6" };
 //WeekDays weekDays01 = WeekDays.Monday;

 //for (int i = 0; i < 7; i++)
 //{
 //    weekDays01 =(WeekDays) Enum.Parse(typeof(WeekDays), g[i]);
 //    Console.WriteLine(weekDays01);
 //} 
 #endregion

 #region Q02
 //;
 //object O;
 //Season S01= new Season();
 //do
 //{
 //    Console.Write("Enter Season Name : ");
 //    Enum.TryParse(typeof(Season), Console.ReadLine(), true, out O);
 //    if (O is not null)
 //     S01 = (Season)O; 


 //}
 //while (S01!=Season.Spring && S01 != Season.Winter && S01 != Season.Summer && S01 != Season.Autumn || O is null);


 //if (S01 == Season.Spring)
 //{
 //    Console.WriteLine("corresponding month range for that season is march to may");
 //}
 //else if (S01 == Season.Autumn)
 //{
 //    Console.WriteLine("corresponding month range for that season is September to November ");
 //}
 //else if (S01 == Season.Winter)
 //{
 //    Console.WriteLine("corresponding month range for that season is December to February ");

 //}
 //else if (S01 == Season.Summer)
 //{
 //    Console.WriteLine("corresponding month range for that season is june to august ");

 //} 
 #endregion

 #region Q03
 //Permission per = Permission.Write;
 //per |= Permission.Delete;

 //Console.WriteLine(per); 
 #endregion

 #region Q04
 //    Console.Write("Enter Color : ");
 //    object O;
 //    Color color = new Color();
 //    Enum.TryParse(typeof (Color),Console.ReadLine(),true, out O);
 //     if (O != null) 
 //        color = (Color) O;

 //    if (O == null)
 //        Console.WriteLine("the input color is not a primary color");
 //    else if (color == Color.Red || color == Color.Blue || color == Color.Green)
 //    {
 //        Console.WriteLine("the input color is a primary color");
 //    }
 //    else
 //        Console.WriteLine("the input color is not a primary color");

 #endregion
        }
    }
}
