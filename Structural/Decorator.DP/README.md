# Decorator Design Pattern

##  Category
Structural Design Pattern

---

##  Overview
The **Decorator Pattern** lets you add new behavior to an object **dynamically**
by wrapping it with one or more decorator objects.  
It provides a flexible alternative to subclassing for extending functionality.

---

##  Problem
When an object can have multiple optional features (add-ons), using inheritance often leads to:
- Too many subclasses (class explosion)
- Tight coupling between features and the base class
- Difficulty combining features in different orders

Example idea:
A beverage can have add-ons like milk, mocha, caramel, etc.
Creating a class for every combination becomes unmanageable.

---

##  Solution
Decorator solves this by:
- Defining a common abstraction (interface or base type)
- Keeping a “core” component that provides the base behavior
- Creating decorators that implement the same abstraction and **wrap** another component
- Allowing stacking multiple decorators at runtime

---

##  Key Concepts
- **Component**: The base contract (what all objects must support)
- **Concrete Component**: The core object before add-ons
- **Decorator Base**: Holds a reference to a Component and forwards calls
- **Concrete Decorators**: Add extra behavior before/after forwarding

---

## Benefits
- Adds features **at runtime**
- Avoids subclass explosion
- Supports **Open/Closed Principle**
- Encourages composition over inheritance

---

## Considerations
- More small objects are created (stack of wrappers)
- Debugging can be slightly harder if naming/structure is unclear
- Overuse may make object graphs complex

---

##  When to Use Decorator
Use Decorator when:
- You need optional features that can be combined in many ways
- You want to extend behavior without modifying existing code
- You want runtime composition of responsibilities

Avoid Decorator when:
- You only have 1–2 fixed variants (simple inheritance may be enough)
- The feature set is not expected to grow
- Performance constraints make many wrappers undesirable

---

## Conclusion
Decorator provides a clean, scalable way to extend behavior using composition.
It is widely used in .NET and fits naturally with clean architecture principles.

---
