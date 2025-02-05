// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;

public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getCardNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose  the following options:  ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to deposit?  ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for the money. Your new balance is  " + currentUser.getBalance());

        }
        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw?  ");
            double withdrawl = Double.Parse(Console.ReadLine());
            if (currentUser.getBalance() < withdrawl)
            {
                Console.WriteLine("Insufficient Balance ");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawl);
                Console.WriteLine("Thank you for withdrawing");
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance in the account is:  " + currentUser.getBalance());

        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("478965123", 1234, "John", "Griffin", 170.61));
        cardHolders.Add(new cardHolder("878065623", 1114, "Tim", "Cook", 700.11));
        cardHolders.Add(new cardHolder("201495173", 6789, "Saul", "Nunes", 84.88));
        cardHolders.Add(new cardHolder("278416103", 1200, "Peter", "Davis", 456.20));
        cardHolders.Add(new cardHolder("445612037", 9632, "Watson", "Smith", 874.00));

        Console.WriteLine("Welcome to SimpleATM\n");
        Console.WriteLine("Please enter your debit card number:  \n");
        String debitCardNum = "";

        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break; }
                else
                {
                    Console.WriteLine("Card Not recognized, please try again.");
                }
            }
            catch 
            {
                Console.WriteLine("Invalid card number. Please try again:  ");
            }
        }
        Console.WriteLine("Please enter the pin number: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin) { break; }
                else
                {
                    Console.WriteLine("Invalid pin number. Please try again:  ");
                }
            }

            catch 
            {
                Console.WriteLine("Invalid pin number. Please try again:  ");
            }
        }

        Console.WriteLine("Welcome " + currentUser.getFirstName() + " " + currentUser.getLastName());
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());

            }

            catch { }
            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you! have a nice day ahead");
    }
}



