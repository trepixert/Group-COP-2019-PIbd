using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;

namespace StudentControlAccounting
{
    public class Test_volerdman_
    {
        public string name { get; set; }
        public int course { get; set; }

        private static List<Test_volerdman_> GetTestDataFirst()
        {
            List<Test_volerdman_> testDataFirst = new List<Test_volerdman_>();

            testDataFirst.Add(new Test_volerdman_() { name = "Ваня", course = 1 });
            testDataFirst.Add(new Test_volerdman_() { name = "Стас", course = 2 });
            testDataFirst.Add(new Test_volerdman_() { name = "Гена", course = 2 });
            testDataFirst.Add(new Test_volerdman_() { name = "Турбо", course = 3 });
            testDataFirst.Add(new Test_volerdman_() { name = "Дюша", course = 4 });

            return testDataFirst;
        }

        private static List<Test_volerdman_> GetTestDataSecond()
        {
            List<Test_volerdman_> testDataSecond = new List<Test_volerdman_>();

            testDataSecond.Add(new Test_volerdman_() { name = "Антон", course = 1 });
            testDataSecond.Add(new Test_volerdman_() { name = "Олег", course = 3 });
            testDataSecond.Add(new Test_volerdman_() { name = "Павел", course = 2 });
            testDataSecond.Add(new Test_volerdman_() { name = "Леха", course = 2 });
            testDataSecond.Add(new Test_volerdman_() { name = "Волчара", course = 1 });

            return testDataSecond;
        }

        public static Series GetSeriesFirst()
        {
            // создаём набор данных
            Series seriesFirst = new Series("First");

            // заполняем данными
            seriesFirst.Bind(Test_volerdman_.GetTestDataFirst(), "name", "course");
            return seriesFirst;
        }

        public static Series GetSeriesSecond()
        {
            // создаём набор данных
            Series seriesSecond = new Series("Second");
            // заполняем данными
            seriesSecond.Bind(Test_volerdman_.GetTestDataSecond(), "name", "course");
            return seriesSecond;
        }
    }
}
