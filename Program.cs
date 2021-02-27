using System;

namespace Lab_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region task 1

            MyList<string> list = new MyList<string>();
            list.Add("Создайте класс MyList");
            list.Add("Реализуйте в простейшем приближении возможность использования...");
            Console.WriteLine(list.Length);
            list.Add("Минимально требуемый интерфейс...");
            list.Add("метод добавления элемента");
            list.Add("индексатор для получения значения элемента");
            list.Add("свойство для получения общего количества элементов");
            Console.WriteLine(list.Length);
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            #endregion


            #region task 2

            MyDictionary<char, string> statuses = new MyDictionary<char, string>();
            statuses.Add('_', "Unstarted");
            statuses.Add('•',"Performed");
            statuses.Add('✔',"Completed");
            Console.WriteLine(statuses.Length);
            statuses.Add('✘',"Failed");
            statuses.Add('◼',"Paused");
            Console.WriteLine(statuses.Length);
            Console.WriteLine(statuses['_']);
            Console.WriteLine(statuses['✔']);

            #endregion

            #region task 3

            string[] array = list.GetArray();
            foreach (string a in array)
                Console.WriteLine(a);

            #endregion

            #region task 4

            MyClass.FactoryMethod<MyList<int>>();

            #endregion

            Console.ReadKey();
        }
    }
}