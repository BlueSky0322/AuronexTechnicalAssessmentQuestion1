# Technical Assessment Question #1
![image](https://github.com/BlueSky0322/AuronexTechnicalAssessmentQuestion1/assets/60435524/7a23cbd1-ee20-4053-b746-87ccfb9e03d8)

# Getting Started
Create a .NET Console App as project. 

# Technologies Used
- Microsoft .NET Framework Console Application using Microsoft Studio 2022
- Visual Studio Installer for modifying installations

# Expected Output
![image](https://github.com/BlueSky0322/AuronexTechnicalAssessmentQuestion1/assets/60435524/f46e6892-6f72-4f95-81e6-a4810b5c2f32)

# Reasoning
The condition if `(i % 3 == 0 && i % 5 == 0)` must come before all other conditions in the FizzOrBuzz method to ensure that the case where the number is divisible by both 3 and 5 (i.e., the condition for "fizzbuzz") is checked first. If this condition is placed after the conditions for divisibility by 3 `(i % 3 == 0)` or 5 `(i % 5 == 0)`, those conditions will also be evaluated, and the "fizzbuzz" condition will never be reached for numbers that satisfy both the conditions for "fizz" and "buzz."
