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

<<<<<<< HEAD
10:25am 
getting error in errorViewModel and Error.cshtml
=======
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

did till page 34
2022/08/11
10:13am added refernce in RiddhiBooks.DataAccess
10:16 added class in thew utility project...

10:39am - sorted out dropdown issue...added some missing lines.

1131am
moved some folders according to slides..run the program but getting error in prom.cs as a exceptions......

1145am
exception are coming in startup.cs..


2022/10/11
1136am
made changes in Viewstart.cshtml...
everything is going good..

1137am 
run the program .. ah! localhost error coming...

1145am
somewhere in between startup.cs and launchsetting.json  error is there find the error or else mail to professor.
>>>>>>> parent of 95df79d (trying to figure out the local host error...)

2022-22-11
938am
made changes in startup.cs and homeController.cs

1051am
created a area folder name admin and deleted the HomeController.cs folder...

1111am
error coming in program.cs as a exception handling...

1130 part2 
added migrations...

2022-23-11
347pm
updated category.cs ..

420pm
deleted the existing addCategoryToDb.cs and re-run the migration addCategoryTodb and the new file has the table details...

429pm
made changes in .csproj and added folder reference in it for Repository folder that i created ...

536pm
added folder name Repository in DataAccess folder.. sub Folders are  IRepository ...
edited files are : 
ICategoryRepository.cs
IRepository.cs
CategoryRepository.cs
Repository.cs...

551pm 
changes made in categoryRepository.cs...

2022-11-24
1015am 
added ISP_Call.cs in repository file...

323pm
added folders in Repository files ...
error coming in UnitOfWork.cs file...

2022-11-29
1030am
made a index.cshtml file for the output..
and also made a file CategoryController.cs..

1104am
made changes in _Layout.cshtml..

123pm 
error in categoryController.cs 
trying to figure out...

2022-12-01
108pm 
there was an error in UnitOfWork.cs 
in line 23 (        public ISP_Call SP_Call { get; private set; }
) when its public its showing this error (Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0053	Inconsistent accessibility: property type 'ISP_Call' is less accessible than property 'UnitOfWork.SP_Call'	RiddhiBooks.DataAccess	C:\Users\W0793048\Source\Repos\rrajgor04\RiddhiBookStore\RiddhiBooks.DataAccess\Repository\UnitOfWork.cs	23	Active
) and when I convert it into private property it showed me no error...

211pm
error in CAtegoryCintroller.cs 


2022-12-03
126am
Above error is solved by making all interfaces and their classes public and adding IUnitofWork file from DataAccess instead of its copy that was in controller folder of admin area.
and also cooorected some methods in UnitofWork and Iunitofwork file

145am
Now finding and fixing some of the hidden bugs to make the app run, so i can move further.

156am
Fixed issue with customer area and its home controller

228am
deleted some unlocated files and moved index view of category to its place.
copied _viewstart and _viewimport files to views folder of category

235am
Now geting this error on the browser
InvalidOperationException: Unable to resolve service for type 'RiddhiBooks.DataAccess.Repository.IRepository.IUnitOfWork'
while attempting to activate 'RiddhiBookStore.Areas.Admin.Controllers.CategoryController'.

237am
solved above error by adding "services.AddScoped<IUnitOfWork, UnitOfWork>();" the correct option in this line of statup.cs file.

240am
getting some issues with bootstrap theme, let's check

244am
Ithink I need to change the theme because of incompatability of bootstrap version

245am
Now selected Minty theme with correct bootstrap version.

249am
changed bootstrap file but still not looking good on browser

250am
Replaced site.css with the one given on blackboard.
theme looking good now but links not working now

352am
now bootstrap theeme lokks fine and links are also working. issue solved by moving a duplicate views folder from area , placing it at the root of bookstore project

356am
added required css links that was removed while fixing the links

401am
Database name corrected in appsettings

406am
Deleted code for edit and delete butons from index of category now using javascript file

412am
Created upsert view for category

423am
Created two partial view files for buttons

429am
Updated upsert view and added its link to index view of category

434am
Added validation script to upsert

438am
Created upsert post method for category

442am
added delete api call for category and delete method added into category javascript file wiyh onclick event

445am
Heading to part-3

447am
Created CoverType model class

449am
Added a public interface of IcovertypeRepository

456am
Dbset of covertype added
Created Public class of CoverTypeRepositopry for its interface and implemented it.

503am
CovetypeRepository renamed because there was atypo in name.
Added Covertype in UnitOfWork and IUnitOfwork

505am
Added Coveertype to dayabase and here is the migration timestamp. "20221203100516_AddCoverTypeToDb"

509am
Created CoverType controller wit all required methods

512am
Created index view of covertype with datatable

516am
Added upsert view for coverType

517am
Added CoverType to nav bar

523am
Created model class for product

526am
Added products table to database here is the migration timestamp "20221203102530_AddProductToDb";

529am
Added validation to Product and here is its migration "20221203102930_AddValidationToProduct"

534am
Created ProductRepository class and its rellative interface

536am
Product added in UnitofWork interface and class files

549am
Created ProductVM viewmodel and Productcontroller and commented post upsert method for now

554am
Created index View file for product and created its javascript

556am
Added link of product in navbar dropdown

603am
Created Upsert view file for Product