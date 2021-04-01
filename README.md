## <div align="center">Pierre's Sweet and Savory Treats</div>
#### <div align="center">📚 *Epicodus Independent Project # 11  (Week 5 of C#)  3/26/2021* </div> 
***<p align="right">By Daniel Adeyemi***</p>   
<p align="center"> 

<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="30" />
<img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="30"/>
<img alt="MySQL" width="30px" src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/topics/mysql/mysql.png" /> 
</p>

<div style="text-align:center"><img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR3Fbe7SlqSVJDbtu02mXtXZVEhA27SDKQ3cw&usqp=CAU" alt="Bakery image" width="300"/></div>

___
## <div align="center"> Table of Contents: 
| [Description](#description) | [Setup and Installation instructions](#setup) |  [SQL setup instructions](#sql) |
| :-------------: |  :------------: | :-------------: |
[Technology used](#technology) | [Known bugs](#bugs) | [View Website](#view)
| [Improvement opportunities](#improvement) | [Contact information](#contact)|  [License and copiright](#license)|
| | |  |
</div>

<!-- <a name="description"></a>
## <div align="center"> 🚩 *Description*:</div>    

##### ***An MVC app to manage engineers and machines they can repair on factory. User will be able to add(hire) an engineer, add(install) machine and assign machines to engineers and vice versa.***

<a name="setup"></a>
## <div align="center"> 🔧 *Setup/Installation instructions:*
#### 🌐 From the web:
* Go to my GitHub repository, using following [URL](https://github.com/DanielAdeyemi/Factory.Solution.git).
* * At the top of the repository, click <img src="https://i.imgur.com/Ej9Dphm.png" alt="Code Button" height="20" align="center" /> then select "Download ZIP".

<img src="https://i.imgur.com/tZKvGne.gif" alt="download zip gif" height="200"/>

* Unzip the file, navigate to the `Factory` directory to check code
#### ⚙️ From the terminal: 
* Clone my repository from GitHub using `git clone https://github.com/DanielAdeyemi/Factory.Solution.git` in your terminal or GitBash
* Navigate to the downloaded folder using ***cd*** command
* Execute **code .** command in your terminal and it will open all source code in your code editor.    
⚠️ *Note: To run this project locally you will need to have .NET Core. You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet).*

<a name="sql"></a>
## <div align="center"> 🗃️ SQL setup and connection to the application
* In your terminal start using mysql by running command: `mysql -u[YOUR-USERNAME] -p[YOUR-PASSWORD]` 
* run command `SOURCE [PATH-TO-THE-PROJECT]/daniel_adeyemi.sql` to recreate database and tables.
* inside `Factory` folder create **appsettings.json** file and input following information:    
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=daniel_adeyemi;uid=[YOUR-ACCOUNT-NAME];pwd=[YOUR-PASSWORD];"
  }
}
```
⚠️ *Note: Don't include **[ ]** around your username or password in any of the examples above.*    
***If you need to set up SQL database - click on details below:***
<details>
<summury>Details to set up DB </summary>

- You need to have MySqlWorkbench installed on your machine. You can download it [here](https://www.mysql.com/products/workbench/)   
- In the navigator > Administration window, select Data Import/Restore   
- In Import Options select Import from Self-Contained File.   
- Navigate to daniel_adeyemi.sql in the Factory.Solutions directory   
- Under Default Schema to be Imported To, select the New button.   
- Enter the name of your database   
- Click ok   
- Click Start Import   
- Reopen the Navigator > Schemas tab and refresh the schemas(using `Refresh All`).    
 *If you already have everything set up and want to use Migrations from this project (**Highly recommended!**), follow steps below*:
- run `dotnet restore` to restore all necessary packages
- run `dotnet ef database update` to apply database structure from the migrations (***make sure you are inside Factory directory!***)
</details>

<a name="view"></a>

### <div align="center">  🖥️ View website:
*GitHub page is not available for this project. To view functionality you need to run `dotnet run` from **Factory** folder. After that you will see `http://localhost:5000`, click on that link and it will open web appliction in your default browser. In order to exit from local host use **Ctrl+C** command.*

<a name="technology"></a>

## <div align="center"> 🛠️ *Technologies used:*
* C# 9
* .NET 5.0
* ASP.NET Core MVC
* ASP.NET Identity
* Razor View Egine
* RESTful Routing, CRUD & HTTP
* CSHTML and CSS
* Bootstrap v.4.6.x
* REPL
* Git and GitHub
* MySQL and MySQL Workbench
* Entity Framework Core

<a name="bugs"></a>

## <div align="center"> 🐛 *Known bugs:*
This project was used to practice building web applications with SQL database, Entity Framework and Many-to-Many Relationships. Application has basic style.

<a name="improvement"></a>

## <div align="center"> 🌟 *Improvement opportunities:*
* add more style to the pages
* don't let assign machine to engineer if it's already in his list. 
* don't let assign engineer to machine if he already has license to repair it. 

<a name="contact"></a>

##  <div align="center"> 📬 Contact Information
#### For any questions *[email author](mailto:adeyemidany+github@gmail.com?subject=[GitHub])*

<a name="license"></a>

## <div align="center"> 📘 *License and copyright:*

> ***© Daniel Adeyemi, 2021***  
> ⚖️ *[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)* -->