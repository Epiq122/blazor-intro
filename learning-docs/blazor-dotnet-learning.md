# Blazor / .NET Learning Knowledge Base

Purpose

- Central, clean notes for C#, Blazor, ASP.NET Core, EF Core, Identity, Web APIs, and backend architecture.
- Append new sections as you learn. Use short examples only when necessary.

Conventions

- Keep sections small, scannable, and dated (YYYY-MM-DD).
- Prefer bullets over paragraphs. Add 1–2 best practices and pitfalls.
- Use fenced code blocks only when the concept needs a tiny sample.

Index

- C# Fundamentals
- Blazor UI
- Components
- Routing
- Forms
- Data Binding
- EF Core
- Migrations
- Identity / AuthN / AuthZ
- Web API Development
- Deployment & Docker
- Databases & Data Modeling
- Architecture & Patterns

Template

## [Topic] — YYYY-MM-DD

Definitions

- ...

Key Points

- ...

Best Practices

- ...

Gotchas

- ...

Example

```csharp
// minimal example, only if needed
```

---

Getting Started Sections

## C# Fundamentals — Seed

Definitions

- Value vs reference types, stack vs heap, nullable types, generics, LINQ basics.

Key Points

- Immutability where possible; minimize side effects.
- Async/await: avoid async void except event handlers.

Best Practices

- Favor IEnumerable/IReadOnlyList for APIs.
- Use var for clarity, not novelty.

Gotchas

- Struct default(T) equals zeroed memory; be careful with nullables.

## Blazor UI — Seed

Definitions

- Component model, render tree, event binding.

Key Points

- Parameters are one-way; use EventCallback for two-way.
- Prefer small, composable components.

Best Practices

- Use CascadingParameter sparingly; prefer explicit props.

Gotchas

- Excessive re-rendering from large state objects.

## EF Core — Seed

Definitions

- DbContext, DbSet, change tracker, migrations, relationships.

Key Points

- Explicit vs lazy loading; query projections.

Best Practices

- No business logic in DbContext; keep it thin.

Gotchas

- N+1 queries; client vs server evaluation.
