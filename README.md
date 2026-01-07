## Dependency Injection (DI)

### Problem
Services create their own dependencies, causing tight coupling
and making the code hard to test or extend.

### Wrong
The service depends directly on a concrete implementation
(SqlOrderRepository).

### Solution
Apply Dependency Inversion Principle and inject dependencies
through the constructor.

### Key Notes
- DI is NOT a GoF Design Pattern
- DI is a technique to apply DIP
- Avoid `new` inside services

### When to Use
- Always in backend services
- Required for Clean Architecture


### Manual DI vs Container DI

Manual DI is useful for learning and small examples.
DI Containers are used in real applications to manage
object lifetimes and complex dependency graphs.

ASP.NET Core provides a built-in DI container.
