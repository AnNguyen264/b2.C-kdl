using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiểu_dữ_liệu_object_và_từ_khóa_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region object
            object obj = "kteam.com";
            /*
             * boxing: chuyển từ dữ liệu giá trị sang kiểu dữ liệu tham chiếu (bit)
             */
            int values = 109;

            object objvalues=values;
            
            int newvalues=(int)objvalues;
            
            Console.WriteLine(objvalues);
            #endregion

            #region var
            var varint = true;

            //var ko phai la kieu du lieu khai bao bien 

            var varString = "howkteam";
            string content = "an";
            Console.WriteLine(content);
            Console.WriteLine(varString);
            #endregion

            #region Dynamic
            /*
             * Khai báo biến Stringvalues kiểu dynamic tạo giá trị là một chuỗi kiểu string 
             */
            // object Stringvalues = "HowKtem";
            /*
             * Chúng ta biết rằng kiểu chuỗi ko hỗ trợ toán tử ++
             * Nhưng khi chạy Stringvalues++ vẫn không báo lỗi do thời điểm hiện tại trình 
             * biên dịch vẫn chưa xác định kiểu dữ liệu 
             * Khi chạy chương trình thì lúc này C# mới phát hiện là kiểu string ko thực hiện toán tử ++ 
            */
            // Stringvalues++;
            #endregion

            #region vdDynamic
            // khai báo 2 biến name và mission  kiểu dữ liệu string và khởi tạo gía trị     
            string name = "Howktem";
            string Mission = "Free Education";
            /*
             THực hiện gán 1 kiểu biến string cho biến kiểu dynamic bằng cách ép kiểu ngầm định (implicit)
            Sau phép gán này thì biến DynamicValues chứa giá trị name là "howktem " nhưng kiểu dữ liệu của nó vẫn chưa đc 
             */
            dynamic dynamicname = name;
            // in ra man hinh 
            Console.WriteLine("Mission of "+dynamicname+ "is"+ Mission);
            #endregion

            Console.ReadKey();
        }
    }
}
