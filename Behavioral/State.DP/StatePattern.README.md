# State Pattern

## Idea
Change object behavior based on its state
without using conditional logic.

## Problem
Flags and if/switch lead to complex and fragile code.

## Solution
Encapsulate each state into its own class
and delegate behavior to the current state.

## When to Use
- Stateful workflows
- Order lifecycles
- Replace flags
