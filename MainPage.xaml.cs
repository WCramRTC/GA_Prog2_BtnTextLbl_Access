namespace GA_Prog2_BtnTextLbl_Access
{
    public partial class MainPage : ContentPage
    {

        public MainPage() // <----- This method runs when the application opens, It's like our main
        {
            InitializeComponent();
            
        } // MainPage()


        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            // Quick Steps
            // 1. Declare 2 strings and save the values in the text boxes to these strings.
            // 2. Declare 2 doubles, and parse the strings into doubles.
            // 3. Declare another double that will hold the result of adding our 2 numbers together.
            // 4. Display the result to our label


            // Step 1
            // 1. We declare a string variable with the name userNumber1. We will use this to hold the number the user types in the first text box, which we've given the name txtNumber1.
            // 2. We assign the value of txtNumber1.Text to our userNumber1 variable. 
            // By doing the textboxname ( here it's txtNumber1 ) followed by .Text we are grabbing the text from that text box. The values ALWAYS come back as a string.
            string userNumber1 = txtNumber1.Text;
            // We repeat this process for the second text box
            string userNumber2 = txtNumber2.Text;

            // Step 2
            // Since text coming from a text box is always a string, we need to convert it into a number. That is because if we try to add 2 strings, it just forms one LONG string. This is known as concatenation. But if we PARSE the string into a different type, here a double, it converts it into a value you can perform math with.
            // 1. Declare a new double with a name of number 1.
            // 2. Next we do eqauls followed by double.Parse(userNumber1);
            // double.Parse() takes a string and will try to convert it into a double type ( which holds decimal numbers ).
            // We are passing in our variable, userNumber1, that should be holding the users number, trying to convert it.
            double number1 = double.Parse(userNumber1);
            // 3. We do this again with userNumber 2
            double number2 = double.Parse(userNumber2);

            // Step 3
            // 1. Declare another double, this time called result
            // 2. Do equals and then assign number1 + number2.
            // Result : The result should perform the math and save the result to our new variable
            double result = number1 + number2;

            // Step 4
            // Now we will display our result to our label from the .xaml page. This shows the user the result.
            // 1. To assign a value to our lblResult from our front end, we need to use ITS .Text property.
            // 2. Next we assign the value of result to lblResult.Text.
            // 3. Because result is a double, and .Text is expecting a string, we have to do result.ToString() to convert result back to a string.
            lblResult.Text = result.ToString();

            // End Result
            // If everything works, when you enter in 2 numbers to our text boxes and press the button, it should add both numbers together and display the result.

        } // btnAdd_Clicked

        private void btnSubtract_Clicked(object sender, EventArgs e)
        {
            // Quick Steps
            // 1. Declare 2 strings and save the values in the text boxes to these strings.
            // 2. Declare 2 doubles, and parse the strings into doubles.
            // 3. Declare another double that will hold the result of subtracting our 2 numbers.
            // 4. Display the result to our label

            // Step 1 - Declare 2 strings here and assign the values from the text boxes
            string userNumber1 = txtNumber1.Text;
            string userNumber2 = txtNumber2.Text;

            // Step 2 - Declare 2 double variables and parse the strings
            double number1 = double.Parse(userNumber1);
            double number2 = double.Parse(userNumber2);

            // Step 3 - Declare a variable to hold the result, subtract 1 number from another
            double result = number1 - number2;

            // Step 4 - Display result to our label
            lblResult.Text = result.ToString();
        }

        private void btnMultiply_Clicked(object sender, EventArgs e)
        {
            // Quick Steps
            // 1. Declare 2 strings and save the values in the text boxes to these strings.
            // 2. Declare 2 doubles, and parse the strings into doubles.
            // 3. Declare another double that will hold the result of multiplying our 2 numbers.
            // 4. Display the result to our label

            // Step 1 - Declare 2 strings here and assign the values from the text boxes
            string userNumber1 = txtNumber1.Text;
            string userNumber2 = txtNumber2.Text;

            // Step 2 - Declare 2 double variables and parse the strings
            double number1 = double.Parse(userNumber1);
            double number2 = double.Parse(userNumber2);

            // Step 3 - Declare a variable to hold the result, subtract 1 number from another
            double result = number1 * number2;

            // Step 4 - Display result to our label
            lblResult.Text = result.ToString();
        }

        private void btnDivide_Clicked(object sender, EventArgs e)
        {
            // Quick Steps
            // 1. Declare 2 strings and save the values in the text boxes to these strings.
            // 2. Declare 2 doubles, and parse the strings into doubles.
            // 3. Declare another double that will hold the result of divide our 2 numbers.
            // 4. Display the result to our label

            // Step 1 - Declare 2 strings here and assign the values from the text boxes
            string userNumber1 = txtNumber1.Text;
            string userNumber2 = txtNumber2.Text;

            // Step 2 - Declare 2 double variables and parse the strings
            double number1 = double.Parse(userNumber1);
            double number2 = double.Parse(userNumber2);

            // Step 3 - Declare a variable to hold the result, subtract 1 number from another
            double result = number1 / number2;

            // Step 4 - Display result to our label
            lblResult.Text = result.ToString();
        }
    } // class

} // namespace


// Example Code
//private void btnDisplayName_Clicked(object sender, EventArgs e)
//{
//    string name = entName.Text;

//    name += " and Arjun";

//    lblResult.Text = name;
//}