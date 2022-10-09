namespace BMI_Calculator
{
    public partial class BMIforum : Form
    {
        public BMIforum()
        {
            InitializeComponent();
        }
       float result;
        public void Category()
        {
            if (result > 40)
            {
                WeightC_Label.Text = "Ağırçəkili (Piylənmə tip III)";
            }
            else if (35.0 <= result)
            {
                WeightC_Label.Text = "Ağırçəkili (Piylənmə tip II)";
            }
            else if (30.0 <= result)
            {
                WeightC_Label.Text = "Ağırçəkili (Piylənmə tip I)";
            }
            else if (25.0 <= result)
            {
                WeightC_Label.Text = "Ağırçəkili (Ön Piylənmə)";
            }
            else if (18.5 <= result)
            {
                WeightC_Label.Text = "Normal çəkili";
            }
            else
            {
                WeightC_Label.Text = "Aşağı çəkili";
            }
        }
        public void BMI()
        {
            result = float.Parse(textBoxHeight.Text) / ((float.Parse(textBoxWeight.Text) / 100) * (float.Parse(textBoxWeight.Text) / 100));
            Result_Label.Text = result.ToString();
        }
        private void Calc_button_Click(object sender, EventArgs e)
        {
            try
            {   if (float.Parse(textBoxHeight.Text) > 0 && float.Parse(textBoxWeight.Text) > 0)
                {
                    BMI();
                    Category();
                }
                else
                {
                    MessageBox.Show("Uzunluq və Çəki 0'dan yuxarı olmalıdır !");
                }
            }
            catch
            {
                MessageBox.Show("Daxil etdiyiniz rəqəm təşkil etməlidir !");
            }
        }
    }
}