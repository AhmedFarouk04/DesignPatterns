# Command Pattern

## Category
Behavioral Design Pattern

---

## Overview
The Command Pattern encapsulates a request as an object,
allowing separation between request definition and execution.

---

## Problem
Service classes often become bloated with multiple operations,
making them hard to maintain and test.

---

## Solution
Command Pattern introduces:
- Command objects representing actions
- Handlers responsible for execution
- A dispatcher (mediator) to route commands

---

## Benefits
- Clean separation of concerns
- Extensible and testable design
- Foundation for CQRS
- Decouples sender from receiver

---

## CQRS Relation
Commands represent the write side of CQRS,
while queries are handled separately.

---

## When to Use
- Complex workflows
- CQRS architectures
- Task-based systems
- Asynchronous or queued operations

---

## Conclusion
Command Pattern enables clean, scalable, and maintainable
command-driven architectures in .NET applications.
