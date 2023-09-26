# MEGALON CODING TEST

## Test #1
Create a SQL Server local DB with the Name "CustomerOrdersDB" using Entity Framework Core Code First Approach with two tables "Customer" and "Order".
<br/><br/>
The <b>Customer</b> table should have the following columns:
|Column Name 		|Type			|
|-------------------|---------------|
| CustomerID    	| GUID, PK		|
| FirstName 		| VARCHAR(100) 	|
| LastName 			| VARCHAR(100) 	|
| DOB 				| DATE 			|

<br/><br/>

The <b>Order</b> table should have the following columns:
|Column Name 		|Type			|
|-------------------|---------------|
| OrderID			| INT, PK		|
| CustomerID    	| GUID, FK		|
| ItemName 			| VARCHAR(100) 	|
| ItemPrice			| DECIMAL(10,2)	|

<br/><br/>
The Database should be seeded through code on Initialization of the App with the following data: 

|CustomerID								| FirstName	|LastName	|DOB		|
|---------------------------------------|-----------|-----------|-----------|
| 481cf36a-fdb8-4911-853f-34ad26df4a2a	|Alice		|Smith		|1/1/1987	|
| 1db7a052-91d5-43f0-8eeb-c852b504cd59 	|Bob  		|Smith		|12/12/1986	|

<br/><br/>

|OrderID	|CustomerID								| ItemName		|ItemPrice	|
|-----------|---------------------------------------|---------------|-----------|
|1			| 481cf36a-fdb8-4911-853f-34ad26df4a2a	|Nail Polish	|100.00		|
|2			| 481cf36a-fdb8-4911-853f-34ad26df4a2a	|Hair Brush		|500.00		|
|3			| 1db7a052-91d5-43f0-8eeb-c852b504cd59  |Shaving Cream	|90.00		|

## Test #2
Create an ASP.NET Core API project with a repository pattern to access the Database and write a controller to fetch Customer List with their Orders List. The data returned should be in JSON format.

## Test #3
Create a Blazor Server ASP.NET Core Web App to display List of Customers in a Grid with the following Columns:

### CUSTOMERS
|CustomerID								| Customer Name	|DOB		|Action				|
|---------------------------------------|---------------|-----------|-------------------|
| 481cf36a-fdb8-4911-853f-34ad26df4a2a	|Alice Smith	|1/1/1987	|<u>View Orders<u>	|
| 1db7a052-91d5-43f0-8eeb-c852b504cd59 	|Bob Smith		|12/12/1986	|<u>View Orders<u>	|

<u>View Order</u> will be the hyperlink to the Order Details page for that customer which should list a grid of all the Orders for that selected Customer. The Order Details page should look like When Order Details of Alice Smith is selected:
<br/><br/>
### ORDER DETAILS for Alice Smith
|OrderID	| Item			|Price		|
|-----------|---------------|-----------|
|1			| Nail Polish	|100.00		|
|2			| Hair Brush	|500.00		|

<br/><br/>
When Order Details of Bob Smith is selected:
### ORDER DETAILS for Bob Smith
|OrderID	| Item			|Price		|
|-----------|---------------|-----------|
|3			| Shaving Cream	|90.00		|


The Blazor Server App should read the data from Test #2 API above.
<br/><br/>
Things to Note:
1. Kindly ensure the code should be in running condition when it's downloaded and
opened in Visual Studio.
2. Kindly ensure all three projects are part of a single Visual Studio Solution.
3. Kindly ensure the database is seeded with above test data.
4. Kindly ensure the order of running the apps is set properly so they run in the same
order.
5. Kindly ensure the app is tested and does not throw any runtime or compilation errors.
6. If you have any questions, kindly ask us.
   <br></br>
ALL THE BEST !!
