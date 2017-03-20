# Web Service Prac
The goal of this practical is to explore .Net web services. This practical is divided into 3 tasks:
* Create two web services – Finding Date by Zodiac Name Web Service and Finding Zodiac Name by Date Web Service
* Host and Invoke web services in Zodiac Finder ASP.NET web application using server-side code 
* Create and Invoke Postcode Finder web service in Postcode Finder ASP.NET web application using JavaScript - ASP.NET AJAX method 

## Two Web Services 
### Finding Date by Zodiac Name Web Service

Create a simple web service that receives the zodiac name (full name of the color) and returns its associated date interval. For any other names that are not listed in the above table, the web service should return a “Not found” message.
### Finding Zodiac Name by Date Web Service

Create a web service that receives two parameters (Mon and Day) and returns the corresponding zodiac name (full name). For those combinations that are not listed in the above example table, the web service should still return a correct zodiac
name, which means this service is supposed to support all the dates in a year. Please also note that this service provides an input validation for the value of months and days. For example, if user inputs 15 for month or 45 for day, in both cases the web service should return ‘Wrong Input Date’ as the result.

## Zodiac Finder ASP.NET web application
Create a web application that hosts and invokes the two web services that you created in Task 1. Please note that for this task, you should invoke the two web services using server-side code (C# language)

## Postcode Finder - using ASP.Net AJAX method to invoke a Web Service
create a Postcode Finder web service that receives a suburb name and returns its postcode. The requirements for this web service are as follows:
* This web services should be invoked by an ASP.Net web application, using ASP.Net AJAX method (Javascript language).
* List of suburb names and their associated postcode are stored in a text file called Postcodes.txt, which you can find on Blackboard. As a result, the web service should read the information from the file, using FileStream, StreamReader, or other objects from System.IO namespace.
(Hint: ‘,’ has been used to separate suburb name from its postcode. You may consider the identifier for processing the file content. Split() method in String object may be useful in this case)

create an ASP.Net web application that invokes this web service, using ASP.Net AJAX method. The application should have the following elements:
* A Label that displays time of the first application run. Please note that this value should be displayed when the application page loads (Page_Load event) for the first time and should remain unchanged after every button click. This is to ensure you actually use AJAX method to call the web service, which will not incur page refresh.
* A DropDownList for user’s input.
* A Button to submit the form, invoke the Postcode Finder web service and get the result(s).
* A Label to display the search results. This is the only part of the page that will be refreshed, every time user clicks on the button.

# WCF Service Prac
# REST Service Prac
# LINQ Prac