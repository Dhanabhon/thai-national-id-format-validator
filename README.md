# Thai National ID Format Validator Library for .NET
For example the Thai national ID format validation in C#
- Written in C# .NET Core 6.0

## How to use?
1. Import the Thai national ID format validator to your project.
```C#
using thai_national_id_format_validator;
```
2. Thai National ID Card Number Checking
```C#
bool isValid = ThaiNationalIdFormat.IsValid("1234567891012");
```
3. Thai national ID Card Numbers Generating.
```C#
String num = ThaiNationalIdFormat.GenerateThaiNationalID();
```

## Demo
![Screenshot](https://raw.githubusercontent.com/Dhanabhon/thai-national-id-format-validator/master/ss.png)

## NuGet Link
[NuGet](https://www.nuget.org/packages/thai-national-id-format-validator/)

## Inspiration
This plugin is inspired by [thai-id-validator](https://www.npmjs.com/package/thai-id-validator).
