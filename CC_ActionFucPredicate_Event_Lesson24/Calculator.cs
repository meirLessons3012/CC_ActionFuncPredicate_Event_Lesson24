using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_ActionFucPredicate_Event_Lesson24
{
    internal class Calculator
    {
        public static event MethodReturnIntAcceptTwoInts MyDel;

        public Calculator()
        {
            MyDel?.Invoke(15, 25);
            MyDel = (n1, n2) => n1 / n2;
        }

        public MethodReturnIntAcceptTwoInts GetCalcMethod(string oper)
        {
            switch (oper)
            {
                case "+":
                    return (n1, n2) => n1 + n2;
                case "-":
                    return (n1, n2) => n1 - n2;
                case "/":
                    return (n1, n2) => n1 / n2;
                case "*":
                    return (n1, n2) => n1 * n2;
                default:
                    return null;
            }
        }

        private int AddTwoNumbers(int n1, int n2)
        {
            int result = n1 + n2;

            return result;
        }


        private int SubTwoNumbers(int n1, int n2)
        {
            int result = n1 - n2;

            return result;
        }

        private int DivTwoNumbers(int n1, int n2)
        {
            int result = n1 / n2;

            return result;
        }

        private int MulptTwoNumbers(int n1, int n2)
        {
            int result = n1 * n2;

            return result;
        }
    }
}
