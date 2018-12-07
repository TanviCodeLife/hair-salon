# _Hair Salon_
#### Week 3 C# ASP.NET Core MVC Independent Project at Epicodus, 12.7.2018

## Created By
* _Tanvi Garg_

### Description
* _The owner(user) should be able to add a list of the stylists, and for each stylist, add clients who see that stylist. The stylists work independently, so each client only belongs to a single stylist._

### Database:
* _Create Database using following instructions._
_Production Database: first_last.sql. Here tanvi_garg.sql_
_Test Database: first_last_test.sql. Here tanvi_garg_test.sql_
* _Always create id column for all tables with auto-increment and primary key._
* _Child Class Foreign Key ID = Parent Class Primary Key(applies to One-To-Many relationship)_
* _For HairSalon Client Id = Stylist Foreign Key (column name = stylist_id)._

### Project Structure
#### Use Model-View-Controller Structure. Details below -

1. #### Models :
_Client - Child Class_
_Stylist - Parent Class_
_Location:ProjectName>Models>ClassName.cs_

2. #### Model Unit Tests:
_Create Test for Class Method, fail_
_Add Class Method function, pass_
_Test Method Naming Convention: `MethodName_IntendedFunction_OutputType`_ _Location:ProjectName.Tests>ModelTests>ClassNameTests.cs_

3. ##### Client(Child Class) Methods
Constructor -
`public ClassName (string clientName, string clientPhone, int stylistId, int id = 0)`
`{`
` _clientName = clientName;`
 `_clientPhone = clientPhone;`
 `_stylistId = stylistId;`
 `_clientId = id;`
 `}`

4. ##### Getter/Setter Methods -
 _GetClientName()_ _SetClientName()_
_GetClientPhone()_
_SetClientPhone()_
_GetStylistId()_

5. ##### Database Manipulation Methods -
_Save()_
_Edit()_
_GetAll()_
_Find()_
_Delete()_
