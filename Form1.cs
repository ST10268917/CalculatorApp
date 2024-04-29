namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string operationName;
        Calculator calculator = new Calculator();
        int result;

        public Form1()
        {
            InitializeComponent();
            calculator.OperationPerformed += Calculator_CalculationPerformed;

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(this.num1.Text);
            int num2 = Convert.ToInt32(this.num2.Text);

            switch (operationName)
            {
                case "+":
                    result = calculator.addition(num1, num2);
                    break;
                case "-":
                    result = calculator.subtraction(num1, num2);
                    break;
                case "x":
                    result = calculator.multiplication(num1, num2);
                    break;
                case "÷":
                    result = calculator.division(num1, num2);
                    break;
            }
            resultLabel.Text = result.ToString();
        }

        private int Calculator_CalculationPerformed(int num1, int num2)
        {
            return 1;
        }


        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void process_SelectedIndexChanged(object sender, EventArgs e)
        {
            operationName = process.SelectedItem.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
