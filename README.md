# _Hair Salon_
#### Week 3 C# ASP.NET Core MVC Independent Project at Epicodus, 12.7.2018

## Created By
* _Tanvi Garg_

## Description
* _The owner(user) should be able to add a list of the stylists, and for each stylist, add clients who see that stylist. The stylists work independently, so each client only belongs to a single stylist._


## Specs
* _Salon employee should be able to see a list of all the stylists._
* _Salon employee should be able to select a stylist, see their details, and see a list of all clients that belong to that stylist._
* _Salon employee should be able add new stylists to the system when they are hired._
* _Salon employee should be able to add new clients to a specific stylist._
* _Salon employee should not be able to add a client if no stylists have been added._
### Specs For Optional Functionality
* _Salon employee should be able to delete (individual and all) stylists._
* _Salon employee should be able to delete (individual and all) clients._
* _Salon employee should be able to enter stylist name into form where employees may search for the stylist. It should display a list of all results._
* _Salon employee should be able to enter client's name into form where employees may search for the client's. It should display a list of all results._


## Database Setup
* _From Terminal Command Line, Enter MySQL using `localhost -uroot -proot` and run following commands to setup the Database and its tables_

`CREATE DATABASE tanvi_garg;`

`USE tanvi_garg;`

`SELECT DATABASE();`

`CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR (255));`

`CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR (255), phone VARCHAR (255), stylist_id INT);`

`SHOW TABLES;`

![Visual Of Tables in tanvi_garg DB](/HairSalon/wwwroot/imgs/DBtables.png)





## Setup on Mac OSX
1. _Download and install .Net Core 1.1.4_
2. _Download and install Mono_
3. _Download and install MAMP 4.5_
4. _Go to GitHub profile and clone the repo from [TanviCodeLife](https://github.com/TanviCodeLife/word-counter-csharp-proj). Use `git clone <project url>` command to pull it to a local repository in your Home directory._
5. _Open MAMP and start the Apache and MySql servers_
6. _Navigate to MAMP > Tools > phpMyAdmin and import the tanvi_garg.sql file to create the database_
7. _Navigate to MAMP > Tools > phpMyAdmin and import the tanvi_garg_test.sql file to create the test database_
5. _Run `dotnet restore` from Main Project Folder (HairSalon) and Test Directory (HairSalon.Tests) to install packages_
6. _Run `dotnet build` from Main Project Folder and make sure no build errors appear. Run `dotnet restore` after build is complete._
7. _Run `dotnet restore` to compile tests and then `dotnet test` from the Test Directory to run the testing suite. All tests should pass._
8. _Run `dotnet run` from Main Project Folder to start the server_
9. _Wait till you see this message display in you bash terminal - "Now listening on: http://localhost:xxxx _
10. _Copy the local host link http://localhost:xxx and paste it into your web browser address bar._
11. _Browse through the project._


## Technologies Used

* .Net Core 1.1.4
* MAMP 4.5
* MySQL
* Bootstrap 3.3.7
* JavaScript
* jQuery 3.3.1


## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Tanvi Garg**
