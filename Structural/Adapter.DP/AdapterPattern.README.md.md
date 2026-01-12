# Adapter Design Pattern

## Category
Structural Design Pattern

---

## Overview
The Adapter Pattern allows incompatible interfaces to work together.
It acts as a bridge between the application and external or legacy systems
without modifying existing code.

---

## Problem
In real-world applications, systems often need to integrate with:
- External APIs
- Legacy code
- Third-party SDKs

These components usually expose different interfaces and data structures.
Direct integration leads to:
- Tight coupling
- Conditional logic
- Violation of Open/Closed Principle

---

## Solution
The Adapter Pattern solves this by:
- Defining a target interface used by the application
- Creating adapter classes that translate calls to external systems
- Isolating third-party dependencies from core logic

---

## Structure
- **Target Interface**: `IPaymentGateway`
- **Adaptees**: `PaypalApi`, `StripeApi`
- **Adapters**: `PaypalAdapter`, `StripeAdapter`
- **Client**: Application code consuming the interface

---

## Benefits
- Decouples application from external systems
- Eliminates conditional logic
- Supports Open/Closed Principle
- Simplifies testing and maintenance
- Ideal place for DTO mapping

---

## When to Use Adapter
Use Adapter Pattern when:
- Integrating external APIs
- Working with legacy systems
- Interfaces are incompatible
- DTO mapping is required

Avoid Adapter when:
- You control both interfaces
- A simple refactor is sufficient

---

## Real-World Usage in .NET
- Payment gateways
- Logging providers
- External authentication services
- Third-party SDK integrations

---

## Conclusion
The Adapter Pattern provides a clean and maintainable way to integrate
external or legacy systems into modern .NET applications while preserving
clean architecture principles.
