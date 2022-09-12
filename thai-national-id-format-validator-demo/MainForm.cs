using thai_national_id_format_validator;

namespace thai_national_id_format_validator_demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tbxThaiID_TextChanged(object sender, EventArgs e)
        {
            if (ThaiNationalIdFormat.IsValidate(tbxThaiID.Text))
            {
                lblResult.Text = "Valid";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = "Invalid";
                lblResult.ForeColor = Color.Red;
            }
        }
    } // class
} // namespace