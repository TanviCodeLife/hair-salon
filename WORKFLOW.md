# _Hair Salon_
#### Week 3 C# ASP.NET Core MVC Independent Project at Epicodus, 12.7.2018

## Created By
* _Tanvi Garg_

### Description
* _The owner(user) should be able to add a list of the stylists, and for each stylist, add clients who see that stylist. The stylists work independently, so each client only belongs to a single stylist._

### Database:
* Create Database using following instructions.
* Production Database: first_last.sql. Here tanvi_garg.sql_
Test Database: first_last_test.sql. Here tanvi_garg_test.sql
* Always create id column for all tables with auto-increment and primary key.
* Child Class Foreign Key ID = Parent Class Primary Key(applies to One-To-Many relationship)
* For HairSalon Client Id = Stylist Foreign Key (column name = stylist_id).

### Project Structure

#### Use Model-View-Controller Structure. Details below -

1. #### Models :
  * Client - Child Class
  * Stylist - Parent Class
  * Location:ProjectName>Models>ClassName.cs for each.

2. #### Model Unit Tests:
 * Create Test for Each Class Method and check for correct fail output criteria.
 * Add Class Method functionality and pass to match expected and actual results.
 * Repeat above steps (fail and pass) for each Class Method.
 * Test Method Naming Convention: `MethodName_IntendedFunction_OutputType`
 * Location:ProjectName.Tests>ModelTests>ClassNameTests.cs

3. ##### Client(Child Class) Constructor, Methods and their Testing
 * Child Logic: `ProjectName>Models>ChildClassName.cs`
 * ChildTests Logic Tests: `ProjectName.Tests>ModelTests>ChildClassNameTests.cs`
 * Constructor -
`public ClassName (string clientName, string clientPhone, int stylistId, int id = 0)`
`{`
` _clientName = clientName;`
 `_clientPhone = clientPhone;`
 `_stylistId = stylistId;`
 `_clientId = id;`
 `}`

* ##### Getter/Setter Methods -
 * GetClientName()
 * SetClientName()
 * GetClientPhone()
 * SetClientPhone()
 * GetStylistId()

 * ##### Maintenance Methods -
 * Equals()
 * ClearAll()
 * GetHashCode()

* ##### Database Manipulation Methods -
 * GetAll()
 * Save()
 * Find()
 * Edit()
 * Delete()

4. ##### Stylist(Parent Class) Constructor and Methods and their Testing
 * Parent Logic: `ProjectName>Models>ParentClassName.cs`
 * ParentTests Logic Tests: `ProjectName.Tests>ModelTests>ParentClassNameTests.cs`
 * Constructor -
`public Stylist(string stylistName, int id = 0)`
`{`
`_name = stylistName;`
`_id = id;`
`_stylistId = stylistId;`
`_clients = new List<Client>{};`
`}`

* ##### Getter/Setter Methods -
* GetName()
* SetName()
* GetId()

* ##### Maintenance Methods -
* Equals()
* ClearAll()
* GetHashCode()

* ##### Database Manipulation Methods -
* GetAll()
* Save()
* Find()
* Edit()
* Delete()
