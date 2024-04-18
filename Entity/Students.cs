using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGradingSystem.Entity
{
    public class Students : BaseFields
    {
        private Dictionary<string, int> studentNotes;
        public Students(string username, string password) : base(username, password)
        {
            if (username =="student1" && password =="password1" )
            {
                studentNotes = new Dictionary<string, int>()
            {
                {"Alper", 78}

            };
            }
            else if (username == "student2" && password == "password2")
            {
                studentNotes = new Dictionary<string, int>()
            {
                {"Mehmet", 45}

            };
            }
            else if (username == "student3" && password == "password3")      // bunun daha kısa yazılımı varmış lakin bir türlü anlayamadım daha dinlenik vakitte tekrar bakıcam
            {
                studentNotes = new Dictionary<string, int>()
            {
                {"Cemal", 90}

            };
            }
            else if (username == "student4" && password == "password4")
            {
                studentNotes = new Dictionary<string, int>()
            {
                {"Berke", 23}

            };
            }
            else if (username == "student5" && password == "password5")
            {
                studentNotes = new Dictionary<string, int>()
            {
                {"Semih", 66}

            };
            }
        }
        
        public void PrintStudentNotes()
        {
            Console.WriteLine("Student Notes:");
            Console.WriteLine("-------------------");
            foreach (var item in studentNotes)
            {
                
                if (item.Value > 90)
                {
                    Console.WriteLine($"Name: {item.Key}  Note: {item.Value} (AA)");
                }
                else if (item.Value >= 80)
                {
                    Console.WriteLine($"Name: {item.Key}  Note: {item.Value} (BB)");
                }
                else if (item.Value >=70)
                    { Console.WriteLine($"Name: {item.Key}  Note: {item.Value} (CC)"); }
                else if (item.Value >=50)
                {
                    Console.WriteLine($"Name: {item.Key}  Note: {item.Value} (DD)");
                }
                else { Console.WriteLine($"Name: {item.Key}  Note: {item.Value} (FF)"); }
            }
        }
    }
}
    