open System

type Account = { 
accountNumber : string
mutable balance : float
}

let account1 = { accountNumber = "11111111"; balance = 1000 }

Console.WriteLine(account1)

Console.Write("Do you want to 1.Withdraw or 2.Deposit: ")
let option : int = int(Console.ReadLine())


if option = 1 then
    Console.Write("Enter the amount you want to withdraw: ")
    let mutable amount : float = int(Console.ReadLine())
    if account1.balance >= amount then
        account1.balance <- account1.balance - amount
        Console.WriteLine(account1)
    else
        Console.Write("There are insufficient funds to withdraw this amount")
else if option = 2 then
    Console.Write("Enter the amount you want to withdraw: ")
    let mutable amount : float = int(Console.ReadLine())
    account1.balance <- account1.balance + amount
    Console.WriteLine(account1)