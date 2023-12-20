#region Assignment 1: Conditional Statements
////: In a bank, you have been given the task is to create a program that checks if a customer is 
//eligible for a loan based on their credit score and income. The eligibility criteria are as follows:
//• Credit Score must be above 700.
//• Annual Income must be at least $50,000.

//Tasks:
//1.Write a program that takes the customer's credit score and annual income as input.
//2. Use conditional statements (if-else) to determine if the customer is eligible for a loan.
//3. Display an appropriate message based on eligibility.

//#region Getting Customer Credit Score and Annual Income
//Console.WriteLine("Welcome to .NET Bank");
//Console.WriteLine("Know your Credit Score within 2 steps\n");
//Console.WriteLine("1. Enter your Credit Score");
//int creditScore = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//Console.WriteLine("2. Enter your Annual Income");
//int annualIncome = int.Parse(Console.ReadLine());
//Console.WriteLine("");
//#endregion

//#region Checking if Customer is eligible for Loan and displaying an appropriate message based on eligibility
//if (creditScore > 700 &&  annualIncome > 50000)
//{
//    Console.WriteLine("Congratulations!, You are eligible for the Loan");
//}
//else
//{
//    Console.WriteLine("We regret to inform you that you are not eligible for the Loan");
//}
//#endregion

#endregion

#region Assignment 2: Nested Conditional Statements
//Create a program that simulates an ATM transaction. Display options such as "Check 
//Balance," "Withdraw," "Deposit,". Ask the user to enter their current balance and the amount they want 
//to withdraw or deposit. Implement checks to ensure that the withdrawal amount is not greater than the 
//available balance and that the withdrawal amount is in multiples of 100 or 500. Display appropriate 
//messages for success or failure.

//Console.WriteLine("Welcome to .NET ATM");
//int userPin = 1131;
//Console.WriteLine("\nPlease Enter your Pin Number");
//int userEnteredPin = int.Parse(Console.ReadLine());
//if(userEnteredPin == userPin)
//{
//    Console.WriteLine("\nPlease Enter your Balance");
//    int userBalance = int.Parse(Console.ReadLine());
//    string choice = @"Please Choose From Below:
//Press 1 for Check Balance
//Press 2 for Withdraw
//Press 3 for Deposit";
//    Console.WriteLine($"\n{choice}");
//    int userChoice = int.Parse(Console.ReadLine());
//    switch (userChoice)
//    {
//        case 1:
//            Console.WriteLine($"\nYour Balance Amount is Rs {userBalance}");
//            break;
//        case 2:
//            Console.WriteLine($"\nPlease enter your Withdrawal Amount");
//            int withdrawalAmount = int.Parse(Console.ReadLine());
//            if((withdrawalAmount % 500 == 0) || (withdrawalAmount % 100 == 0))
//            {
//                if (withdrawalAmount < userBalance)
//                {
//                    userBalance = userBalance - withdrawalAmount;
//                    Console.WriteLine($"\nAn amount of Rs {withdrawalAmount} is withdrawn from your Account\nAvailable Balance is Rs {userBalance}");
//                }
//                else
//                {
//                    Console.WriteLine($"\nYour Withdrawal Amount Exceeds the Balance of your Account");
//                }
//            }
//            else
//            {
//                Console.WriteLine($"\nPlease enter your Withdrawal Amount in multiples of 500 or 100");
//            }
//            break;
//        case 3:
//            Console.WriteLine($"\nPlease enter the your Deposit Amount");
//            int depositAmount = int.Parse(Console.ReadLine());
//            userBalance = userBalance + depositAmount;
//            Console.WriteLine($"\nAn amount of Rs {depositAmount} is deposited to your Account\nAvailable Balance is Rs {userBalance}");
//            break;
//    }
//}
//else
//{
//    Console.WriteLine("\nInvalid Pin Number");
//}
#endregion

#region Assignment 3: Loop Structures
//You are responsible for calculating compound interest on savings accounts for bank 
//customers. You need to calculate the future balance for each customer's savings account after a certain 
//number of years.

//Tasks:
//1. Create a program that calculates the future balance of a savings account.
//2. Use a loop structure (e.g., for loop) to calculate the balance for multiple customers.
//3. Prompt the user to enter the initial balance, annual interest rate, and the number of years.
//4. Calculate the future balance using the formula: future_balance = initial_balance * (1 + annual_interest_rate / 100) ^ years.
//5. Display the future balance for each customer.

//Console.WriteLine("Welcome to .NET Bank");
//Console.WriteLine("Know your Future Balance in three Steps");
//for(int i = 1; i < 4; i++)
//{
//    Console.WriteLine($"\nCustomer No: {i}");
//    Console.WriteLine("Please Enter your Initial Balance");
//    double initialBalance = double.Parse(Console.ReadLine());
//    Console.WriteLine("Please Enter your Annual Interest Rate");
//    double annualInterestRate = double.Parse(Console.ReadLine());
//    Console.WriteLine("Please Enter (No of years from today) to calculate your Future Savings");
//    double noOfYears = int.Parse(Console.ReadLine());
//    double calculatedBalance = (1 + (annualInterestRate / 100));
//    double futureBalance = Math.Pow(calculatedBalance, noOfYears);
//    futureBalance = futureBalance * initialBalance;
//    Console.WriteLine($"Your Future Balance from {noOfYears} years is {futureBalance}");
//}
#endregion

