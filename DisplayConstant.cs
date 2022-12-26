using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BNTN_Ass02_Opt1
{
    internal static class DisplayConstant
    {
        public const string INPUT_EMPLOYEE_INFO = "======================== Employee Info =======================";

        #region choose role
        public const string INPUT_ROLE = "Please entry role of the employee - 'true' => manager employee - 'false' => teacher employee: ";
        #endregion

        #region input information
        public const string INPUT_NAME = "Please entry name employee: ";
        public const string INPUT_ALLOWANCE = "Please entry allowance of the employee: ";
        public const string INPUT_COEFFICIENTSALARY = "Please entry coefficient salary of the employee: ";
        public const string INPUT_DEPARTMENT = "Please entry name of the department: ";
        #endregion

        #region input teacher
        public const string INPUT_NUMBER_LECTURE = "Please entry number of the lecture: ";
        public const string INPUT_LEVEL_TEACHER = "Please entry level of techer - graduate | master | doctor of philosophy: ";
        #endregion

        #region input employeer
        public const string INPUT_NUMBEROFWORKDAY = "Please entry number of workdays: ";
        public const string INPUT_POSITION_MANAGER = "Please entry position of manager - manager | vice manager | employee: ";
        #endregion

        #region find information
        public const string INPUT_FINDNAME = "Please input name of the employee to find: ";
        public const string INPUT_FINDDEPARTMENT = "Please input nsme of department to find: ";
        #endregion

        #region output information
        public const string OUTPUT_NAME = "Name employee: {0}";
        public const string OUTPUT_ALLOWANCE = "Allowance employee: {0}";
        public const string OUTPUT_COEFFICIENT_SALARY = "Coefficient salary: {0}";
        public const string OUTPUT_INCOME = "Income of employee: {0}";
        public const string OUTPUT_DEPARTMENT = "Department: {0}";
        #endregion

        #region output information of the 
        public const string OUTPUT_LEVEL = "Level of teacher: {0}";
        public const string OUTPUT_NUMBER_LECTURE = "Number lecture: {0}";
        #endregion

        #region output information of the manager
        public const string OUTPUT_NUMBERWORKDAY = "Number workdays: {0}";
        public const string OUTPUT_ROLE_MANAGER = "Role of manager: {0}";
        #endregion

        #region output error
        public const string OUTPUT_ERROR_ROLE = "You have to input true role of the employee. only 'true' or 'false'";
        public const string OUTPUT_ERROR_DEFINE = "You have to input true define on any field";
        #endregion

        #region output list on the screen
        public const string OUTPUT_EMPLOYEE = "List employeer: ";
        public const string OUTPUT_TEACHER = "List teacher: ";
        #endregion

        #region output find error
        public const string OUTPUT_CANNOT_FIND = "System can't find this employee!";
        #endregion

        #region menu system
        public const string MENU_START = "Please choice function";
        public const string MENU_CREATE_EMPLOYEE = "1. Create Employee";
        public const string MENU_INFOR_INCOME_EMPLOYEE = "Allowance employee:";
        public const string MENU_DETAIL_ALLOWANCE_TEACHER = "Allowance Teacher - graduate: 300 - master: 500 - doctor of philosophy: 1000";
        public const string MENU_DETAIL_ALLOWANCE_MANAGER = "Allowance Manager - manager: 2000 - vice manager: 1000 - employee: 500";
        public const string MENU_FIND = "2. Find employee: ";
        public const string MENU_DISPLAY_EMPLOYEE = "3. Sort And Display employee";
        public const string MENU_EXIT = "4. Exit system!";
        public const string MENU_DONT_FUNCTION = " System don't support this function";
        #endregion

        public const string END_OF_PAGE_MESSAGE = "====================== End Of page message ===================";
    }
}