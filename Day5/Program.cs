namespace Day5
{
    internal class Program
    {
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

        static void Main(string[] args)
        {
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
