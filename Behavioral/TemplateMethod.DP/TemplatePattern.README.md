# Template Method Pattern

## Idea
Defines a fixed algorithm structure while allowing subclasses
to customize specific steps.

## Problem
Duplicated workflows with small variations.

## Solution
Move the common flow to a base class
and let subclasses override specific steps.

## When to Use
- Fixed execution order
- Framework-level logic
- Shared workflows
