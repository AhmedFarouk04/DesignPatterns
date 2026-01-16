# Mediator Pattern (MediatR)

## Idea
The Mediator Pattern centralizes communication between components
by introducing a mediator that coordinates interactions.
Instead of components calling each other directly,
they communicate through a single mediator.

---

## Problem
Direct communication between services causes:
- Tight coupling
- Hard-to-maintain code
- Difficult testing
- Ripple effects when changes occur

---

## Solution
The Mediator Pattern introduces a mediator that:
- Receives requests (commands, events)
- Routes them to the correct handlers
- Decouples senders from receivers

In .NET, **MediatR** is a common implementation of this pattern.

---

## Required Packages
This project is a console application.
Install the following NuGet packages:

```bash
dotnet add package MediatR
dotnet add package MediatR.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.Extensions.DependencyInjection



Only one Program.cs with top-level statements is allowed.

The Wrong folder demonstrates direct service-to-service communication.

The Correct folder uses MediatR for decoupled communication.