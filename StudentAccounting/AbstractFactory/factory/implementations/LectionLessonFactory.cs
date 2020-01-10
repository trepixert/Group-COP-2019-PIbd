using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.models;

namespace AbstractFactory.factory.implementations {
    public class LectionLessonFactory : LessonFactory {
        public override string getLessonDescription() {
            return "LectionLessonDescription";
        }

        public override string getLessonName() {
            return "LectionLessonName";
        }

        public override LessonStatistic getLessonStatistic() {
            return new LessonVisit();
        }
    }
}
