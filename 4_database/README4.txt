Note: Need MsSQL

AutomatedParkingGarage is a heavily database driven application. The Park database has all the required tables and stored procedures that are so far required 
for the projects.

(Park.bak file is stored in the folder contaning this README4.txt document. Move this park.bak file to your C drive before following the steps below)


To access the database, open Microsoft SQL server and right click on the "databases" option displayed in the object explorer tab.
In the drop down menu select the option "Restore Database". In the Restore Database window type “Park” in the “To database” field. 
In the “Specify the source and location of backup sets to restore” field select the option “From device” and browse to find the location of the Park.bak file.
In the Specify Backup window select the button “Add” and browse for the correct location. Click ok and restore the database. 


The tables can be viewed under Databases->Park->Tables->SystemTables. All these details will be displayed in the object explorer tab.
To view the design of the table right click on the table name and select Design. This will display the table and the fields and their types. 
To view the sample data that we have stored in tables, right click on the table name and click on "Select top 200 rows".
To access the stored procedures in the database, Databases->Park->Programmability->Stored Procedures. 
This will display the list of stored procedures in the database. To open the code for the procedures right click on the procedure name and click modify.
To execute the open procedure click on the execute tab in the toolbar. 
The state of execution whether it is successful or not will be displayed below the code as a message.
