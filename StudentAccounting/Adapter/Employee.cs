using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    public class Employee {
        public string Name { get; set; }
        public double Wage { get; set; }

        public override string ToString() {
            return string.Format("ФИО: {0} Заработная плата: {1}",Name,Wage);
        }
    }
}
