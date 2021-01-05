| [<img src="https://avatars1.githubusercontent.com/u/69095640?s=460&u=eefe493b85312d332eedc271ee24a39d586446ae&v=4" width=100 alt="GitHub avatar for author Garrett Brown">](https://github.com/GarrettBrown-dev) | [<img src="https://avatars2.githubusercontent.com/u/72711426?s=460&u=7a5cedd76499b621cb9c470f0d28cd7d6be58106&v=4" width=100 alt="GitHub avatar for author Joseph Giunta">](https://github.com/GiuntaJC) | 

## | **University Registrar Project** |

###### Initiated January 4th. Updated January 5th, 2020.

----------

## Description
A site for tracking the students registered for classes at the unnamed university. Each student will have a list of courses they are currently enrolled in.

## Known Bugs

* No known bugs.

## User Stories and Specifications

<details>
  <summary>Click Here for User Stories and Specifications</summary>

<table>
  <tr>
    <th>Scenario 01</th>
    <th></th>
  </tr>
  <tr>
    <td>Behavior</td>
    <td>As a registrar, I want to enter a student, so I can keep track of all students enrolled at this University. I should be able to provide a name and date of enrollment.</td>
  </tr>
  <tr>
    <td>Input</td>
    <td>Student name, and date of enrollment.</td>
  </tr>
  <tr>
    <td>Output</td>
    <td>New student in the database with name and date of enrollment.</td>
  </tr>
  <tr>
    <td>Notes</td>
    <td>None</td>
  </tr>
  <tr>
    <td>Completion</td>
    <td>True</td>
  </tr>
</table>

</details>

## Setup and Use

#### Prerequisites
* .NET Core 1.1 SDK or higher
* .NET Core Runtime 1.1 or higher
* [Mono](https://www.mono-project.com/)
* [MAMP](https://www.mamp.info/en/)

#### Download Repo
1. Download required software: .NET Core SDK, .NET Core Runtime, Mono
2. Clone [this repository](https://github.com/GarrettBrown-dev): _$ git clone https://github.com/GarrettBrown-dev/UniReg.Solution.git_

#### Open Locally - Browser
1. Navigate to the application directory: _$ cd UniReg.Solution/UniReg_
2. Execute the commands _$ dotnet restore_, _$ dotnet build_, and then _$ dotnet run_
3. Open the localhost link provided by the terminal in your preferred browser
```
D:\user\UniReg.Solution\UniReg>dotnet restore
D:\user\UniReg.Solution\UniReg>dotnet build
D:\user\UniReg.Solution\UniReg>dotnet run
Hosting environment: Production
Content root path: D:\user\UniReg.Solution\UniReg
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
```

#### Open Locally - Mono
1. Navigate to the working directory: _$ cd UniReg.Solution_
2. Use your preferred IDE or editor to edit the project
3. 

#### Compile Locally
1. Navigate to the project directory: _$ cd Name.Solution/Name_
2. Execute _$ mcs Program.cs Models/Database.cs Models/Event.cs Models/Invitee.cs Models/Menu.cs Models/MenuItem.cs Models/MenuItemIngredient.cs Models/Store.cs Models/Task.cs_ to compile new Program.exe file

#### MySql Database Import
1. Open your preferred database manager
2. Import name_name.sql
3. Review database to ensure import was successful
4. Import DemoData.sql to populate event_planner.sql

```
D:\user>mysql -u root -p
Welcome to the MySQL monitor.  Commands end with ; or \g.
Your MySQL connection id is [Your connection id here]
Server version: [Your server version and system here]

Copyright (c) 2000, 2019, Oracle and/or its affiliates. All rights reserved.

Oracle is a registered trademark of Oracle Corporation and/or its
affiliates. Other names may be trademarks of their respective
owners.

Type 'help;' or '\h' for help. Type '\c' to clear the current input statement.

mysql>USE event_planner;
Database changed

mysql>SHOW TABLES;
Query OK, 0 row affected (0.00 sec)

mysql>DESCRIBE [insert any table name, case sensitive];
Query OK, 0 row affected (0.00 sec)

mysql>DemoData.sql
```

#### phpMyAdmin Database Import
1. Start MySql and Apache through MAMP
2. Browse MAMP tools to phpMyAdmin
3. Import event_planner.sql
4. Review database to ensure import was successful
5. Select event.planner.sql, import DemoData.sql

#### Edit
1. Navigate to the working directory: _$ cd UniReg.Solution_
2. Use your preferred IDE or editor to edit the project

#### Test
1. Navigate to the working directory: _$ cd UniReg.Solution/UniReg.Tests_
2. Execute _$ dotnet tests_ to run application tests


## Built With

* Windows 10.1
* iMac OS X El Capitan 10.11.6
* Linux Ubuntu 18.04 bionic
* Atom (IDE)
* VisualStudio Code (IDE)
* C#
* JavaScript / jQuery 3.3.7
* HTML-5 / CSS-3
* Bootstrap 4.1.0
* Microsoft SDK
* Microsoft Web SDK
* .NET Core 1.1 - 2.2
* .ASPNetCore 1.1.2
* MySql (MAMP / phpMyAdmin)

## Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|
| Garrett Brown | [GarrettBrown-dev](https://github.com/GarrettBrown-dev) | [gman9mm@live.com](mailto:gman9mm@live.com) |
| Joseph Guinta | [](https://github.com/) |  [](mailto:) |


## Credits

| | Garrett Brown | Joseph Guinta |
|-|:-----------:|:---------------:|:-------------:|:--------------:|
| **Design** |
| Core Mechanics | |◈| |◈|
| Databases | |◈| | |
| User Interface |◈| |◈| |
| **Programming** |
| Back-End | |◈| |◈|
| Front-End |◈| |◈| |
| Integration |◈|◈| | |
| Refractoring | | | |◈|
| **Visuals** | | | | |
| Wire Frame |◈| |◈| |
| CSS Styling |◈| |◈| |
| Graphics Management | | |◈| |
| **Quality Assurance** |
| Documentation | |◈| |◈|
| Testing | |◈| |◈|

## Support and contact details

If you have any feedback or concerns, please contact any of the contributors (see above).

## License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2020 [Garrett Brown](https://github.com/https://github.com/GarrettBrown-dev), [Joseph Guinta] (https://github.com/GiuntaJC)
```
MIT License

Copyright (c) 2020, Garrett Brown, Joseph Guinta

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

## Acknowledgments

#### [Epicodus](https://www.epicodus.com/)
>"A school for tech careers... to help people learn the skills they need to get great jobs."

#### [The Internet](https://webfoundation.org/)
> "...the first thing that humanity has built that humanity doesn't understand..."
> - Eric Schmidt, Google (Alphabet Inc.)