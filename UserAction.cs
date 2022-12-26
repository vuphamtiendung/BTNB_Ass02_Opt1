using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace BNTN_Ass02_Opt1
{
    internal class UserAction
    {
        public Teacher teacher = null;
        public Employee employee = null;

        public List<Teacher> listTeacher = new List<Teacher>();
        public List<Employee> listEmployee = new List<Employee>();

        public static UserAction useraction;
        public UserAction() { }
        public static UserAction GetUserAction()
        {
            if(useraction == null)
            {
                useraction = new UserAction();
            }
            return useraction;
        }

        public string InputInfo(string message)
        {
            WriteLine(message);
            return ReadLine();
        }

        public enum Options
        {
            InputInfoEmployee = 1,
            FindEmployee = 2,
            SoftAndDisplay = 3,
            Exit = 4
        };


        public List<Employee> SoftEmployee(List<Employee> listEmploy)
        {
            listEmploy = listEmployee.OrderByDescending(x => x.Income())
                                    .ThenBy(y => y.Name)
                                    .ToList();

            foreach (var list in listEmploy)
            {
                WriteLine(DisplayConstant.OUTPUT_NAME, list.Name);
                WriteLine(DisplayConstant.OUTPUT_ALLOWANCE, list.Allowance);
                WriteLine(DisplayConstant.OUTPUT_COEFFICIENT_SALARY, list.CoefficientSalary);
                WriteLine(DisplayConstant.OUTPUT_DEPARTMENT, list.Department);
                WriteLine(DisplayConstant.OUTPUT_INCOME, list.Income());
                WriteLine();
            }
            return listEmploy;
        }

        public List<Teacher> SoftTeacher(List<Teacher> listTeach)
        {
            listTeach = listTeacher.OrderBy(x => x.Income())
                                    .ThenBy(y => y.Name)
                                    .ToList();

            foreach (var list in listTeach)
            {
                WriteLine(DisplayConstant.OUTPUT_NAME, list.Name);
                WriteLine(DisplayConstant.OUTPUT_ALLOWANCE, list.Allowance);
                WriteLine(DisplayConstant.OUTPUT_COEFFICIENT_SALARY, list.CoefficientSalary);
                WriteLine(DisplayConstant.OUTPUT_DEPARTMENT, list.Department);
                WriteLine(DisplayConstant.OUTPUT_INCOME, list.Income());
                WriteLine();
            }
            return listTeach;
        }

        public void Perform()
        {
            Options option;
            do
            {
                WriteLine(DisplayConstant.INPUT_EMPLOYEE_INFO);
                WriteLine(DisplayConstant.MENU_START);
                WriteLine(DisplayConstant.MENU_CREATE_EMPLOYEE);
                WriteLine();
                WriteLine(DisplayConstant.MENU_INFOR_INCOME_EMPLOYEE);
                WriteLine();
                WriteLine(DisplayConstant.MENU_DETAIL_ALLOWANCE_TEACHER);
                WriteLine();
                WriteLine(DisplayConstant.MENU_DETAIL_ALLOWANCE_MANAGER);
                WriteLine();
                WriteLine(DisplayConstant.MENU_FIND);
                WriteLine();
                WriteLine(DisplayConstant.MENU_DISPLAY_EMPLOYEE);
                WriteLine();
                WriteLine(DisplayConstant.MENU_EXIT);
                WriteLine(DisplayConstant.END_OF_PAGE_MESSAGE);

                Enum.TryParse(ReadLine(), out option);
                switch (option)
                {
                    case Options.InputInfoEmployee:
                        {
                            try
                            {
                                bool choose = Convert.ToBoolean(InputInfo(DisplayConstant.INPUT_ROLE));
                                if(choose == true)
                                {
                                    employee = new Employee();
                                    employee.InputEmployee();
                                    listEmployee.Add(employee);
                                }
                                else if(choose == false)
                                {
                                    teacher = new Teacher();
                                    teacher.InputEmployee();
                                    listTeacher.Add(teacher);
                                }
                            }
                            catch(Exception ex)
                            {
                                WriteLine(DisplayConstant.OUTPUT_ERROR_DEFINE);
                                WriteLine(ex.ToString());
                            }                        
                            break;
                        }
                    case Options.FindEmployee:
                        {
                            try
                            {
                                string name = InputInfo(DisplayConstant.INPUT_FINDNAME);
                                string department = InputInfo(DisplayConstant.INPUT_FINDDEPARTMENT);

                                var listEmployeeFind = listTeacher.FindAll(x => x.Name == name && x.Department == department);

                                if (listEmployeeFind != null)
                                {
                                    foreach (var list in listEmployeeFind)
                                    {
                                        WriteLine();
                                        WriteLine(DisplayConstant.OUTPUT_NAME, list.Name);
                                        WriteLine(DisplayConstant.OUTPUT_ALLOWANCE, list.Allowance);
                                        WriteLine(DisplayConstant.OUTPUT_COEFFICIENT_SALARY, list.CoefficientSalary);
                                        WriteLine(DisplayConstant.OUTPUT_INCOME, list.Income());
                                        WriteLine(DisplayConstant.OUTPUT_DEPARTMENT, list.Department);
                                        WriteLine(DisplayConstant.OUTPUT_LEVEL, list.Level);
                                        WriteLine(DisplayConstant.OUTPUT_NUMBER_LECTURE, list.NumberLecture);
                                        WriteLine();
                                    }
                                }
                                else
                                {
                                    WriteLine(DisplayConstant.OUTPUT_CANNOT_FIND);
                                }

                                var listTeacherFind = listEmployee.FindAll(x => x.Name == name && x.Department == department);

                                if(listTeacherFind != null)
                                { 

                                    foreach (var list in listTeacherFind)
                                    {
                                        WriteLine();
                                        WriteLine(DisplayConstant.OUTPUT_NAME, list.Name);
                                        WriteLine(DisplayConstant.OUTPUT_ALLOWANCE, list.Allowance);
                                        WriteLine(DisplayConstant.OUTPUT_COEFFICIENT_SALARY, list.CoefficientSalary);
                                        WriteLine(DisplayConstant.OUTPUT_INCOME, list.Income());
                                        WriteLine(DisplayConstant.OUTPUT_DEPARTMENT, list.Department);
                                        WriteLine(DisplayConstant.OUTPUT_NUMBERWORKDAY, list.NumberWorkDay);
                                        WriteLine(DisplayConstant.OUTPUT_ROLE_MANAGER, list.Position);
                                        WriteLine();
                                    }
                                }
                                else
                                {
                                    WriteLine(DisplayConstant.OUTPUT_CANNOT_FIND);
                                }
                            }
                            catch(Exception ex)
                            {
                                WriteLine(ex.ToString());
                            }
                            break;
                        }
                    case Options.SoftAndDisplay:
                        {
                            WriteLine(DisplayConstant.OUTPUT_EMPLOYEE);
                            SoftEmployee(listEmployee);
                            WriteLine();
                            WriteLine(DisplayConstant.OUTPUT_TEACHER);
                            SoftTeacher(listTeacher);
                            break;
                        }
                    case Options.Exit:
                        {
                            WriteLine(DisplayConstant.MENU_EXIT);
                            break;
                        }
                    default:
                        {
                            WriteLine(DisplayConstant.MENU_DONT_FUNCTION);
                            break;
                        }
                }
            }
            while (option != Options.Exit);
        }
    }
}
