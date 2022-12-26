using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BNTN_Ass02_Opt1
{
    internal abstract class Employeer
    {
        private string _name;
        private double _allowance;
        private double _coefficientSalary;
        private string _department;
        private bool _role;
        
        public string Name { get { return _name; } set { _name = value; } }
        public double Allowance { get { return _allowance;} set { if (_allowance >= 0) { _allowance = value; } } }
        public double CoefficientSalary { get { return _coefficientSalary; } set { _coefficientSalary = value; } }
        public string Department { get { return _department; } set { _department = value; } }
        public bool Role { get { return _role; } set { if (_role == true || _role == false) { _role = value; } } }

        public Employeer()
        {
            _name = "";
            _allowance = 0;
            _coefficientSalary = 0;
        }
        public Employeer(string name, double allowance, double coefficientSalary)
        {
            _name = name;
            _allowance= allowance;
            _coefficientSalary = coefficientSalary;
        }

        public abstract double Income(); // Income tax, use abstract

        public virtual string InputInfo(string message)
        {
            WriteLine(message);
            return ReadLine();
        }

        public virtual void InputEmployee()
        {
            _name = InputInfo(DisplayConstant.INPUT_NAME);
            _allowance = Convert.ToDouble(InputInfo(DisplayConstant.INPUT_ALLOWANCE));
            _coefficientSalary = Convert.ToDouble(InputInfo(DisplayConstant.INPUT_COEFFICIENTSALARY));
            _department = InputInfo(DisplayConstant.INPUT_DEPARTMENT);
            ReadLine();
        }

        public virtual void DisplayEmployee()
        {
            WriteLine(DisplayConstant.OUTPUT_NAME, _name);
            WriteLine(DisplayConstant.OUTPUT_ALLOWANCE, _allowance);
            WriteLine(DisplayConstant.OUTPUT_COEFFICIENT_SALARY, _coefficientSalary);
            WriteLine(DisplayConstant.OUTPUT_DEPARTMENT, _department);
            WriteLine(DisplayConstant.OUTPUT_INCOME, Income());
        }
    }
}
