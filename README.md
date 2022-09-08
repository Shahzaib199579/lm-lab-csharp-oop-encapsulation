# A Short Exercise to Explore Object-Oriented Programming - C# - Encapsulation

---
## Overview

This repository is a short exercise designed for you to explore **Encapsulation** which is one of the
four pillars of Object-Oriented Programming (OOP).

---
## 📖 Instructions

- Fork this repository

- To run the program, go to [Program.cs](/Encapsulation/Encapsulation/Program.cs) which is the entry point and run it using Visual Studio.

- 💡 You will notice that as of .NET 6+, the code you would need to write for a new program has been simplified. You can learn more [here](https://docs.microsoft.com/en-us/dotnet/core/tutorials/top-level-templates).

- There are two models `DodgyBankAccount` and `SecureBankAccount`, these are located in the [Models](/Encapsulation/Encapsulation/Models/) directory.

---
## 🤓 Study Prompts

Use the following questions to guide your exploration and learning! 🗺

- Run your Console application, what is it doing? What is being outputted to the console?
- Ans: The application is making object of `DodgyBankAccount` first. After the account is created and an amount is deposited then we see that a reward is added to the acount. The `DodgyBankAccount` object is then used to add rewards directly. After seeing that the account balance is accessible and can be changed then the object is used to change the balance of the account itself. In the second half of the execution, the `SecureBankAccount` class object is created with an account number. An amount is deposited so a reward is added to account as before. Then Code tries to add rewards directly and then change the amount in the account but it is not possible because the methods and fields are private in the class so they can not be accessed.

- Look at the `DodgyBankAccount`, this class is not well-encapsulated. Can you note down the problems with how the class is designed, and the ways it is being misused?
- Ans: In the class, the variables are not private so they can be accessed outside of the class. Same is true for the important methods that are used to add amounts to the bank account.

- Compare and contrast the `DodgyBankAccount` and the `SecureBankAccount`, how is the `SecureBankAccount` different to the `DodgyBankAccount`? How is it designed to prevent it from being misused? Are there instances of better method names for clearer abstraction?
- Ans: In the `SecureBankAccount`, the important variables and methods are private so they can not be accessed outside the class and as such the class is secure.

---
## 🐸 Extension Challenge

- Now that you've had the chance to explore a well-encapsulated vs. poorly-encapsulated class,
your next challenge is to put your newly minted skills into practice 💪!

- Refactor the `WeatherReporter` class located in the [Models](/Encapsulation/Encapsulation/Models/) directory.

- You may want to think about Encapsulation here. Do the methods follow the Single Responsibility Principle (SRP)? Are the method names suitable? Are there any magic numbers / hardcoded numbers in the code that needs to be represented by a constant? Are there better ways to write the code?

- As an added challenge, could you write some unit tests to test the class' methods?
