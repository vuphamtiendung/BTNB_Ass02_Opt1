using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BNTN_Ass02_Opt1
{
    internal class Teacher : Employeer
    {
        private string _level;
        private float _numberLecture;

        
        public string Level { get { return _level; } set { _level= value; } }
        public float NumberLecture { get { return _numberLecture; } set { if (_numberLecture > 0) { _numberLecture = value; } } }


        public Teacher() : base()
        {
            _level = " ";
            _numberLecture = 0;
        }

        public Teacher(string level, float numberLecture) : base()
        {
            _level = level;
            _numberLecture = numberLecture;
        }

        public override string InputInfo(string message) => base.InputInfo(message);

        public override void InputEmployee()
        {
            base.InputEmployee();
            _level = InputInfo(DisplayConstant.INPUT_LEVEL_TEACHER);
            _numberLecture = Convert.ToInt64(InputInfo(DisplayConstant.INPUT_NUMBER_LECTURE));
        }

        public override double Income() => CoefficientSalary * 730 + 300 + Allowance * 45;

        public override void DisplayEmployee()
        {
            base.DisplayEmployee();
            WriteLine(DisplayConstant.OUTPUT_LEVEL, _level);
            WriteLine(DisplayConstant.OUTPUT_NUMBER_LECTURE, _numberLecture);
            WriteLine(DisplayConstant.OUTPUT_INCOME, Income());
        }
    }
}
