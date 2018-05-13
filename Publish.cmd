dotnet publish DotNetCore.CodeAlignment -c Release
robocopy DotNetCore.CodeAlignment\bin\Release\netcoreapp2.1\publish P:\DotNetCore.CodeAlignment\ /S /PURGE /MT
robocopy DotNetCore.CodeAlignment\bin\Release\netcoreapp2.1\publish Q:\DotNetCore.CodeAlignment\ /S /PURGE /MT