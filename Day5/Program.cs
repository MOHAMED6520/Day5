namespace Day5
{
    internal class Program
    {
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

        }
    }
}
