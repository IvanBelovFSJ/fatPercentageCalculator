/*
*Author: Ivan Belov
*Student ID: T00637195
*Lab#2 - C#
*Date Created: October 23, 2019
*Due Date: October 24, 2019
*/
using System;
using System.Windows.Forms;

namespace FatPercentageCalculator_October_2019
{
    public partial class Form : System.Windows.Forms.Form
    {
        /*
        *Below you could observe variable declaration,
        *few constants facilitating logical operations.
        */
        const double fatMultiplier = 9.0;
        const double oneHundreed = 100.0;
        const double thirty = 30.0;
        double enterCalories, enterFat, calcCalories, calcPercFat;

        /*
        *clearButton serves purpose of reloading
        *the form to perform multiple calculations
        per one app start.
        */
        private void clearButton_Click(object sender, EventArgs e)
        {
            caloriesTextBox.Text = null;
            fatTextBox.Text = null;
            caloriesNumLabel.Text = null;
            fatPercentageLabel.Text = null;
            enterCalories = 0;
            enterFat = 0;
            calcCalories = 0;
            calcPercFat = 0;
        }

        /*
        *Loading the form, and its components.
        */
        public Form()
        {
            InitializeComponent();
        }

        /*
        *Exit button closes the application,
        *and releases its's resources.
        */
        private void exitButton_Click(object sender, EventArgs e)
        {
            clearButton_Click(sender,e);
            Application.Exit();
        }

        /*
        *calculateButton_Click event facilitates the error check,
        * and calculation of the fat percent in a given type of food.
        *
        */
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // error check calorie value
            if ((double.TryParse(caloriesTextBox.Text, out enterCalories)))
            {
                // error check fat value
                if ((double.TryParse(fatTextBox.Text, out enterFat)))
                {
                    // program request error check
                    if (enterCalories <= 0)
                    {
                        MessageBox.Show("Calories should be greater then zero.");
                        clearButton_Click(sender, e);
                    }
                    else
                    {
                        calcCalories = enterFat * fatMultiplier;
                        // program request error cehck
                        if (calcCalories > enterCalories)
                        {
                            MessageBox.Show("Fat calories can not be greater then total calories.");
                            clearButton_Click(sender, e);}
                        else
                        {
                            caloriesNumLabel.Text = calcCalories.ToString();
                            calcPercFat = (calcCalories / (enterCalories / oneHundreed));
                            fatPercentageLabel.Text = calcPercFat.ToString();

                            if (lofFatCheckBox.Checked == true && calcPercFat < thirty)
                            {
                                MessageBox.Show("This is a low fat food.");
                            }}}}
                else{
                    MessageBox.Show("Invalid Fat Value!");
                    clearButton_Click(sender, e);}}
            else{
                MessageBox.Show("Invalid Calorie Value!");
                clearButton_Click(sender, e);}}}} // End of application.
