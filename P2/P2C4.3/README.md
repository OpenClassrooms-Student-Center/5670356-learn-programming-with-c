# Run the code

- Click on the green Run button to compile and execute the application.
- Type in the terminal or PowerShell console in Visual Studio, "dotnet run 3 9 4". What does it produce as output? Why do you get an integer value?
- Type in the terminal or PowerShell console in Visual Studio, "dotnet run". Why does the program crash?
- Note the name of the exception mentioned in the call trace, DivideByZeroException.

# Protection against empty arguments

- Open the Program.cs file. Surround the code (starting from List<int>...) with a try block.
- Add a catch block that takes as a parameter the exception mentioned in the call trace from the previous step.
- Inside the catch block, add a Console.WriteLine statement with a relevant message for the user, asking them to provide integer numeric arguments.
- Compile and execute your program with and without providing arguments.
- The call trace should now be replaced by the message you wrote inside your catch block.
- Bonus: add another catch statement to protect against non-numeric arguments, as shown in the course.