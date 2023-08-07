namespace Calculator
{
    public partial class Form1 : Form
    {
        //Declaring variables
        Double resultValue = 0;

        // Adding string which will perfrom op function.
        String opPerformed = "";

        bool isopPerformed = false; // bool works according to condition true or false. Bydefault setting it to false.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void nAC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0; //So that when clicked it bydefault goes to zero.
        }

        private void n_Click(object sender, EventArgs e)
        {
            // To remove the by default 0 in calculator
            if ((textBox.Text == "0") || (isopPerformed)) // For when other number is clicked it comes after operator and operates..
                textBox.Clear();

            isopPerformed = false; //to; when clicked on any numbers operations becomes false.

            // To click the buttons and make it appear in textbox.
            // textBox.Text = textBox.Text + "1";

            //To click all number buttons in calculator
            Button n = (Button)sender; //(sender because our object above is sender, amd to tell to send the clicked value by user)
           if (n.Text == ".") // for decimal to not to repeat
            {
                if(!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + n.Text; // If decimal is clicked it appears otherwise not.

            }
           else
            textBox.Text = textBox.Text + n.Text;





        }

        private void op_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if (resultValue != 0)
            {
                nequal.PerformClick(); // automatically perform equal key function.
                opPerformed = n.Text;

                lcurrentop.Text = resultValue + " " + opPerformed;
                isopPerformed = true;

            }
            else
            {
                opPerformed = n.Text;
                resultValue = Double.Parse(textBox.Text);  //(parse is a method which converts numbers and returns it), and we need value 
                                                           //to return to textbox.

                lcurrentop.Text = resultValue + " " + opPerformed;
                isopPerformed = true; //to; when clicked on any operation.. the operation become true.

            }
        }

        private void nequal_Click(object sender, EventArgs e)
        {
            switch (opPerformed) //So it compares following cases.......
            {
                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString(); // this converts double to string and shows
                                                                                          // result in textbox.
                    break;

                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;

                case "*":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;

                case "/":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;

                default:
                    break;



            }

            resultValue = Double.Parse(textBox.Text);
            lcurrentop.Text = "";
        }

        private void nC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }
    }
}