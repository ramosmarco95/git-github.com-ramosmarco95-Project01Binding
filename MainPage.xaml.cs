namespace Project01Binding
{
    public partial class MainPage : ContentPage
    {

        private string _binaryInput = "";

        public MainPage()
        {
            InitializeComponent();
        }
     
        private void OnZeroClicked(object sender, EventArgs e)
        {
            AppendBinaryDigit("0");
        }

        private void OnOneClicked(object sender, EventArgs e)
        {
            AppendBinaryDigit("1");
        }

        private void AppendBinaryDigit( string digit)
        {
            if (_binaryInput.Length < 32)
            {
                _binaryInput += digit;
                lblBinary.Text = _binaryInput;
                UpdateDecimalValue();
            }
        }

        private void UpdateDecimalValue()
        {
            if (!String.IsNullOrEmpty(_binaryInput))
                lblDecimal.Text = Convert.ToInt32(_binaryInput, 2).ToString();
            else
                lblDecimal.Text = "0";
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            _binaryInput = "";
            lblBinary.Text = "0";
            lblBinary.Text = "0";
        }

        private void OnClearEntryClicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_binaryInput))
            {
                _binaryInput = _binaryInput.Substring(0, _binaryInput.Length - 1);
                lblBinary.Text = String.IsNullOrEmpty(_binaryInput) ? "0" : _binaryInput;
                UpdateDecimalValue();
            }
        }
    }

}
