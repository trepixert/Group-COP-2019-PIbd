using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractFactory.models;
using AbstractFactory.factory;

namespace AbstractFactory {
    public partial class UserControlAbstractFactory : UserControl {
        public UserControlAbstractFactory() {
            InitializeComponent();
            userControlAgliullin1.LoadEnumeration(typeof(LessonType));
        }

        public string GetSelectedText {
            get {
                return userControlAgliullin1.GetSelectedText;
            }
        }

        public string GetString {
            get {
                bool isVisited = checkBox1.Checked;
                LessonType lessonType = (LessonType)Enum.Parse(typeof(LessonType), userControlAgliullin1.GetSelectedText);
                LessonFactory lessonFactory = FactoryProducer.getLessonFactory(lessonType);
                Lesson lesson = new Lesson(lessonFactory.getLessonName(), lessonFactory.getLessonDescription(), lessonFactory.getLessonStatistic());
                return lesson.ToString() + " LessonState: "+ lesson.LessonStatistic.getBall(isVisited);
            }
        }
    }
}
