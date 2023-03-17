# 🍀 _Dr. Shamrock Sillystringz's Factory_ 🍀

#### 🍀 By Eliot Gronstal 3.17.23 🍀

#### _A MVC web application for a factory to manage their engineers and the machines they are licensed to fix. Made for Week 11 Epicodus Independent Code Review focusing on many-to-many relationships._

## Technologies Used 

* 🏭 _C#_
* 🏭 _.NET_
* 🏭 _HTML_
* 🏭 _MVC_
* 🏭 _SQL Workbench_
* 🏭 _Entity Framework_
* 🏭 _CSS_

## Description

 A MVC web application for Dr. Shamrock Sillystringz to manage the factory's engineers and the machines the engineers are licensed to fix featuring a database and app with with many-to-many relationships. An engineer can be licensed to repair many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it.
 
 * 🧑‍🏭 The factory manager can add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. 

* 🧑‍🏭 The factory manager can see a list of all engineers see a list of all machines.

* 🧑‍🏭 The factory manager can select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. The factory manager can select a machine, see its details, and see a list of all engineers licensed to repair it.

* 🧑‍🏭 The factory manager can add new engineers to the system when they are hired. The factory manager can add new machines to the system when they are installed.

* 🧑‍🏭 The factory manager cannot create an engineer or a machine if the form's fields are empty or contain invalid values.

* 🧑‍🏭 The factory manager can add new machines even if no engineers are employed and also add new engineers even if no machines are installed.

* 🧑‍🏭 The factory manager can add or remove machines that a specific engineer is licensed to repair and also modify this relationship from the other side, and add or remove engineers from a specific machine.

* 🧑‍🏭 The factory manager cannot add a machine to an engineer if there are no machines. Likewise the manager cannot add an engineer to a machine if there are no engineers.

* 🧑‍🏭 When the factory manager accesses the application they can see a splash page that lists all engineers and machines.

## Setup/Installation Requirements

* 🔨 _Clone this repo._
* 🔨 _Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "Factory"._
* 🔨 _In the command line, run the command ``dotnet run`` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal._
* 🔨 _Optionally, you can run ``dotnet build`` to compile this console app without running it._
* 🔨 _This program was built using `Microsoft .NET SDK 6.0`, and may not be compatible with other versions._

* 🔨 _If you want to run the project in production mode with a watcher, you can use a command line flag to specify that you want to run the "production" profile. ``dotnet watch run --launch-profile "production"``_
* 🔨 _Open the browser to [https://localhost:5001]. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate.](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate)_

## SQL Workbench Configuration
* 🔧 _Create an `appsetting.json` file in the "Factory" directory of the project._
* 🔧 _Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL._ 
```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* 🔧 _If you'd like to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore first._
* 🔧 _Once "appsettings.json" file has been created, follow the below directions for Entity Framework Migration Configuration._ 

## Entity Framework Migration Configuration

* 🧑‍🏭 _In root directory of project folder "Factory", run `dotnet ef migrations add restoreDatabase`_
* 🧑‍🏭 _Then run $ `dotnet ef database update`_
* 🧑‍🏭 _Open SQL Workbench._
* 🧑‍🏭 _Navigate to "factory" schema._
* 🧑‍🏭 _Click the drop down, select "Tables" drop down._
* 🧑‍🏭 _Verify the tables. There should be: engineers, engineermachines, and machines._

## Test Instructions

* 🔨 _Using a shell program, navigate from the root directory, "ShamrockSillystringz.Solution," to the "Factory.Tests" directory._
* 🔨 _Once in the "Factory.Tests" directory, type ``dotnet restore`` into the console._
* 🔨 _After the restore process is complete, type ``dotnet test`` into the console. This will run all written tests and display the test results into the console to review._

## Known Bugs

* 🍀 _No known bugs._

* 🍀 _Please reach out with any questions or concerns to [eliot.lauren@gmail.com](eliot.lauren@gmail.com)_

## License

_[MIT](https://opensource.org/license/mit/)_

Copyright (c) _2023_ _Eliot Gronstal_