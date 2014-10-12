Note: Need Microsoft Visual Studio

The code that has been submitted in the 1_code folder is the best integration test in itself. It tests the entire system,
compiles, runs, and does not crash.It handles exceptions gracefully. The actual code, as demonstrated in the demo, talks 
to the database and updates results based on what is in the database. 

However, we split integration testing into 2 parts:
1. Test everything but the database (attached in this folder)
2. Then, test the entire system (with database) (shown in demo and attached in 1_code folder)

In the first part, we test all the C# code written for this project, without database complication. Since this project
has a heavy database component also, we decided to make testing optimal but first testing without the DB, then with.
We hardcode values that would othewise be given from the database, and modify fnunction calls that require database 
connection.

Once we have a standalone system that does not rely on the database, we now test it, to see if our state machine logic 
works, if our model talks properly to the classes, if our functions is right.

The GUI that is created for this is similar to the one that was shown in the demo, but unlike the actual code,
we have hardcoded values to test the system. 

Once this test passes, we now replace hardcoded values with functions that talk to the database and fetch values from 
there. THen we test the entire system. If it fails, we now know that it is because of a database code, or the DataAccess
class. Hence this tremendously helped in narrowing down errors and fixing them.

The entire functional system is not added here but in 1_code folder.

To run the attached file in this folder, open the application folder, find .csproj file and double click on it. It will
open up the entire project solution in Visual Studio. Then click on run button at the top, and the code executes. Click on
various buttons and click Step to see how our system responds to each stimulus.