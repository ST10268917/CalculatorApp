using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public delegate int OperationHandler(int num1, int num2);

    

class Calculator
    {
     
        public event OperationHandler OperationPerformed;

        public Calculator()
        {

        }

        


        public int addition(int num1, int num2)
        {
            this.OperationPerformed += (n1, n2) =>
            {
                MessageBox.Show($"Performing Calculation: Addition\n({num1} + {num2})");
                return n1 + n2;
            };
            int result = num1 + num2;
            OnCalculationPerformed(num1, num2);
            return result;
        }

        public int subtraction(int num1, int num2)
        {
            this.OperationPerformed += (n1, n2) =>
            {
                MessageBox.Show($"Performing Calculation: Subtraction\n({num1} - {num2})");
                return n1 + n2;
            };
            int result = num1 - num2;
            OnCalculationPerformed(num1, num2);
            return result;
        }

        public int multiplication(int num1, int num2)
        {
            this.OperationPerformed += (n1, n2) =>
            {
                MessageBox.Show($"Performing Calculation: Multiplication\n({num1} x {num2})");
                return n1 + n2;
            };
            int result = num1 * num2;
            OnCalculationPerformed(num1, num2);
            return result;
        }

        public int division(int num1, int num2)
        {
            this.OperationPerformed += (n1, n2) =>
            {
                MessageBox.Show($"Performing Calculation: Division\n({num1} ÷ {num2})");
                return n1 + n2;
            };
            int result = num1 + num2;
            OnCalculationPerformed(num1, num2);
            return result;
        }

        protected virtual void OnCalculationPerformed(int num1, int num2)
        {
            OperationPerformed?.Invoke(num1, num2);
        }

    }
}
