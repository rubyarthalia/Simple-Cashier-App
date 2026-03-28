# 🛒 Simple Cashier App

A desktop-based cashier management system built using **C#** and **Windows Forms (.NET)**. This application is designed to handle the standard workflow of a restaurant or cafe, from table selection to payment and receipt generation.

---

## ✨ Features

* 🔐 **Secure Login**: Access control via a login interface.
* 🪑 **Table Management**: Dedicated interface for selecting and managing customer tables.
* 🍱 **Categorized Menu**: Separate modules for browsing and selecting Food and Drinks.
* 💰 **Payment Processing**: Integrated payment module to calculate totals and handle transactions.
* 🧾 **Receipt Generation**: Generate a formal "Nota" (receipt) for customers after payment.
* 🖼️ **Visual Catalog**: High-quality image resources for various menu items like Ayam Penyet, Gado-gado, and various juices.

---

## 🛠️ Tech Stack

* **Language**: C#.
* **Framework**: .NET Windows Forms (WinForms).
* **IDE**: Visual Studio.

---

## 📂 Project Structure

```text
/project-root
│
├── FormLogin.cs       # Authenticates users
├── FormTable.cs       # Manages table selection
├── FormMenu.cs        # Main dashboard for the ordering process
├── FormFood.cs        # Interface for selecting food items
├── FormDrink.cs       # Interface for selecting drink items
├── FormPayment.cs     # Handles transaction logic
├── FormNota.cs        # Displays the final customer receipt
└── Resources/         # Image assets for the menu
```

---

## 🚀 How to Run

1.  **Prerequisites**: Ensure you have **Visual Studio** installed with the **.NET Desktop Development** workload.
2.  **Open the Project**: Open the `.csproj` file in Visual Studio.
3.  **Restore Packages**: Ensure any required dependencies in `packages.config` are restored.
4.  **Build & Run**: Press `F5` or click **Start** to launch the application.

---

## 🍱 Menu Highlights

The application includes pre-configured resources for popular Indonesian dishes and beverages, such as:
* **Foods**: Ayam Goreng, Bakso Sapi, Empal Penyet, Rawon, and Sate Ayam.
* **Drinks**: Es Cendol, Es Jeruk, Jus Alpukat, and Teh Tarik.

---

## 👤 Author
*Ruby Arthalia, Deborah Michelle Kwandinata, Varrel Tjandra, Anne Tantan*
*Created as an ALP (Assessment of Learning Process) project for Application Development Class.*
