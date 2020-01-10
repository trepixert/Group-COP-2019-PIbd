using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.models;

namespace AbstractFactory.factory.implementations {
    public class TaskLessonFactory : LessonFactory {
        public override string getLessonDescription() {
            return "TaskLessonDescription";
        }

        public override string getLessonName() {
            return "TaskLessonName";
        }

        public override LessonStatistic getLessonStatistic() {
            return new LessonTask();
        }
    }
}
