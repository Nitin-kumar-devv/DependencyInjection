Dependency Injection 

This repository demonstrates how to implement **Dependency Injection (DI)** in a clean, modular, and testable way using **C# and ASP.NET Core**.

What is Dependency Injection?

**Dependency Injection (DI)** is a design pattern used to achieve **Inversion of Control (IoC)** between classes and their dependencies. Instead of a class creating its own dependencies, they are **injected** from the outside.

Benefits

- Decouples components for better modularity
- Makes code easier to test (mock dependencies)
- Promotes reusability and maintainability
- Enables configuration at runtime

How .NET Handles DI

ASP.NET Core has built-in support for DI via the `IServiceCollection` and `IServiceProvider` interfaces.

csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddScoped<IMyService, MyService>();
}
