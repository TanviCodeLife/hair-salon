# _Hair Salon_
#### Week 3 C# ASP.NET Core MVC Independent Project at Epicodus, 12.7.2018

## Created By
* _Tanvi Garg_

### Description
* _The owner(user) should be able to add a list of the stylists, and for each stylist, add clients who see that stylist. The stylists work independently, so each client only belongs to a single stylist._

### Database Setup using SQL commands
* _Production Database: `tanvi_garg.sql`_
* _Test Database: `tanvi_garg_test.sql`_
* _Tables in Database: stylists (columns: id, name) and clients (id, name, phone, stylist_id(foreign key))_
* _Relationship: One To Many_  
* _From Terminal Command Line, Enter MySQL using `localhost -uroot -proot` and run following commands to setup the Database and its tables_

* `CREATE DATABASE tanvi_garg;`

* `USE tanvi_garg;`

* `SELECT DATABASE();`

* `CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR (255));`

* `CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR (255), phone VARCHAR (255), stylist_id INT);`

* `SHOW TABLES;`

* ![Visual Of Tables in tanvi_garg DB](/HairSalon/wwwroot/imgs/DBtables.png)


#### Use Model-View-Controller Structure.

1. ### Models and Model Tests :
  * Client - Child Class
  * Stylist - Parent Class
  * Location:ProjectName>Models>ClassName.cs for each.

 #### Model Unit Tests:
 * Create Test for Each Class Method and check for correct fail output criteria.
 * Add Class Method functionality and pass to match expected and actual results.
 * Repeat above steps (fail and pass) for each Class Method.
 * Test Method Naming Convention: `MethodName_IntendedFunction_OutputType`
 * Location:ProjectName.Tests>ModelTests>ClassNameTests.cs

 #### Client(Child Class):
 * Parent : Client
 * Child Logic Location: `ProjectName>Models>ChildClassName.cs`
 * ChildTests Logic Tests Location: `ProjectName.Tests>ModelTests>ChildClassNameTests.cs`

 ##### Constructor:
`public ClassName (string clientName, string clientPhone, int stylistId, int id = 0)`
`{`
` _clientName = clientName;`
 `_clientPhone = clientPhone;`
 `_stylistId = stylistId;`
 `_clientId = id;`
 `}`

 ###### Add Code To Link Test Database To Child Model Tests:
 `public ClientTest()`
 `{`
   `DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=tanvi_garg_test;";`
 `}`

 ##### Child Methods and Their Tests:

| Method Name        | Test Purpose |  Method Type            |
|: ------------- :|:-------------:|:-------------:|
|     Child Constructor             |        Check If Creates Instance Of Child      |       Child Instance Constructor        |
|  GetClientName()      | Check If Returns Child Name Property Value|   Getter Method  |
|  GetClientPhone()   | Check If Returns Child Phone Property Value     | Getter Method   |
|  GetParentId()       | Check If Returns Parent Id for the Child Instance          |    Getter Method        |
| Equals() | Check If Returns True If 2 Child Instances with Identical Properties Are The Same     |   Maintenance Method    |
| ClearAll()      | No Test |  Maintenance Method   |
|   GetHashCode()   |  No Test     | Maintenance Method |
| GetAll()     | Test 1: Check If Returned Child's Instance List is Empty At First|Database Manipulation|
|  GetAll()    | Test 2: Check If Returned List Contains All Child's Instances      |  Database Manipulation  |
|  Save()     | Check If It Saves Child Instance To Database |Database Manipulation|
|  Save()     | Check If It Assigns Auto ID to Child Entry in Database |Database Manipulation|
|  GetClientId()     | Check If It Returns Child Id From Database |Database Manipulation|
|  Find()     |  Check If It Returns Correct Child Instance From Database   | Database Manipulation|
|  Edit()     | Check If It Updates Child Instance In Database|Database Manipulation|
|  Delete()  | Check If It Deletes Child Instance From Database|Database Manipulation|

 #### Stylist(Parent Class):
 * Parent : Stylist
 * Parent Logic Location: `ProjectName>Models>ParentClassName.cs`
 * ParentTests Logic Tests Location: `ProjectName.Tests>ModelTests>ParentClassNameTests.cs`


 ##### Constructor:
`public Stylist(string stylistName, int id = 0)`
`{`
`_name = stylistName;`
`_id = id;`
`_stylistId = stylistId;`
`_clients = new List<Client>{};`
`}`
###### Add Code To Link Test Database To Parent Model Tests:
`public ClientTest()`
`{`
  `DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=tanvi_garg_test;";`
`}`
##### Parent Methods and Their Tests:

| Method Name        | Test Purpose |  Method Type            |
|: ------------- :|:-------------:|:-------------:|
|     Parent Constructor             |        Check If Creates Instance Of Parent      |       Parent Instance Constructor        |
|  GetName()      | Check If Returns Parent Name |   Getter Method  |
|  GetId()   | Check If Returns Parent Id     | Getter Method   |
| Equals() | Check If Returns True If 2 Parent Objects with Identical Properties Are The Same     |   Maintenance Method    |
| ClearAll()      | No Test |  Maintenance Method   |
|   GetHashCode()   |  No Test     | Maintenance Method |
| GetAll()     | Test 1: Check If Returned Parent's Instance List is Empty At First|Database Manipulation|
|  GetAll()    | Test 2: Check If Returned List Contains All Parent's Instances      |  Database Manipulation  |
|  Save()     | Check If It Saves Parent Instance To Database |Database Manipulation|
|  Find()     |  Check If It Returns Parent Instance In Database   | Database Manipulation|
|   GetClients()    | Check If It Retrieves All Child Instances Associated With Parent Instance|Database Manipulation|
|  Edit()     | Check If It Updates Parent Instance In Database|Database Manipulation|
|  Delete()  | Check If It Deletes Parent Instance From Database|Database Manipulation|



2. ### Controllers and Controller Tests :
  * Stylist - Parent Class
  * Client - Child Class
  * Home Controller - Location:`ProjectName>Controllers>ParentClassNameController.cs`
  * Parent Controller - Location:`ProjectName>Controllers>ParentClassNameController.cs`
  * Child Controller - Location:`ProjectName>Controllers>ChildClassNameController.cs`
  * Parent Controller Test - Location:`ProjectName.Tests>ControllersTests>ParentClassNameControllerTest.cs`
  * Child Controller Test - Location:`ProjectName.Tests>ControllersTests>ChildClassNameControllerTest.cs`

  ##### Controller Routes Return Types and Their Tests:

| Return Type        | Test Purpose           
| ------------- |:-------------:|
| View("Route")      | Check If ReturnsCorrectView |
|      | Check If HasCorrectModelType      |   
| View() | Check If ReturnsCorrectView      |
| RedirectToAction("Route")      | Check If ReturnsCorrectView |
|      | Check If ReturnsCorrectActionName      |  
| View("Route", object)      | Check If ReturnsCorrectView |
|      | HasCorrectViewName      |  
|       | Check If HasCorrectModelType |

3. ### Controller Routes and URLs with their corresponding views are based on Restful Routing
 ![Visual Of Restful Routing Via Controllers](/HairSalon/wwwroot/imgs/Restful.png)
