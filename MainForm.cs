
using System.Reflection.Metadata.Ecma335;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private BMICalculator bmiCalc = new BMICalculator();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();

            if (ok)
            {
                DisplayResults(); // calculate and display results
            }
        }

        private void DisplayResults()
        {
            lblResultYourBmi.Text = bmiCalc.CalculateBMI().ToString("f2");
            lblResultWeightCategory.Text = bmiCalc.BmiWeightCategory().ToString();
            grpResults.Text = "Results for " + bmiCalc.GetName();
        }

        private void InitializeGUI()
        {
            this.Text = "BMI Calculator";

            rbtnMetric.Checked = true;
            lblHeight.Text = "Height (cm)";
            lblWeight.Text = "Weight (kg)";

            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                bmiCalc.SetUnit(UnitTypes.Metric);
            }
        }

        private void rbtnUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUsUnit.Checked)
            {
                lblHeight.Text = "Height (inches)";
                lblWeight.Text = "Weight (lbs)";
                bmiCalc.SetUnit(UnitTypes.American);
            }
        }

        private bool ReadInputBMI()
        {
            bool ok = ReadHeight() && ReadWeight(); // Check both height and weight
            return ok;
        }

        private bool ReadHeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(txtHeight.Text, out outValue);

            if (ok)
            {
                if (outValue > 0)
                {
                    if (bmiCalc.GetUnit() == UnitTypes.American)
                    {
                        bmiCalc.SetHeight(outValue * 12.00);
                    }
                    else
                    {
                        bmiCalc.SetHeight(outValue / 100.0);
                    }
                }
                else
                {
                    ok = false;
                }
            }

            if (!ok)
            {
                MessageBox.Show("Invalid height value!", "Error");
            }

            return ok;
        }

        private void ReadName()
        {
            string name = txtName.Text.Trim();
        }

        private bool ReadWeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(txtWeight.Text, out outValue);

            if (outValue > 0)
                return ok;

            if (!ok)
            {
                MessageBox.Show("Invalid Weight value!", "Error");
            }

            return ok;
        }
    }
}
