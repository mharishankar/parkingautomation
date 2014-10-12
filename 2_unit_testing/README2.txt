Note: Need Miscrosoft Visual Studio

Testing the Model (Entities) as a unit: comprises of Garage.cs, Floor.cs, Spot.cs, SpotID.cs, Customer.cs

Open the folder titled Unit Tester. Open the folder WindowsFormsApplication1 and find WindowsFormsApplication.csp troj.
Double click on this. It will open the entire project in MicrosoftVisualStudio.To run the program,click on the green play
button on top. This will start execution.This will open a form which can be used to feed inputs and check the 
functionality of the system. The form contains two input fields  “# of Floors” which takes in the number of floors in the
garage and “# of Spots” which takes in the number of spots in each floor. Once the two inputs are given click on the “Run
Test” button and it will display the floors and spots details. To clear the screen display click on the “Clear” button. 
This will just clear the screen but will not destroy the object. To delete the created objects click on the “Destroy” 
button. If you would like to save the floor and spot details select the “Save” button and it will give the option to save 
to a specified location. This will save the displayed details as a text file. To exit the form just close the form window. 


SQL query testing:
The SQL testing code can be found within the Unit Tester folder in a text file called SQL Testing. To run a new test
open a new query in the SQL server which contains the Park database. A new query can be created by doing File->New->Query
with Current Connection. Copy paste and run the code for testing the SQL queries one by one. The code can be run by 
clicking the “Execute” command in the toolbar. Once you execute a test query refresh the database by right clicking on
the database name displayed in the object explorer tab in the left and click refresh. To check the modifications done to 
the database right click on the table name displayed in the object explorer and click “Edit top 200 rows”. This will 
display the contents of the database table and the resulting effect of running a testing query can be seen.In the test 
queries the input provided are just an example and can be modified if preferred.

The following is a list of procedures and the tables they use or modify:

Procedure			Table
addNewCustomer			member, member_address, member_login
addReservationToDatabase	reserve_parking_online
deleteResrvationFromDatabase	reserve_parking_online
getAmountDue			Sales_Account

