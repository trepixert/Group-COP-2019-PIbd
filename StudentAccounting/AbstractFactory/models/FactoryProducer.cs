using AbstractFactory.factory;
using AbstractFactory.factory.implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.models {
    public class FactoryProducer {
        public static LessonFactory getLessonFactory(LessonType lessonType) {
            switch (lessonType) {
                case LessonType.LECTION:
                    return new LectionLessonFactory();
                case LessonType.TASK:
                    return new TaskLessonFactory();
                default: return null;
            }
        }
    }
}
