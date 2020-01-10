﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.models {
    public class LessonVisit : LessonStatistic {
        public override int getBall(bool isVisited) {
            return isVisited ? 1 : 0;
        }
    }
}
