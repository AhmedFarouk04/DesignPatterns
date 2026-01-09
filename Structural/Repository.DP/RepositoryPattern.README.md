## Repository Pattern

### Purpose
Separate business logic from data access logic.

### Wrong Usage (Anti-Pattern)
- Returning IQueryable
- Wrapping EF Core without adding value
- Leaking ORM details

### Correct Usage
- Repository returns business-focused results
- Queries encapsulated inside repository
- Services remain clean

### Rule of Thumb
If your repository returns IQueryable,
you probably don’t need a repository.
