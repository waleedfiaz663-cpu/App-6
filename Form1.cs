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
            // Form settings (increased height for better spacing)
            this.Text = "Assignment 2 - Q2 Sum Calculator";
            this.Width = 340;
            this.Height = 310;
            this.StartPosition = FormStartPosition.CenterScreen;

            // First TextBox (txtNum1)
            txtNum1 = new TextBox();
            txtNum1.Name = "txtNum1";
            txtNum1.Left = 30;
            txtNum1.Top = 30;
            txtNum1.Width = 250;

            // Second TextBox (txtNum2)
            txtNum2 = new TextBox();
            txtNum2.Name = "txtNum2";
            txtNum2.Left = 30;
            txtNum2.Top = 75;
            txtNum2.Width = 250;

            // Button (btnCalculate) - increased height and spacing
            btnCalculate = new Button();
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Text = "Calculate Sum";
            btnCalculate.Left = 30;
            btnCalculate.Top = 125;
            btnCalculate.Width = 250;
            btnCalculate.Height = 35;
            btnCalculate.Click += new EventHandler(this.btnCalculate_Click);

            // Label (lblResult) - adjusted position below the button
            lblResult = new Label();
            lblResult.Name = "lblResult";
            lblResult.Text = "Result: ";
            lblResult.Left = 30;
            lblResult.Top = 185;
            lblResult.Width = 250;

            // Add controls to the form window
            this.Controls.Add(txtNum1);
            this.Controls.Add(txtNum2);
            this.Controls.Add(btnCalculate);
            this.Controls.Add(lblResult);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Read two numbers when the button is clicked with input validation
                if (double.TryParse(txtNum1.Text, out double num1) &&
                    double.TryParse(txtNum2.Text, out double num2))
                {
                    // Calculate their sum and display the result
                    double sum = num1 + num2;
                    lblResult.Text = $"Result: {sum}";
                }
                else
                {
                    // Handle invalid numeric input appropriately
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