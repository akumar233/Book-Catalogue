==========================================================================
Project Name: Book Catalogue
Readme.txt
Dated: 17-03-2022
==========================================================================
This file is providing the basic details about the current project developed for Book Catalogue with the use of below given technologies and tools:
1. Visual Studio 2019, 
2. SQL Server 2017
3. Asp.Net Core 3.1
4. EntityFramework 5.0.10


How to run this application - 
1. As this application is developed on Code First approach so, once nuget packages restored please change the connection string of the database on project "BookCatalogue" appsettings.Development.json file. 
2. Once the correct database string will be added build and run the application and the application will launch on url "http://localhost:21072/swagger";
3. If the database is not being updated then remove the migration using command "Remove-Migration -Force" and run the command "Update-Database" in Package Manager Console. 
4. If migration removed then add the migration by using command "Add-Migration "Adding book catalogue entity" and run the command "Update-Database" in Package Manager Console. 

!Enjoy the POC for Book Catalogue microservices!!

==========================================================================