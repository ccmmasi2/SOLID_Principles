# SOLID_Principles
Those principles are a guide, a recommendation, use them is a good practice, sometimes broke one means bloke more than one.  


SOLID S
Single responsibility principle

This class has different methods, and the SaveOrder method calls others
Exist a high coupling. 
This method is broken some principles and good practices: 
     1 - The first Solid principle: Single Responsibility, This class should have an unique responsibility, but instead of this, has different responsibilities, is allowed to create orders, invoices and send email. 
     2 - High cohesion and low coupling: Exist a quite high coupling in this class
     3 - There aren't any abstraction here, and is broken one of the principles of OOP: abstraction, the code should reference to abstractions instead of concret classes
     4 - Another thing we can implement here is encapsulation, one of the OOP principles, that says you should show the information you need to show and restrict access or visualization to methods or code that you need to maintein hidden. 

/******************************

SOLID O 
open-closed principle

The problem in this project is that NotificationService.SendNotification is a method that has a switch to iterate between different kind of notifications, for now has the possibility to send emails to Gmail and Hotmail, but if we need another notifications such as Personal notification, or using a broker, API, WCF or another kinds of notifications, we need to add other lines to add to the switch structure. 

Here we could break Open-Closed Principle, it says if we need to add another feature - functionality to a class, we should'n modify the class, instead of this, we should add an interface with the new features and implementate this interface

/**********************************

SOLID L
Liskov substitution principle. (Liskov was who created this principle)

This principle says: 
	The derived clases could be replaceables by their base clases without altering the operation of the system

In this project we have the following problems:
Please note the BaseRepository folder and IRepository, Repository files
The Base repository has the methods: GetAll, GetOne Insert, Update and Remove
And note that ObjectRepository clases have to implementate all of those methods, regardless of whether the class need all of them or only one. 
For this excercise suppose for an Order we are allowed to CreateOrder, GetAll, GetOne, Update , but for Invoice we can't Update it. 
on ObjectRepository -> InvoiceRepository we are implementing all of methods, although we already know we don't need all of them. 

We are breaking the Liskov substitution principle, because we can't replace our derived class InvoiceRepository by its parent BaseRepository. For one class We only need Create, GetAll and GetOne but Update, and as we are using this interface, we have to implement all of these methods, even we don't needed.  
