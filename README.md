# UpdateService
## SQLRequests
The first application is an **#ASP.NET MVC** application that generates tables into a database and executes **SQL** queries.

## UpdateService
the second application is a **Windows service** that adds users with a random name to the **Users** table, which is created when the **SQLRequests application** is launched, at regular intervals.
To register the windows service, run the command in the console:
**```installutil <application name.exe>```**

### IMPORTANT!
before registering the service, you need to create a database by running the **SQLRequests application**

