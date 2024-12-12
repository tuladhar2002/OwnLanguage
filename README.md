# Introduction

This is my Comparative Language final assignment. I built my own language (currently unnamed) using C# and ANTLR. 

I aimed to mimic the English language so that everything is expressed in words (similar to natural English). For example:

```
j = i > 10
```

would be equivalent to:

```
j -> i is greater than 10
```

### Reason: Why Not? :)

---

# How to Use It

### Step 1

Make sure you have the latest .NET 8 framework installed on your system:

[Download .NET 8 Framework](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### Step 2

Clone the Repository. Ofcourse...

### Step 3

Create a `launch.json` file if it does not exist for the `OwnLanguage.csproj` file, and you should see the magic happen!

You can also use the .NET CLI commands:

```
dotnet build
dotnet run
```

### Step 4

The file `testOwnLanguageFile.txt` is the file being compiled, so you can play around with it and test it out!

---

# Rules

Below is the table of rules for using the language:

| Operator      | Use This Instead                | Example                                 |
|---------------|---------------------------------|-----------------------------------------|
| `=`           | `->`                           | `j -> 10;`                             |
| `==`          | `is equal to`                  | `10 is equal to 10;`                   |
| `+`           | `plus`                         | `k -> 10 plus 13;`                     |
| `-`           | `minus`                        | `k -> 10 minus 3;`                     |
| `*`           | `times`                        | `k -> 5 times 25;`                     |
| `/`           | `divided by`                   | `k -> 5 divided by 1;`                 |
| `%`           | `modulus`                      | `k -> 10 modulus 3;`                   |
| `!=`          | `is not equal to`              | `10 is not equal to 5;`                |
| `<`           | `is less than`                 | `5 is less than 10;`                   |
| `<=`          | `is less than or equal to`     | `5 is less than or equal to 10;`       |
| `>`           | `is greater than`              | `10 is greater than 5;`                |
| `>=`          | `is greater than or equal to`  | `10 is greater than or equal to 5;`    |
| `and`         | `and`                          | `true and false;`                      |
| `or`          | `or`                           | `true or false;`                       |
| `print()`     | `show yourself("...")`        | `show yourself("Pokemon!");`         |

---

# In Progress

I will be adding features to support conditionals, functions, and loops soon.

---