#region Assignment 4: Looping, Array and Data Validation
//Scenario: You are tasked with creating a program that allows bank customers to check their account 
//balances. The program should handle multiple customer accounts, and the customer should be able to 
//enter their account number, balance to check the balance.
//Tasks:
//1.Create a Python program that simulates a bank with multiple customer accounts.
//2. Use a loop (e.g., while loop) to repeatedly ask the user for their account number and 
//balance until they enter a valid account number.
//3. Validate the account number entered by the user.
//4. If the account number is valid, display the account balance. If not, ask the user to try again

//using System.ComponentModel;

//Console.WriteLine("Welcome to .NET Bank");
//Console.WriteLine("Check your Account Balance with 1 step\n");
//int[] accountNumber = {123456,654321};
//for(int i = 0; i < accountNumber.Length; i++)
//{
//    Console.WriteLine($"Customer Number {i+1} :: Enter your Account Number");
//    int accNo = int.Parse(Console.ReadLine());
//    Console.WriteLine("Enter your Bank Balance");
//    int bankBalance = int.Parse(Console.ReadLine());
//    while (accNo != accountNumber[i])
//    {
//        Console.WriteLine("\nTry Again\n");
//        Console.WriteLine($"Customer Number {i + 1} :: Enter your Account Number");
//        accNo = int.Parse(Console.ReadLine());
//        Console.WriteLine("Enter your Bank Balance");
//        bankBalance = int.Parse(Console.ReadLine());
//    }
//    Console.WriteLine($"\nWelcome! Account No: {accountNumber[i]}");
//    Console.WriteLine($"Your available bank balance is {bankBalance}\n");
//}
#endregion

#region Assignment 5: Password Validation 
//Write a program that prompts the user to create a password for their bank account. Implement if 
//conditions to validate the password according to these rules:
//• The password must be at least 8 characters long.
//• It must contain at least one uppercase letter.
//• It must contain at least one digit.
//• Display appropriate messages to indicate whether their password is valid or not.

//using System.Reflection.Emit;

//Console.WriteLine("Welcome to .NET Bank");
//Console.WriteLine("Check your Account with 2 steps\n");
//restart:
//Console.WriteLine("Please Enter your Password");
//string password = Console.ReadLine();
//if(password.Length >= 8)
//{
//    if (password.Any(char.IsUpper))
//    {
//        if (password.Any(char.IsDigit))
//        {
//            Console.WriteLine("\nYour password was Successfully created!");
//        }
//        else
//        {
//            Console.WriteLine("It must contain at least one digit\n");
//            goto restart;
//        }
//    }
//    else
//    {
//        Console.WriteLine("It must contain at least one uppercase letter.\n");
//        goto restart;
//    }
//}
//else
//{
//    Console.WriteLine("The password must be at least 8 characters long\n");
//    goto restart;
//}

#endregion

#region Assignment 6
//Create a program that maintains a list of bank transactions (deposits and withdrawals) for a customer. 
//Use a while loop to allow the user to keep adding transactions until they choose to exit. Display the 
//transaction history upon exit using looping statements.

//Console.WriteLine("Welcome to .NET Bank");
//List<string> depositsAndWithdrawals = new List<string>();
//bool start = true;
//while (start)
//{
//    Console.WriteLine("\nAdd Transactions");
//    string transaction = Console.ReadLine();
//    depositsAndWithdrawals.Add(transaction);
//    Console.WriteLine("\nDo you wish to Continue\n 1.Yes 2.No");
//    int choice = int.Parse(Console.ReadLine());
//    if (choice == 2)
//    {
//        start = false;
//    }
//}
//Console.WriteLine("\nTransactions History\n");
//int i = 1;
//foreach (string dw in depositsAndWithdrawals)
//{
//    Console.WriteLine($"Transaction {i}");
//    Console.WriteLine($"{dw}\n");
//    i++;
//}
#endregion


