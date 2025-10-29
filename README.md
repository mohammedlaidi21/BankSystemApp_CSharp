<h1> 🏦 Bank System App </h1>

A <h6>C# Windows Forms</h6> application that simulates a professional <h5>banking system</h5> with full support for <h5>client management, user permissions, transactions, and currency exchange</h5>.  
This project follows the <h5>3-Tier Architecture (DAL - BL - PL)</h5> and uses <h5>SQL Server</h5> for data storage.

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
├── 🗂️ DAL (Data Access Layer)
│ └── Database interaction using SQL commands
├── 🧠 BL (Business Logic Layer)
│ └── Business classes for Clients, Accounts, Users, etc.
├── 💻 PL (Presentation Layer)
│ └── Windows Forms UI for all modules
└── 🗄️ Database
└── SQL Server with normalized schema and foreign keys

<h2>⚙️ Technologies Used</h2>

- **C# (.NET Framework)**
- **Windows Forms**
- **SQL Server**
- **ADO.NET**
- **3-Tier Architecture**
- **Encryption & Bitwise Operations**

<h2>👨‍💻 Author</h2>

Mohammed Laidi
💼 C# Developer | .NET | SQL Server
📧 mohammedlaidi56@gmail.com
🌐linkedin.com/in/mohammed-laidi-7208a2365

