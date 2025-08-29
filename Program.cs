namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Implicity type local variable

            #region VAR
            ////c# 3.0
            //var Name = "John";
            //// Compiler Will detect the dataType of variable at compile time 

            ////var x = null // Invaild

            ////Name = 1; // invaild

            //Name = null; // vaild

            ////var age; // invaild

            //// Cannot use keyword var in parmater OR Retun type OR arribute
            //// we use it only for local variable 
            ///
            #endregion

            #region DYNAMIC
            //// c# 4.0
            //// not stfe
            //dynamic age = 30; // vaild  
            //// CLR will Detect the dataType at run time

            //age = "Thirty"; // vaild
            //age = null; // vaild will trow exception at run time if we try to access it
            //age = 10.5; // vaild

            //Console.WriteLine(age);
            #endregion
            #endregion

            #region extenition method

            // Method Revese number 

            int x = 1234567;

            //Console.WriteLine(intgerExtention.Revese(x));

            int y = x.Revese(); // Extention method
            Console.WriteLine(y);

            #endregion
        }
    }
}
