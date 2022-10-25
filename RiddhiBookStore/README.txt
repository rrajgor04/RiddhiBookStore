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