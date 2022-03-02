using System;
using System.Text;

namespace StaticCOnstReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //Console.WriteLine(Employee.company);
            //Employee.GetManager();
            //String str = string.Empty;
            //str += "Thid";
            //str += "is";
            //Console.WriteLine(str);
            //StringBuilder sb = new StringBuilder();
            //sb.Append("This");
            //sb.Append("is");
            //sb.Insert(1, "that");
            //Console.WriteLine(sb.ToString()) ;
            CommonFunctions.NumericFunctions numericFunctions = new CommonFunctions.NumericFunctions();
            Console.WriteLine(numericFunctions.Add(10,2,23,23,23,12));
            Console.WriteLine(numericFunctions.IsEven(10));
            CommonFunctions.StringFunctions stringFunctions = new CommonFunctions.StringFunctions();
            Console.WriteLine(stringFunctions.CombineNames("Ajay", "Kumar"));
            Console.WriteLine(stringFunctions.Table(3,2,9));
            

        }
    }
}
