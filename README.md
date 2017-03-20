# Web Service Prac
The goal of this practical is to explore .Net web services. This practical is divided into 3 tasks:
* Two web services – Finding Date by Zodiac Name Web Service and Finding Zodiac Name by Date Web Service
* Host and Invoke web services in Zodiac Finder ASP.NET web application using server-side code 
* Create and Invoke Postcode Finder web service in Postcode Finder ASP.NET web application using JavaScript - ASP.NET AJAX method 

## Two Web Services 
### Finding Date by Zodiac Name Web Service

A simple web service that receives the zodiac name (full name of the color) and returns its associated date interval. For any other names that are not listed in the above table, the web service should return a “Not found” message.
### Finding Zodiac Name by Date Web Service

A web service that receives two parameters (Mon and Day) and returns the corresponding zodiac name (full name). For those combinations that are not listed in the above example table, the web service should still return a correct zodiac
name, which means this service is supposed to support all the dates in a year. Please also note that this service provides an input validation for the value of months and days. For example, if user inputs 15 for month or 45 for day, in both cases the web service should return ‘Wrong Input Date’ as the result.

## Zodiac Finder ASP.NET web application
A web application that hosts and invokes the two web services. The ASP.NET application invoke the two web services using server-side code (C# language)

## Postcode Finder - using ASP.Net AJAX method to invoke a Web Service
Postcode Finder web service receives a suburb name and returns its postcode:
* This web services is invoked by an ASP.Net web application, using ASP.Net AJAX method (Javascript language).
* List of suburb names and their associated postcode are stored in a text file called Postcodes.txt, which you can find on Blackboard. As a result, the web service should read the information from the file, using FileStream, StreamReader, or other objects from System.IO namespace.

# WCF Service Prac
The goal of this practical is to explore .Net WCF web services.This practical is divided into 2 tasks:
* BookStore web service
* BookPurchase web service 

## BookStore Web Service
A WCF web service and define the following custom type (user-defined classes) using data contract:
**Book**
a. string ID
b. string name
c. string author
d. int year
e. float price
f. int stock

This WCF web service have the following 4 operations:

* GetAllBooks()
This operation reads all books information from file books.txt and returns a list of books.
* AddBook()
This operation receives the information of a book and creates an instance of class Book, then add this book into existing book list and save into file books.txt. If the operation succeeds to add a book into the book list and save to file, it returns true. Otherwise it returns false.
* DeleteBook()
This operation receives a field and a corresponding value of such field. For example, the field is year, and the value is 2007. Then, it deletes all the books that match the condition, and save the rest of the books into file books.txt. If the operation succeed to delete at least one book and save the rest books into file, it returns true. Otherwise it returns false.
* SearchBook()
This operation receives a field and a corresponding value of such field. For example, the field is year, and the value is 2007. Then, it displays all the books that match the condition. It returns a list of books.
* Create a web form as the service client end to use all the functions in BookStore web service.

**A web form is created here as the service client end to use all the functions in BookStore web service**

## BookPurchaseWeb Service
This WCF web service should have the one operation. This operation receives a BookPurchaseInfo and returns a BookPurchaseResponse. 
**A web form is creatd as client side to use the BookPurchase web service.**

And it is defined with the following custom types (user-defined classes) using message contract:
### BookPurchaseInfo
	- float budget
	- Dictionary<int, int> items
The budge means the total money you have to purchase books. For items, the key (int) is the Num (the index of a book in the book list file in task 1) of the book you want to buy, and the value (int) is the number of books you want to buy corresponding to the Num
### BookPurchaseResponse
	- bool result
	- string response
The result indicates whether this purchase succeeds.
* If the cost of books you choose is greater than your budget, this purchase fails, then the result is false, and the response should be “No enough money”.
* If the amount of books you want to buy is greater than the stock of the books, then it fails and the result is false, the response should be “No enough stocks”.
* If the purchasing succeeds, the response should be the number of money left after purchasing the books you choose.

# REST Service Prac
This Restfull Service have the following four operations:
## GetAllPlayers
Endpoint: GET api/Player/GetAllPlayers
This operation reads all players information from file players.txt and returns a list of players
## GetPlayerInfo
This operation receives a field and a corresponding value of such field. For example, the field is ID, and the value is p2222. Then, it displays all the players that match the condition. It returns a list of players.
Endpoints: 
GET api/Player/GetPlayer/< id > 
GET api/Player/GetPlayerByName/< name >
## DeletePlayer
This operation receives a field and a corresponding value of such field. For example, the field is ID, and the value is p2222. Then, it deletes all the players that match the condition, and save the rest of the players into file players.txt.
Endpoints: 
DELETE api/Player/DeletePlayer/< id > 
DELETE api/Player/DeletePlayerByName/< name >
## PlayerRegistration
This operation receives the information of a player and creates an instance of class Player, then add this player into existing player list and save into file players.txt. If the ID of the player you want to register already exists, then you need to update the information of this player. This operation returns the new player list.
Endpoints:
POST api/Player/PostPlayer


# LINQ Prac