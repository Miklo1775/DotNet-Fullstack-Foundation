using polymorphismAbstractClasses;

SavingsAccount savingsAccount = new SavingsAccount();
savingsAccount.Deposit();
savingsAccount.Withdraw();
savingsAccount.Balance();
savingsAccount.getMessage();

// below results in an error because abstract classes cannot be instantiated

//BankAccount bankAccount = new BankAccount();
//bankAccount.getMessage();

SavingAcc savingAcc = new SavingAcc();
savingAcc.Deposit();
savingAcc.Withdraw();
savingAcc.Balance();
savingAcc.CloseAccount();
savingAcc.OpenAccount();