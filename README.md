this my academic project

Scenario Description 
 
Village heath workers (VHWs) are critical to providing primary healthcare in the public health domain. However, reporting is often a challenge in developing countries due to the non-availability of electronic reporting systems. Oftentimes, VHWs wait until they visit health facilities for them to report on their activities, affecting the timeliness and in some instances, the accuracy of the reported data as paperbased systems lack data validation upon entry. Moreover, generating reports with the existing system is time-consuming. There are growing calls to enhance the quality and timeliness of health data to enhance decision-making, thus, calling for emerging digital health technologies that promote data-driven decisionmaking. A recently-appointed board to oversee the public health sector in your country is composed of a vibrant team that includes recent Botho University graduates who studied Health Information Management, and they have proposed that a desktop application be developed for use by VHWs to enhance reporting. 
 
Suppose one of the board members has approached you to develop the system whose minimum specifications are indicated hereunder: 
•	Create a database called VHW.  
o Your database must store details about VHWs, villages, patients, drugs and health facilities.  
•	For VHWs, store names, sex (male/female), highest level of education, phone number, email address, the village in which they stay, and national identity number.  
•	For villages, you must store the village name, its population and the ward number in which it exists. Create a separate table for wards, in which to store the ward number and name. 
•	For drugs, store the drug name, batch/lot number, and expiry date. 
•	For health facilities, store the facility’s name, address, phone number, email address and type (i.e. clinic, hospital or health centre). 
•	For patients, capture their full names, address, contact details, sex, and date of birth. 
o	All drug issuances by VHWs must be captured in the database in a table that stores the drug issued, patient to which the drug was issued, the VHW who issued the drug, and the date of issue. 
o	All drugs dispensed to VHWs by health facilities must be captured in the database, including the drug name, batch/lot number, date issued, issued by and quantity. 
o	Note: Include any other tables as necessary. All tables must be normalized to 3NF.  
•	Develop the VHWs application that meets the following minimum functionalities: 
o	Authenticates all users. All users of the system must be authenticated using their own username and password. Do NOT ask users to select their user type/role when logging in. Your system must determine a user’s role based on the provided username and password. There must be only one login screen for all user types, taking the username and password only.  
o	Redirects users to appropriate landing pages (upon successful authentication) based on their user roles. 
o	Allows healthcare professionals, such as nurses and doctors, from healthcare facilities to create accounts for VHWs, capture new drugs received and those issued to VHWs. They should be able to modify any of these records too. However, all modifications to drugs received and/or issued must be logged to a file for audit trail purposes. The logged data must include the date and time when the modification was done, the username of the person who modified and the type of modification done (e.g. deletion, updating, etc.).  Details of the issuer must be automatically picked based on the logged in person, e.g. If the currently logged in user is Mr Jones, use that person’s details as the issuer. 
o	Allows healthcare professionals to record details of issued drugs to VHWs. 
o	Allows users to search, update and delete records in the database. However, all modifications and deletions must be logged in a file for audit purposes, and you must allow users to provide a description justifying the need for the modification, and this description must also be captured in the database.  
o	Allows the retrieval of deleted records. To achieve this, temporarily store all deleted records in a separate table. However, only Admins should be able to recover deleted records.  
o	The system should be able to generate reports, and the following reports must be accessible to the specified users: 
•	Healthcare professionals – drugs issued out by a specific healthcare professional to VHWs within a specified period, drugs issued to VHWs by ward, drugs issued to VHWs by sex. 
•	VHWs – drugs issued out within a given period and the remaining quantities, drugs issued to patients by sex and age. 
o	You must have a user role called Admin, and multiple users can fall in this role (Note: Admin must not be a username, but user role, with each Admin user having their own set of login credentials). Admin users must be able to create, modify or delete users, but cannot issue medicines/ drugs. 
o	All user input must be validated, and appropriate messages displayed to users in cases of invalid input.  
o	All exceptions and errors must be handled and logged to appropriate files.  When logging errors and exceptions, include the date and time when they occurred, and the username of the person who was logged in.  
• Create parameterised methods for writing to files. 
o	You must follow all OOP concepts (e.g. using classes, inheritance, interfaces and abstract classes) learnt in the module when developing and designing your application. 
o	Comments are mandatory, and every source file must include your details at the top as comments. 
Required 
(a)	Develop the application with the minimum requirements described above using the C# programming language and Microsoft SQL Server. [You may use Microsoft’s RDLC reporting mechanism]
 	[70 Marks] 
(b)	Document your application, including all the designs of it and user manual. 
