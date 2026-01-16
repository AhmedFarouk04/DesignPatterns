# Observer Pattern (Domain Events)

## Idea
The Observer Pattern allows multiple handlers to react to an event
without the publisher knowing about them.

---

## Problem
Directly calling services after an action causes tight coupling
and makes the system hard to extend.

---

## Solution
Domain Events are raised when something important happens,
and observers subscribe to handle these events independently.

---

## Notes
- One event can have multiple handlers
- Publisher is unaware of subscribers
- Commonly implemented using MediatR notifications
