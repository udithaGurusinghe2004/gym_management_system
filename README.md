REVELUTION: ENTERPRISE GYM MANAGEMENT SYSTEM
Academic Semester Group Project Documentation & Submission Manual
――――――――――――――――――――――――――――――――――――――――――――――――――



1. Project Executive Summary
REVELUTION Gym Management System is a computer software (Desktop App) made to make everyday gym work easy. Built using the C# programming language and Microsoft SQL Server database, it helps you to:
•	Manage Members: Add new gym members and search for their information easily.
•	Control Staff: Safely keep details of trainers and other gym employees.
•	Track Equipment: Note down valuable gym machines, their buying prices, and the muscles they target.
Instead of writing in old books, this software helps you control all your gym data safely and very fast from a single computer system.

2. System Architecture & Feature Modules
Security & Authentication Interface (Form1.cs):
 It secures the system by checking the user's role (like Administrator or Staff) and restricting what they can do. It also handles secure logins, safe logouts, and runtime memory cleanup to keep the system protected. 
Member Management Subsystem:
The new member registration form (NewMember.cs) accurately collects details like the member's name, age, workout hours, phone numbers, and membership duration. Additionally, the advanced search section (SearchMember.cs) helps find member information instantly using their Member ID,while the member removal portal (DeleteMember.cs) allows administrators to safely delete unwanted records to keep the database clean.

Staff Tracking (NewStaff.cs):
This module manages information for gym trainers, instructors, and other employees. It safely records and stores details such as their hire dates, job roles, and contact numbers.

Equipment Control (Equipment.cs):
It systematically manages all valuable gym workout machines and hardware. Recording the specific muscle groups targeted by each machine (the "Muscles Used" field) makes it easy for trainers to design member workout schedules. It also clearly tracks the purchasing price, delivery date, and maintenance costs of the equipment.
3. Technological Specification Stack
System Layer	What It Does	The Technology Used
User Interface (Front-End)	This is the visual part of the app that the user sees and interacts with. It uses a modern dark-colored theme to make it look professional.	
Windows Forms (WinForms)
System Logic (Back-End)	This is the "brain" of the app. It handles the behind-the-scenes math, rules, button clicks, and processes the data.	
C# (C-Sharp) Language (.NET Framework)
Data Storage (Database)	This is the digital filing cabinet where all member info, staff details, and equipment records are safely stored long-term.	
Microsoft SQL Server (MsSQL)
Development Tool (IDE)	This is the main software studio your group used to code, design the forms, and build the final application.	
Microsoft Visual Studio


4. Environment Directory Structure
Gym-Management-System
│
├── 📁 GymManagementSystem/          (C# Windows Forms Source Logic Folder)
│   ├── Form1.cs                    (Authentication Portal UI & Event Handler)
│   ├── NewMember.cs                (Client Registrations Onboarding Controller)
│   ├── NewStaff.cs                 (Personnel Onboarding & Role Auditor)
│   ├── Equipment.cs                (Asset Management Inventory Module)
│   ├── SearchMember.cs             (Indexed DB Relational Target Locator)
│   └── DeleteMember.cs             (Data Purge & Row Deletion Safety Component)
│
├── 📁 Database/
│   └── gym_db.sql                  (Structured T-SQL Server Schema Migration Script)
│
└── GymManagementSystem.sln         (Visual Studio Direct Solution Blueprint File)



5. Environment Initialization & Setup Guide
Phase I: Relational Database Deployment
	Launch SQL Server Management Studio (SSMS) and successfully authenticate into  local active engine instance database node.

	Instantiate the master storage catalog via the subsequent baseline administrative execution command:
CREATE DATABASE gym;

	Open the embedded 'Database/gym_db.sql' script file inside the query window and execute it entirely. This completely deploys the required entity tables, indexing clusters, relational keys, and foundational columns automatically.



Phase II: IDE Compilation & Deployment
	Open the workspace container natively by executing the root manifest document file: GymManagementSystem.sln inside Visual Studio.

	Locate the internal database connectivity manager configurations or inline instantiation lines inside  codebase logic and update the SQL data source target to link with  unique local desktop server host instance parameter string:
SqlConnection con = new SqlConnection(@"data source = YOUR_LOCAL_SERVER_INSTANCE; database = gym; integrated security = True");

	Initiate the explicit Visual Studio Compilation Build Pipeline. Ensure zero application compilation errors or references fault flags appear, and execute the runtime profile safely via the primary 'Start' interface element.

Phase III: System Access & Login Methods

The application uses dynamic, role-based login workflows on the main login page (Form1.cs). Authorized users must enter their assigned credentials to access their respective system dashboards:

1.	Owner / Administrator Access Method

•	Purpose: To open the full system configuration view and manage coaches or trainers.
•	Username: Admin123
•	Password: owner
•	Workflow: Upon entering these credentials, the system loads the administrative registration view. The owner can then add new members, delete profiles, or register gym coaches through the NewStaff.cs interface form.

2.	Coach  Access Method

•	Purpose: To log into the system using account credentials explicitly generated and provided by the owner.
•	Example Username: coach1
•	Example Password: 12345678
•	Workflow: When a coach types in their specific account credentials, the application logs them into their authorized system view to manage gym sessions, view schedules, and check assigned member profiles.

6. Academic Archival Submission Checklist
To ensure complete compliance with grading frameworks, construct your final singular zip package layout using this structural directory topology:
📦 Group_Project_Submission_Zip/
├── 📁 Source_Code/
│   ├── 📁 GymManagementSystem/       (Complete development components, designer modules, and forms)
│   ├── 📁 Database/
│   │   └── gym_db.sql               (Fully verified deployment query database asset)
│   └── 📄 README.md                 (Your structural setup manual instructions documentation)
├── 📁 Presentation_Slides/
│   └── REVELUTION_Project_Presentation.pptx (The compiled structural project oral defense slide deck)
└── 📁 Git_Repository_Evidence/
    ├── 📄 git_commit_history.txt    (Systematic chronological contribution logs extracted from shell terminal)
    └── 🖼️ git_repository_screenshot.png (Visual proof tracking of group asynchronous project version history)


Git Logging Evidence generation: 
To extract absolute, un-falsifiable cryptographic contribution history for grading panels, execute the alternative command from your project repository command terminal: git log --graph --oneline --all --decorate > git_commit_history.txt. Relocate this generated plain text asset inside your submission package's Git folder.
File path for exe file:
gym_management_system\gym_management_system\bin\Release\gym_management_system

Github link:
https://github.com/udithaGurusinghe2004/gym_management_system.git
