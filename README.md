Here’s a clean and well-structured **README.md** file you can use for your GitHub repository 👇

---

# 🧮 Numeric Validation using Regular Expressions (C# Windows Forms)

A simple **Windows Forms Application (C#)** that validates numeric inputs using **Regular Expressions**.
It checks for integers, floating-point numbers, and scientific notation (e.g., `1.23e+4`) entered by the user.

---

## 🚀 Features

* ✅ Validates numbers, decimals, and scientific notation
* ❌ Detects invalid formats (e.g., `.5`, `1.2.3`, `12e++5`, `abc`)
* 🪟 Built with **Windows Forms** in **Visual Studio 2022**
* 💬 Displays valid inputs in a text box and shows invalid inputs via message boxes

---

## 🧠 Regular Expression Used

```regex
^[0-9][0-9]*(([.][0-9][0-9]*)?([e][+|-][0-9][0-9]*)?)?$
```

### Explanation:

| Part                | Description                                     |                              |
| ------------------- | ----------------------------------------------- | ---------------------------- |
| `[0-9][0-9]*`       | Matches one or more digits (integer part)       |                              |
| `([.][0-9][0-9]*)?` | Optional fractional (decimal) part              |                              |
| `([e][+             | -][0-9][0-9]*)?`                                | Optional scientific notation |
| `$`                 | Ensures the match ends at the end of the string |                              |

---

## 🧪 Example Input

```
123 45.67 9e-3 100.25e+5 .5 1.2.3 12e++5 abc
```

### ✅ Expected Output

| Input       | Result  |
| ----------- | ------- |
| `123`       | Valid   |
| `45.67`     | Valid   |
| `9e-3`      | Valid   |
| `100.25e+5` | Valid   |
| `.5`        | Invalid |
| `1.2.3`     | Invalid |
| `12e++5`    | Invalid |
| `abc`       | Invalid |

---

## 🖥️ How It Works

1. The user enters space-separated values into **TextBox1**.
2. When the **Validate** button is clicked:

   * Each value is checked against the regex.
   * Valid numbers are displayed in **TextBox2**.
   * Invalid entries trigger a message box.

---

## 🧩 Technologies Used

* **C#**
* **.NET Framework / .NET 6+**
* **Windows Forms (WinForms)**
* **Visual Studio 2022**

---

## 📂 Project Structure

```
📦 WinFormsApp1
 ┣ 📜 Form1.cs
 ┣ 📜 Form1.Designer.cs
 ┣ 📜 Program.cs
 ┗ 📜 README.md
```

---

## ⚙️ How to Run

1. Open project in **Visual Studio 2022**
2. Build the project (`Ctrl + Shift + B`)
3. Run (`F5`)
4. Enter test values in the input box and click **Validate**

---

## 💡 Future Improvements

* Support negative and positive signs (`-12`, `+3.14`)
* Highlight invalid words instead of using message boxes
* Add file input/output for bulk validation

---

## 🧑‍💻 Author

**Muhammad Haseeb**


---

Would you like me to make a version that includes **screenshots and sample output** formatting (for a more professional GitHub look)?
