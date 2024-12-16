Hands-On Exercises: Visual Studio Code
===============================================================================
Open the LINQHandsOn.code-workspace
When prompted to add "Required Assets", Click the 'Yes' button
Select the menu Terminal | Run Task... | test LINQHandsOn.Tests
To run a single test, open a Terminal window and enter the following command
   dotnet test --filter "Name=GetAllQuery"


Hands-On Exercises: Visual Studio 2022
===============================================================================
Open the LINQHandsOn.sln
Select the menu Test | Run All Tests
To run a single test, right mouse-click in the method body and select Run Tests


Creating your Hands-On Exercises
===============================================================================
After watching each module, open the corresponding Module??Tests.cs class
  For example, after watching Module 3, open Module03Tests.cs
Locate the <summary> comments above the method and follow the instuctions on the LINQ query to write
Run the test that has the same method name as the one in which you wrote your LINQ query
If you have written the query successfully, the test should pass.
