using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.models {
    public class Lesson {
        public string Name { get; set; }
        public string Description { get; set; }
        public LessonStatistic LessonStatistic { get; set; }

        public Lesson(string name, string description, LessonStatistic lessonStatistic) {
            this.Name = name;
            this.Description = description;
            this.LessonStatistic = lessonStatistic;
        }

        public override string ToString() {
            return string.Format("Lesson name {0}, Lesson description {1}", Name, Description);
        }
    }
}
