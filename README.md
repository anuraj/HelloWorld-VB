# HelloWorld - Minimal API in VB.NET

This repository contains Weatherforecast Minimal API implementation using VB.NET.

You can build Minimal API using VB.NET by doing the following steps.

1. Create a Console application with command `dotnet new console -lang vb -o HelloWorld --framework net6.0`
2. Modify the project file - `HelloWorld.vbproj`, change the Project Sdk from `Microsoft.NET.Sdk` to `Microsoft.NET.Sdk.Web`
3. Modify the `Program.vb` like this.
```
Imports Microsoft.AspNetCore.Builder

Module Program
    Sub Main(args As String())
    
        Dim Builder = WebApplication.CreateBuilder(args)

        Dim App = Builder.Build()
        App.MapGet("/", Function() "Hello World!")

        App.Run()

    End Sub
End Module
```
4. Run the application using the `dotnet run` command.
5. Happy Programming :)