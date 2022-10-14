namespace Activity4App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            float storeFloatConversion;//Variable to store string value converted to float
            storeFloatConversion = float.Parse(textBoxInput.Text); //Textbox input converted to float
            //If the number of seconds is greater than or equal to 60, display the number of minutes in that many seconds.
            if (storeFloatConversion >= 60 && storeFloatConversion < 3600)
            {

                float minutes = storeFloatConversion / 60;
                outputResultLabel.Text = Convert.ToString(minutes) + " mins";


            }
            //If the number of seconds is greater than or equal to 3600, display the number of hours in that many seconds.
            if (storeFloatConversion >= 3600 && storeFloatConversion < 86400)
            {
                float hours = (storeFloatConversion / 60)/60; // variable to store number of hours
                outputResultLabel.Text = Convert.ToString(hours) + " hrs"; //Convert hours to string and assign it to outputResultLabel.Text



            }
            // If the number of seconds is greater than or equal to 86,400, display the number of days in that many seconds.
            if (storeFloatConversion >= 86400)
            {
                float days = ((storeFloatConversion / 60)/60)/24; //variable to store number of days
                outputResultLabel.Text = Convert.ToString(days) + " days";


            }






        }
    }
}