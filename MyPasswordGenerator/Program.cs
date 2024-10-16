// By default, all characters available for use and a length of 16
// Will return a random password with the default settings 
using PasswordGenerator;

// var pwd = new Password(includeLowercase: true, includeNumeric: true, includeUppercase: true, includeSpecial: false, passwordLength: 16);
var pwd = new Password(17).IncludeLowercase().IncludeNumeric().IncludeUppercase().IncludeSpecial("[]{}!^_=");
var password = pwd.Next();
Console.WriteLine(password.ToString());