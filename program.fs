open System

type Account = { 
accountNumber : string
mutable balance : float
}

let account1 = { accountNumber = "0001"; balance = 0 }
let account2 = { accountNumber = "0002"; balance = 51 }
let account3 = { accountNumber = "0003"; balance = 5 }
let account4 = { accountNumber = "0004"; balance = 105 }
let account5 = { accountNumber = "0005"; balance = 20 }
let account6 = { accountNumber = "0006"; balance = 150 }

Console.Write("Which task do you want to run: ")
let task : int = int(Console.ReadLine())

if task = 1 then

    Console.WriteLine(account2)

    Console.Write("Do you want to 1.Withdraw or 2.Deposit: ")
    let option : int = int(Console.ReadLine())

    if option = 1 then
        Console.Write("Enter the amount you want to withdraw: ")
        let mutable amount : float = int(Console.ReadLine())
        if account2.balance >= amount then
            account2.balance <- account2.balance - amount
            Console.WriteLine(account2)
        else
           Console.Write("There are insufficient funds to withdraw this amount")
    else if option = 2 then
       Console.Write("Enter the amount you want to deposit: ")
       let mutable amount : float = int(Console.ReadLine())
       account2.balance <- account2.balance + amount
       Console.WriteLine(account2)

else if task = 2 then

    let CheckAccount amount =
        match amount with
        | _ when amount.balance < 10  -> Console.WriteLine(amount.accountNumber + ": Balance is Low")
        | _ when amount.balance >= 10 && amount.balance <=100 -> Console.WriteLine(amount.accountNumber + ": Balance is OK")
        | _ when amount.balance > 100 -> Console.WriteLine(amount.accountNumber + ": Balance is High")
        | _ -> Console.WriteLine("error")

    CheckAccount account1
    CheckAccount account2
    CheckAccount account3
    CheckAccount account4
    CheckAccount account5
    CheckAccount account6