<h1> 🏦 Bank System App </h1>

A *C# Windows Forms* application that simulates a professional **banking system** with full support for *client management, user permissions, transactions, and currency exchange*.  
This project follows the **3-Tier Architecture (DAL - BL - PL)** and uses **SQL Server** for data storage.

<h2>🚀 Features</h2> 

<h4>🧍 Client Management</h4>

- Add, update, delete, and view clients  
- Each client has a unique bank account with balance and PIN  
- Real-time balance updates after transactions  

<h4>💸 Transactions</h4>

- Deposit and withdraw operations  
- Account-to-account transfers with validation  
- Automatic transaction logs with timestamps
- 
<h4> 👤 User Management </h4>

- Add and manage system users  
- Permission control using bitwise flags (`Manage Clients`, `Transactions`, `Manage Users`, `Currency Exchange`)  
- Encrypted passwords for better security  

<h4>🌍 Currency Exchange</h4>

- Manage currencies and update exchange rates  
- Convert between different currencies  
- Supports live calculations and rate adjustments  

<h4>🔐 Authentication & Logging</h4>

- Secure login system  
- Tracks user login history in the database  
- Limited login attempts to prevent brute-force 

 <h2>🧩 Architecture</h2>

BankSystemApp_CSharp
├── 🗂️ DAL (Data Access Layer) <br/>
│ └── Database interaction using SQL commands  <br/>
├── 🧠 BL (Business Logic Layer)  <br/>
│ └── Business classes for Clients, Accounts, Users, etc.  <br/>
├── 💻 PL (Presentation Layer)  <br/>
│ └── Windows Forms UI for all modules  <br/>
└── 🗄️ Database  <br/>
└── SQL Server with normalized schema and foreign keys  <br/>

<h2>⚙️ Technologies Used</h2>

- **C# (.NET Framework)**
- **Windows Forms**
- **SQL Server**
- **ADO.NET**
- **3-Tier Architecture**
- **Encryption & Bitwise Operations**

<h2>👨‍💻 Author</h2>

Mohammed Laidi  <br/>
💼 C# Developer | .NET | SQL Server  <br/>
📧 mohammedlaidi56@gmail.com  <br/>
🌐[linkedin.com/in/mohammed-laidi-7208a2365 ](https://www.linkedin.com/in/mohammed-laidi-7208a2365/)

