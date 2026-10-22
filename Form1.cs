using System;
using System.Windows.Forms;

namespace Assignment2Q2
{
    public partial class Form1 : Form
    {
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnCalculate;
        private Label lblResult;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomControls();
        }

        private void InitializeCustomControls()
        {
          
            this.Text = "Assignment 2 - Q2 Sum Calculator";
            this.Width = 340;
            this.Height = 310;
            this.StartPosition = FormStartPosition.CenterScreen;

         
            txtNum1 = new TextBox();
            txtNum1.Name = "txtNum1";
            txtNum1.Left = 30;
            txtNum1.Top = 30;
            txtNum1.Width = 250;

          
            txtNum2 = new TextBox();
            txtNum2.Name = "txtNum2";
            txtNum2.Left = 30;
            txtNum2.Top = 75;
            txtNum2.Width = 250;

          
            btnCalculate = new Button();
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Text = "Calculate Sum";
            btnCalculate.Left = 30;
            btnCalculate.Top = 125;
            btnCalculate.Width = 250;
            btnCalculate.Height = 35;
            btnCalculate.Click += new EventHandler(this.btnCalculate_Click);

           
            lblResult = new Label();
            lblResult.Name = "lblResult";
            lblResult.Text = "Result: ";
            lblResult.Left = 30;
            lblResult.Top = 185;
            lblResult.Width = 250;

          
            this.Controls.Add(txtNum1);
            this.Controls.Add(txtNum2);
            this.Controls.Add(btnCalculate);
            this.Controls.Add(lblResult);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (double.TryParse(txtNum1.Text, out double num1) &&
                    double.TryParse(txtNum2.Text, out double num2))
                {
                   
                    double sum = num1 + num2;
                    lblResult.Text = $"Result: {sum}";
                }
                else
                {
                    
                    MessageBox.Show("Please enter valid numeric values in both text boxes.",
                                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
