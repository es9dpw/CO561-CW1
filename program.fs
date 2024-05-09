﻿open System

let mutable amount : float = 0

//create type "Account" with methods for withdrawing and depositing money
type Account = { accountNumber : string; mutable balance : float} member this.Withdraw = this.balance - amount
                                                                  member this.Deposit = this.balance + amount
                                                                  member this.Print = Console.WriteLine(this.accountNumber + ": " + string(this.balance))

//create type "Ticket"
type Ticket = {seat:int; customer:string}

//adds records using type "Account"
let account1 = { accountNumber = "0001"; balance = 0 }
let account2 = { accountNumber = "0002"; balance = 51 }
let account3 = { accountNumber = "0003"; balance = 5 }
let account4 = { accountNumber = "0004"; balance = 105 }
let account5 = { accountNumber = "0005"; balance = 20 }
let account6 = { accountNumber = "0006"; balance = 150 }

//Task select
Console.Write("Which task do you want to run: ")
let task : int = int(Console.ReadLine())

if task = 1 then

    //Displays accountNumber and balance of account2
    account2.Print

    //select whether to withdraw or deposit money
    Console.Write("Do you want to 1.Withdraw or 2.Deposit: ")
    let option : int = int(Console.ReadLine())

    //user enters amount to withdraw and then the balance is check to make sure there are sufficient funds and then the funds are withdrawn and then displays accountNumber and balance of account2
    if option = 1 then
        Console.Write("Enter the amount you want to withdraw: ")
        amount <- int(Console.ReadLine())
        if account2.balance >= amount then
            account2.balance <- account2.Withdraw
            account2.Print
        else
           Console.Write("There are insufficient funds to withdraw this amount")
    //user enters amount to deposit and then the funds are deposited into the balance and then displays accountNumber and balance of account2
    else if option = 2 then
       Console.Write("Enter the amount you want to deposit: ")
       amount <- int(Console.ReadLine())
       account2.balance <- account2.Deposit
       account2.Print

else if task = 2 then

    //Patern matching checks each accounts balance and then prints out a message depending on the value of the balance 
    let CheckAccount check =
        match check with
        | _ when check.balance < 10 -> Console.WriteLine(check.accountNumber + ": Balance is Low")
        | _ when check.balance >= 10 && check.balance <=100 -> Console.WriteLine(check.accountNumber + ": Balance is OK")
        | _ when check.balance > 100 -> Console.WriteLine(check.accountNumber + ": Balance is High")
        | _ -> Console.WriteLine("error")

    //runs the check account function with each account
    CheckAccount account1
    CheckAccount account2
    CheckAccount account3
    CheckAccount account4
    CheckAccount account5
    CheckAccount account6

else if task = 3 then
    
    let accounts = [account1;account2;account3;account4;account5;account6]
    Console.WriteLine(accounts)

else if task = 4 then
    
    let mutable tickets = [for n in 1..10 -> {Ticket.seat = n; Ticket.customer = ""}]
    Console.WriteLine(tickets)

