using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BNTN_Ass02_Opt1
{
    internal class Employee : Employeer
    {
        private float _numberWorkDay;
        private string _position;

        public float NumberWorkDay { get { return _numberWorkDay; } set { _numberWorkDay = value; } }
        public string Position { get { return _position; } set { _position = value; } }

        public Employee() : base()
        {
            _numberWorkDay = 0;
            _position = " ";
        }
        public Employee( float numberWorkDay, string position)
        {
            _numberWorkDay = numberWorkDay;
            _position = position;
        }

        public override void InputEmployee()
        {
            base.InputEmployee();
            _numberWorkDay = Convert.ToInt64(InputInfo(DisplayConstant.INPUT_NUMBEROFWORKDAY));
            _position = InputInfo(DisplayConstant.INPUT_POSITION_MANAGER);
        }
        public override double Income() => CoefficientSalary * 730 + Allowance + _numberWorkDay * 30;

        public override void DisplayEmployee()
        {
            base.DisplayEmployee();
            WriteLine(DisplayConstant.OUTPUT_NUMBERWORKDAY, _numberWorkDay);
            WriteLine(DisplayConstant.OUTPUT_ROLE_MANAGER, _position);
            WriteLine(DisplayConstant.OUTPUT_INCOME, Income());
        }
    }
}
