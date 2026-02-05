## Description

This is a simple C# console application that generates random voucher-like codes.  
Each code is a 14-character string composed of the letters **A** and **N**, formatted with hyphens between characters.  
The program generates multiple codes, stores them in memory, and prints the results to the console.

The codes are created using a random generation approach, not a mathematical permutation, so duplicate values may occur.

## How It Works

1. Generates random strings using `System.Random`
2. Formats the output using `Regex`
3. Stores records in a `List<T>`
4. Attempts to filter duplicates using LINQ
5. Prints results in the console

## Technologies Used

- C# (.NET Console Application)
- LINQ
- Regular Expressions (`System.Text.RegularExpressions`)
- .NET Base Class Library

،اشدن غخ
© Mojtaba Golnouri  
GitHub: https://github.com/golnouri
