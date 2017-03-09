# C# Kata 1: Creating a basic console app

##Install Dependencies

- Even if you have .NET Core installed already, follow the instructions [on this page](https://www.microsoft.com/net/core#macos) to install .NET Core, the SDK, and any dependencies. (Note: there’s currently a few issues with OS X 10.11; let me know if you have problems and I can walk you through it.)
- Type `dotnet --version` in the console to ensure that you have version `1.0.0-preview2-1-003177` installed.
- Install the [C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp) for VSCode.
 
##A familiar kata...

1. Create a new folder named **kata-1**
2. Change your active directory to **kata-1** and type:
  a. `dotnet new`
  b. `dotnet restore`
  c. `dotnet run`
  d. (You should see "Hello World" printed in the console.)
3. Open **Program.cs** and change the file’s namespace to `Kata1`.
4. Create a new file named **Player.cs**. Ensure that Player’s namespace is the same as Program’s.
5. This file should contain a `public` class that takes a first name and a last name in the constructor.
6. Create a `public` method on the class that returns the first and last name as a single `string`.
7. In the **Program.cs** main method, create a new instance of the `Player` class and print the player’s name to the console.
