using AbstractFactory.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.factory {
    public abstract class LessonFactory {
        public abstract string getLessonName();
        public abstract string getLessonDescription();
        public abstract LessonStatistic getLessonStatistic();
    }
}
