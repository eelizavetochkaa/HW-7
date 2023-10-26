using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_7
{
    internal class Program
    {

        public static void Proverka(object obj)
        {
            if (obj is IFormattable)
            {
                IFormattable formattableObj = obj as IFormattable;
                Console.WriteLine("Параметр реализует System.IFormattable. " + formattableObj.ToString());
            }
            else
            {
                Console.WriteLine("Параметр не реализует System.IFormattable.");
            }
        }
        public static void Line(string str)
        {
            int a = str.Length;
            string list = "";
            for (int i = a-1; i>=0; i--)
            {
                list += str[i];
            }
            Console.WriteLine($"Строка в обратном порядке:'{list}'") ;
        }
        
        public static void SearchMail(ref string s, ref string email)
        {
            int index = s.IndexOf("#");
            if (index != -1)
            {
                email = s.Substring(index + 1).Trim();
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 8.1");
            Console.WriteLine("Введите, сколько денег вы хотите перевести");
            bool flag = true;
            bool success = int.TryParse(Console.ReadLine(), out int money);
            if (success)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("Неверный ввод - необходимо ввести целое число");
            }
            account2 acc1 = new account2(1200);
            account2 acc2 = new account2(3000);
            acc1.Perevesty(acc2, money);
            Console.WriteLine("Упражнение 8.2");
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine();
            Line(line);
            Console.WriteLine("Упражнение 8.3");
            Console.WriteLine("Введите имя файла:");
            string fileName1 = "file1";
            if (!File.Exists(fileName1))
            {
                Console.WriteLine("Файл не существует.");
            }

            // Читаем содержимое исходного файла
            string[] lines1 = File.ReadAllLines(fileName1);

            // Создаем выходной файл
            string outputFileName1 = "file.txt";

            // Записываем содержимое исходного файла в выходной файл заглавными буквами
            using (StreamWriter writer = new StreamWriter(outputFileName1))
            {
                foreach (string linee in lines1)
                {
                    writer.WriteLine(linee.ToUpper());
                }
            }

            Console.WriteLine("Содержимое файла записано в файл " + outputFileName1);

            Console.WriteLine("Упражнение 8.4");
            string str = "Hello, world!";
            int number = 123;
            Proverka(str);
            Proverka(number);

            Console.WriteLine("Домашнее задание 8.1");
            string fileName = "email.txt";
            string[] lines = File.ReadAllLines(fileName);

            string outputFileName = "email2.txt";


            foreach (string line2 in lines)
            {
                string line1 = line2;
                string email = "";
                SearchMail(ref line1, ref email);

                if (!string.IsNullOrEmpty(email))
                {
                    using (StreamWriter writer = new StreamWriter(outputFileName, true))
                    {
                        writer.WriteLine(email);
                    }
                }

                Console.WriteLine("Адреса электронной почты записаны в файл " + outputFileName);
            }

            Console.WriteLine("Домашнее задание 8.2");

            List<Song> songs = new List<Song>();

            // Создание списка из четырех песен
            Song song1 = new Song();
            song1.Name("Зеркала");
            song1.Author("Григорий Лепс");
            songs.Add(song1);

            Song song2 = new Song();
            song2.Name("Сдавайся");
            song2.Author("Сергей Лазарев");
            song2.Prev(song1);
            songs.Add(song2);

            Song song3 = new Song();
            song3.Name("Another love");
            song3.Author("Tom Odell");
            song3.Prev(song2);
            songs.Add(song3);

            Song song4 = new Song();
            song4.Name("Малиновая лада");
            song4.Author("GAYAZOV$ BROTHERS$");
            song4.Prev(song3);
            songs.Add(song4);

            // Вывод информации о каждой песне
            foreach (Song song in songs)
            {
                song.Title();
            }
            // Сравнение первой и второй песни
            if (song1.Equals(song2))
            {
                Console.WriteLine("Первая и вторая песни равны");
            }
            else
            {
                Console.WriteLine("Первая и вторая песни не равны");
            }

            Console.ReadKey();

        }
    }
}
