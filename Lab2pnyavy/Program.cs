using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2pnyavy
{
    class Program
    {
        static void Main(string[] args)
        {
            Mystring myclass = new Mystring();
            Mystring str1, str2, str3;
            int a, len;
            string line, output;

            do
            {
                Console.Clear();
                Console.WriteLine("1: SubString\n2: SubString перегрузка\n3: Длина строки\n4: Перегрузка +/==/!=\n5: String.IndexOf(Char)\n8: Cut\n9: Выйти ");
                Console.WriteLine("Введите команду:");
                int comand = Convert.ToInt32(Console.ReadLine());
                
                switch (comand)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите строку");
                            str1 = Console.ReadLine();
                            Console.WriteLine("С какого символа брать подстроку?");
                            a = Convert.ToInt32(Console.ReadLine());                          
                            Console.WriteLine("Подстрока: " + myclass.ApplySubstring(str1, a));
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите строку");
                            str1 = Console.ReadLine();
                            Console.WriteLine("С какого символа брать подстроку?");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Длина подстроки");
                            len = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Подстрока: " + myclass.ApplySubstring(str1, a, len));
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите строку");
                            str1 = Console.ReadLine();
                            Console.WriteLine("Длина строки: " + myclass.Lenght(str1));
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите строку");
                            str1 = Console.ReadLine();
                            Console.WriteLine("Введите еще одну строку");
                            str2 = Console.ReadLine();
                            Console.WriteLine("Сумма 2 строк: " + (str1 + str2));
                            if (str1==str2)
                                Console.WriteLine("Строки одинаковые");
                            else Console.WriteLine("Строки не равны");
                            Console.ReadKey();
                            break;

                        }
                    case 5:
                        {
                            Console.WriteLine("Введите строку");
                            str1 = Console.ReadLine();
                            line = Convert.ToString(str1);
                            Mystring mycl = new Mystring(line);
                            Console.WriteLine("Введите символ");
                            char ch = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine("Индекс первого вхождения: " + mycl.FindSymbol(ch));
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {

                            Console.WriteLine("Индекс первого вхождения: " + myclass.Replace("моя строка", 'я', 'к'));
                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            str1 = new Mystring("строкамояка");
                            Console.WriteLine("Индекс первого вхождения: " + str1.Index("ка"));
                            Console.WriteLine("Индекс первого вхождения: " + str1.Index("ка", 8));
                            Console.ReadKey();
                            break;
                        }
                    case 8:
                        {
                            str1 = new Mystring("строкамаяк");
                            str2 = new Mystring("строкамаяк");
                            Console.WriteLine("Полученная строка: " + str2.Cut(2, 4));
                            Console.WriteLine("Полученная строка: " + str1.Cut("маяк"));
                            Console.ReadKey();
                            break;
                        }
                    case 9: Environment.Exit(0); break;
                    default: break;

                }
            } while (true);
        }
    }
}
