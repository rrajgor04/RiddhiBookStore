10/20/2022
1042- created a default ASP.NET Core MVC application 
- using .NET Core 3.1 LTS
-individual accounts
- kept the htps default
- added razor  runtime...
1044
dammit .... i have to run this in  the lab 
need to comment out the json entry for https ... lab only
properties/launchsettings.json
1048 - it works!!
just in case review the pachkages..
checked the packages to Confirm SQLServer...
1052 lets push to GitHub

2022/10/25
1115- review the default code.
removed the option flag in startup.cs Line 33  (options => options.SignIn.RequireConfirmedAccount = true)

1121
built the app and ran it .
went successful.
reviewd the github repo and created a README.md with the starting description of the project
all done for today!


03/11/2022
12:15am
downloaded bootstrap theme ... I selected Quartz(A glassmorphic layer)...
replaced bootstrap.css in css and in site.css..
changed some layout...

12:22am 
removed all text-dark preferances from LoginPartial.cshtml

12:24am
run the program and it went successful...

12:49am
added some script in layoiut_cshtml...

2:23am 
added dropdown menu but having error ...

10:04am
added  3 new projects in the folder 
installed EF and Sql server and deleted migration folder

10:38am
got error in startup.cs in line 10...
Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0234	The type or namespace name 'Data' does not exist in the namespace 'RiddhiBookStore' (are you missing an assembly reference?)	RiddhiBookStore	C:\Users\W0793048\Source\Repos\rrajgor04\RiddhiBookStore\RiddhiBookStore\Startup.cs	10	Active
Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0246	The type or namespace name 'ApplicationDbContext' could not be found (are you missing a using directive or an assembly reference?)	RiddhiBookStore	C:\Users\W0793048\Source\Repos\rrajgor04\RiddhiBookStore\RiddhiBookStore\Startup.cs	30	Active
Error	CS0246	The type or namespace name 'ApplicationDbContext' could not be found (are you missing a using directive or an assembly reference?)	RiddhiBookStore	C:\Users\W0793048\Source\Repos\rrajgor04\RiddhiBookStore\RiddhiBookStore\Startup.cs	34	Active


11:05am
found error and updated there were file name mistakes....

11:08am
got error in HomeController.cs in namespace...