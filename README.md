# GA_Prog2_BtnTextLbl_Access

# Requirements
1. Create a .Net Maui project
2. Add A label that says number 1
3. Add a Entry ( Text Box ) with a name `txtNumber1`.
4. Add a 2nd label that says number2.
5. Add a 2nd Entry ( Text Box ) what a name of `txtNumber2`.
6. Add a Label with a name of `lblResult`
7. Add a button with the Text of `Add` and a name of `btnAdd`.
	* Add a click event

8. In the code for your click event. Write the code so when the Add Button is clicked, you 
	1. grab the two text boxes. 
	2. Parse the text into double. and then 
	3. perform addition. 
	4. Display the result to the `lblResult`

9. With this is done, on the `MainPage.xaml` add 3 more buttons. 
	1. Subtract Button - Name=`btnSubtract`
	2. Multiply Button - Name=`btnMultiply`			
	3. Divide Button - Name=`btnDivide`

10. Add events to each button and write the code for each one to perform the correct math and display to `lblResult`

## Step By Step

### Work in Progress

### 1. Create a .NET MAUI Project
Open Visual Studio.

Click on "Create a new project".

Search for "MAUI" in the project templates and select “.NET MAUI App”.

Click "Next".

Name your project, choose a location, and click "Create".

### 2. Add UI Elements to MainPage.xaml

Add a Label for Number 1:

```xml
<Label Text="Number 1" />
```

Add a Text Box for the First Number:

```xml
<Entry x:Name="txtNumber1" Placeholder="Enter number 1" Keyboard="Numeric" />
```

Add a Label for Number 2:

```xml
<Label Text="Number 2" />
```

Add a Text Box for the Second Number:

```xml
<Entry x:Name="txtNumber2" Placeholder="Enter number 2" Keyboard="Numeric" />
```

Add a Label to Display Result:

```xml
<Label x:Name="lblResult" Text="Result will be shown here" />
```

Add an 'Add' Button:

```xml
<Button Text="Add" x:Name="btnAdd" Clicked="OnAddButtonClicked" />
```
### 3. Implement the Add Button Click Event in MainPage.xaml.cs

Define the Click Event Method:

```csharp
private void OnAddButtonClicked(object sender, EventArgs e)
{
    double.TryParse(txtNumber1.Text, out double num1);
    double.TryParse(txtNumber2.Text, out double num2);
    double result = num1 + num2;
    lblResult.Text = $"Result: {result}";
}
```
### 4. Add More Buttons and Their Click Events

Add More Buttons in MainPage.xaml:
```xml
<Button Text="Subtract" x:Name="btnSubtract" Clicked="OnSubtractButtonClicked" />
<Button Text="Multiply" x:Name="btnMultiply" Clicked="OnMultiplyButtonClicked" />
<Button Text="Divide" x:Name="btnDivide" Clicked="OnDivideButtonClicked" />
```

Implement Click Events in MainPage.xaml.cs:

Subtract Button:

```csharp
private void OnSubtractButtonClicked(object sender, EventArgs e)
{
    double.TryParse(txtNumber1.Text, out double num1);
    double.TryParse(txtNumber2.Text, out double num2);
    double result = num1 - num2;
    lblResult.Text = $"Result: {result}";
}
```

Multiply Button:
```csharp
private void OnMultiplyButtonClicked(object sender, EventArgs e)
{
    double.TryParse(txtNumber1.Text, out double num1);
    double.TryParse(txtNumber2.Text, out double num2);
    double result = num1 * num2;
    lblResult.Text = $"Result: {result}";
}
```

Divide Button:
```csharp
private void OnDivideButtonClicked(object sender, EventArgs e)
{
    double.TryParse(txtNumber1.Text, out double num1);
    double.TryParse(txtNumber2.Text, out double num2);
    if (num2 != 0)
    {
        double result = num1 / num2;
        lblResult.Text = $"Result: {result}";
    }
    else
    {
        lblResult.Text = "Cannot divide by zero";
    }
}
```