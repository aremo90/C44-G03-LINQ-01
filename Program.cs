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

            //int x = 1234567;

            //Console.WriteLine(intgerExtention.Revese(x));

            //int y = x.Revese(); // Extention method
            //Console.WriteLine(y);

            #endregion


            #region annonymous type

            //Employee emp = new Employee();
            //emp.Id = 101;
            //emp.Name = "John";
            //emp.Salary = 45000;

            //object emp01 = new
            //{
            //    Id = 101,
            //    Name = "John",
            //    Salary = 45000
            //};


            // annonymous type

            //var emp02 = new { Id = 10, Name = "Ahmed", Salary = 5000 };
            //Console.WriteLine(emp02.Name);
            //Console.WriteLine(emp02.GetType().Name);

            //var emp03 = new { Id = emp02.Id, Name = emp02.Name, Salary = 100000 };
            //Console.WriteLine(emp03.GetType().Name);



            //var emp04 = new { Id = 10, Name = "Ahmed", Salary = 5000 , age = 20};
            //Console.WriteLine(emp04.GetType().Name);

            //var emp05 = new { ID = emp02.Id, Name = emp02.Name, Salary = 100000 };
            //Console.WriteLine(emp05.GetType().Name);

            #endregion

            #region What is LinQ

            // LinQ = Language Integrated Query

            // - 40+ operators

            // Dql = Data Query Language +> sql server

            // Linq is set of operators

            // extension methods exits in interface IEnumerable<T>

            // all implemention of these method in class Enumerable

            // LinQ Operators dived into 13 categories

            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Odd Numbers Number %2 == 1
            // Where()

            List<int> OddNumbers = Numbers.Where(N => N % 2 == 0).ToList();
            
            foreach (var item in OddNumbers)
                Console.WriteLine(item);



            #endregion


        }
    }
}