/*using Assignment8;
public class BankApp
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank();
        while (true)
        {
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Calculate Interest");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Call bank.CreateAccount() method
                    Console.Write("Enter Account Type (1 for Savings, 2 for Current): ");
                    int accountType = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Customer Name: ");
                    string customerName = Console.ReadLine();
                    Console.Write("Enter Initial Balance: ");
                    decimal balance = Convert.ToDecimal(Console.ReadLine());
                    if (accountType == 1)
                    {
                        Console.Write("Enter Interest Rate: ");
                        decimal interestRate = Convert.ToDecimal(Console.ReadLine());
                        bank.CreateAccount(new SavingsAccount(0, customerName, balance, interestRate));
                    }
                    else if (accountType == 2)
                    {
                        Console.Write("Enter Overdraft Limit: ");
                        decimal overdraftLimit = Convert.ToDecimal(Console.ReadLine());
                        bank.CreateAccount(new CurrentAccount(0, customerName, balance, overdraftLimit));
                    }
                    break;
                case 2:
                    // Call bank.Deposit() method
                    Console.Write("Enter Account Number: ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    float amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Deposit(accountNumber, amount);
                    break;
                case 3:
                    // Call bank.Withdraw() method
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Withdraw(accountNumber, amount);
                    break;
                case 4:
                    // Call bank.CalculateInterest() method
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    bank.CalculateInterest(accountNumber);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}﻿using Assignment9;
public class BankApp
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank();
        while (true)
        {
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Calculate Interest");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Call bank.CreateAccount() method
                    Console.Write("Enter Account Type (1 for Savings, 2 for Current): ");
                    int accountType = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Customer Name: ");
                    string customerName = Console.ReadLine();
                    Console.Write("Enter Initial Balance: ");
                    decimal balance = Convert.ToDecimal(Console.ReadLine());
                    if (accountType == 1)
                    {
                        Console.Write("Enter Interest Rate: ");
                        decimal interestRate = Convert.ToDecimal(Console.ReadLine());
                        bank.CreateAccount(new SavingsAccount(0, customerName, balance, interestRate));
                    }
                    else if (accountType == 2)
                    {
                        Console.Write("Enter Overdraft Limit: ");
                        decimal overdraftLimit = Convert.ToDecimal(Console.ReadLine());
                        bank.CreateAccount(new CurrentAccount(0, customerName, balance, overdraftLimit));
                    }
                    break;
                case 2:
                    // Call bank.Deposit() method
                    Console.Write("Enter Account Number: ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    float amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Deposit(accountNumber, amount);
                    break;
                case 3:
                    // Call bank.Withdraw() method
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Withdraw(accountNumber, amount);
                    break;
                case 4:
                    // Call bank.CalculateInterest() method
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    bank.CalculateInterest(accountNumber);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
﻿using Assignment10;
public class BankApp
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank();
        while (true)
        {
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Transfer");
            Console.WriteLine("5. Get Account Details");
            Console.WriteLine("6. Exit");
            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Call bank.CreateAccount() method
                    Console.Write("Enter Customer ID: ");
                    int customerId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter First Name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter Last Name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter Phone Number: ");
                    string phoneNumber = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();
                    Customer customer = new Customer(customerId, firstName, lastName, email, phoneNumber, address);
                    Console.Write("Enter Account Type: ");
                    string accountType = Console.ReadLine();
                    Console.Write("Enter Initial Balance: ");
                    decimal balance = Convert.ToDecimal(Console.ReadLine());
                    bank.CreateAccount(customer, accountType, balance);
                    break;
                case 2:
                    // Call bank.Deposit() method
                    Console.Write("Enter Account Number: ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    float amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Deposit(accountNumber, amount);
                    break;
                case 3:
                    // Call bank.Withdraw() method
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Withdraw(accountNumber, amount);
                    break;
                case 4:
                    // Call bank.Transfer() method
                    Console.Write("Enter From Account Number: ");
                    int fromAccountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter To Account Number: ");
                    int toAccountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Transfer(fromAccountNumber, toAccountNumber, amount);
                    break;
                case 5:
                    // Call bank.GetAccountDetails() method
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(bank.GetAccountDetails(accountNumber));
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
﻿using Assignment11;
public class BankApp
{
    public static void Main(string[] args)
    {
        IBankServiceProvider bank = new BankServiceProviderImpl();
        while (true)
        {
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Transfer");
            Console.WriteLine("5. Get Account Details");
            Console.WriteLine("6. List Accounts");
            Console.WriteLine("7. Exit");
            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Call bank.CreateAccount() method
                    Console.Write("Enter Customer ID: ");
                    int customerId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter First Name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter Last Name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter Phone Number: ");
                    string phoneNumber = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();
                    Customer customer = new Customer(customerId, firstName, lastName, email, phoneNumber, address);
                    Console.Write("Enter Account Type: ");
                    string accountType = Console.ReadLine();
                    Console.Write("Enter Initial Balance: ");
                    decimal balance = Convert.ToDecimal(Console.ReadLine());
                    bank.CreateAccount(customer, accountType, balance);
                    break;
                case 2:
                    // Call bank.Deposit() method
                    Console.Write("Enter Account Number: ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    float amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Deposit(accountNumber, amount);
                    break;
                case 3:
                    // Call bank.Withdraw() method
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Withdraw(accountNumber, amount);
                    break;
                case 4:
                    // Call bank.Transfer() method
                    Console.Write("Enter From Account Number: ");
                    int fromAccountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter To Account Number: ");
                    int toAccountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Amount: ");
                    amount = (float)Convert.ToDouble(Console.ReadLine());
                    bank.Transfer(fromAccountNumber, toAccountNumber, amount);
                    break;
                case 5:
                    // Call bank.GetAccountDetails() method
                    Console.Write("Enter Account Number: ");
                    accountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(bank.GetAccountDetails(accountNumber));
                    break;
                case 6:
                    // Call bank.ListAccounts() method
                    foreach (Account account in bank.ListAccounts())
                    {
                        Console.WriteLine(account);
                    }
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}