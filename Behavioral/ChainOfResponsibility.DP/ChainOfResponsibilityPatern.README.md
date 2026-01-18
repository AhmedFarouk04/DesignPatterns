# Chain of Responsibility

## Idea
Pass a request through a chain of handlers,
where each handler can process or forward it.

## Problem
Centralized conditional logic becomes hard to maintain.

## Solution
Split logic into independent handlers connected in a chain.

## Real Usage
ASP.NET Core Middleware pipeline.
