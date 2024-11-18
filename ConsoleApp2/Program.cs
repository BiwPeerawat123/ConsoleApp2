using System.Runtime.Intrinsics.X86;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeat;
            do
            {

                headProgram("Peerawat Seeyothee");//เรียกใช้ฟังชันที่สร้างไว้ 

                //รับค่า น้ำหนัก ส่วนสูง
                double weight = 0.0;
                double height = 0.0;
                WriteLineColor("input your weight(kg):", ConsoleColor.Green, ConsoleColor.White);
                weight = Convert.ToDouble(Console.ReadLine());
                WriteLineColor("input your height(cm):", ConsoleColor.Green, ConsoleColor.White);
                height = Convert.ToDouble(Console.ReadLine());
                line("#", 40);

                bmi(weight, height);//เรียกใช้ฟังชัน pirocess ประมวลผล

                line("%", 40);

                // ถามผู้ใช้ว่าต้องการคำนวณอีกครั้งหรือไม่

                Console.Write("Do you want to calculate again? (y/n): ");
                repeat = Console.ReadLine().ToLower();

            } while (repeat == "y");

            Console.WriteLine("Thank you for using the BMI calculator!");
        }

        //--------------------------------------------------------------//
        static void line(string letter, int width)
        {
            string str = "";
            for (int i = 0; i < width; i++)
            {
                str += letter; ;
            }
            WriteLineColor(str, ConsoleColor.Green, ConsoleColor.White);
        }
        static void headProgram(string programmerName)
        {
            WriteLineColor("Body mass index (BMI)", ConsoleColor.Red, ConsoleColor.White);
            line("*", 40);

            WriteLineColor("Develop by " + programmerName, ConsoleColor.Green,ConsoleColor.White);


            line("-", 40);

            WriteLineColor("Please input you Information", ConsoleColor.Blue, ConsoleColor.White);
        }
        static void WriteLineColor(string text, ConsoleColor fg, ConsoleColor bg){

          Console.ForegroundColor = fg;
          Console.BackgroundColor = bg;

          Console.WriteLine(text);

          Console.ForegroundColor = ConsoleColor.White;
          Console.BackgroundColor = ConsoleColor.Black;

        }
        static void bmi(double weight , double height )
        {

            //pirocess ประมวลผล
            double bmi = weight / Math.Pow(height / 100, 2);
            string result = "";
            if (bmi < 18.5)
            {
                result = "Underweight";
            }
            else if (bmi < 25)
            {
                result = "Normal weight";
            }
            else if (bmi < 30)
            {
                result = "Overweight";
            }
            else
            {
                result = "Obesity";
            }
            WriteLineColor("Your Body mass index (BMI) is " + bmi.ToString("0.00"), ConsoleColor.Green, ConsoleColor.White);
            WriteLineColor("From your body mass index ,you are" + result, ConsoleColor.Green, ConsoleColor.White);
        }
    }

}
