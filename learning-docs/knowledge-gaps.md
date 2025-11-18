# Knowledge Gaps & Practice Tasks

**Last Updated:** November 16, 2025
**Purpose:** Track concepts that need reinforcement and provide specific practice tasks for each gap

---

## 🎯 How to Use This Document

After completing each module or section:

1. Identify concepts you missed, misunderstood, or need reinforcement
2. Add them to the appropriate category below
3. Complete the suggested practice tasks
4. Mark gaps as "Reinforced" when confident
5. Review this document weekly

---

## 📊 Gap Summary

| Category                | Open Gaps | Reinforced | Total |
| ----------------------- | --------- | ---------- | ----- |
| C# Fundamentals         | 0         | 0          | 0     |
| Blazor                  | 0         | 0          | 0     |
| Entity Framework Core   | 0         | 0          | 0     |
| Web APIs                | 0         | 0          | 0     |
| Authentication/Security | 0         | 0          | 0     |
| Testing                 | 0         | 0          | 0     |
| DevOps/Deployment       | 0         | 0          | 0     |
| **Total**               | **0**     | **0**      | **0** |

---

## 🔴 C# Fundamentals Gaps

### ❌ Gap: [Topic Name]

**Status:** 🔴 Open | **Discovered:** [Date] | **Module:** [Module Name]

**What I Missed:**

- [Describe what you didn't understand or got wrong]

**Why It Matters:**

- [Explain the importance or real-world usage]

**Practice Tasks:**

1. [ ] [Specific task 1]
2. [ ] [Specific task 2]
3. [ ] [Specific task 3]

**Resources:**

- [Link to documentation]
- [Tutorial/video reference]

**Status:** 🔴 Not Reinforced | ✅ Reinforced on [Date]

---

## 🟦 Blazor Gaps

### ❌ Gap: [Topic Name]

**Status:** 🔴 Open | **Discovered:** [Date] | **Module:** [Module Name]

**What I Missed:**

- [Description]

**Why It Matters:**

- [Importance]

**Practice Tasks:**

1. [ ] [Task 1]
2. [ ] [Task 2]
3. [ ] [Task 3]

**Resources:**

- [Resources]

**Status:** 🔴 Not Reinforced | ✅ Reinforced on [Date]

---

## 🟢 Entity Framework Core Gaps

### ❌ Gap: [Topic Name]

**Status:** 🔴 Open | **Discovered:** [Date] | **Module:** [Module Name]

**What I Missed:**

- [Description]

**Why It Matters:**

- [Importance]

**Practice Tasks:**

1. [ ] [Task 1]
2. [ ] [Task 2]
3. [ ] [Task 3]

**Resources:**

- [Resources]

**Status:** 🔴 Not Reinforced | ✅ Reinforced on [Date]

---

## 🟣 Web API Gaps

### ❌ Gap: [Topic Name]

**Status:** 🔴 Open | **Discovered:** [Date] | **Module:** [Module Name]

**What I Missed:**

- [Description]

**Why It Matters:**

- [Importance]

**Practice Tasks:**

1. [ ] [Task 1]
2. [ ] [Task 2]
3. [ ] [Task 3]

**Resources:**

- [Resources]

**Status:** 🔴 Not Reinforced | ✅ Reinforced on [Date]

---

## 🟠 Authentication & Security Gaps

### ❌ Gap: [Topic Name]

**Status:** 🔴 Open | **Discovered:** [Date] | **Module:** [Module Name]

**What I Missed:**

- [Description]

**Why It Matters:**

- [Importance]

**Practice Tasks:**

1. [ ] [Task 1]
2. [ ] [Task 2]
3. [ ] [Task 3]

**Resources:**

- [Resources]

**Status:** 🔴 Not Reinforced | ✅ Reinforced on [Date]

---

## 🔵 Testing Gaps

### ❌ Gap: [Topic Name]

**Status:** 🔴 Open | **Discovered:** [Date] | **Module:** [Module Name]

**What I Missed:**

- [Description]

**Why It Matters:**

- [Importance]

**Practice Tasks:**

1. [ ] [Task 1]
2. [ ] [Task 2]
3. [ ] [Task 3]

**Resources:**

- [Resources]

**Status:** 🔴 Not Reinforced | ✅ Reinforced on [Date]

---

## 🟤 DevOps & Deployment Gaps

### ❌ Gap: [Topic Name]

**Status:** 🔴 Open | **Discovered:** [Date] | **Module:** [Module Name]

**What I Missed:**

- [Description]

**Why It Matters:**

- [Importance]

**Practice Tasks:**

1. [ ] [Task 1]
2. [ ] [Task 2]
3. [ ] [Task 3]

**Resources:**

- [Resources]

**Status:** 🔴 Not Reinforced | ✅ Reinforced on [Date]

---

## 🎓 Common Practice Task Templates

### For Syntax/Concepts

1. Write code from scratch without reference
2. Explain concept to someone (rubber duck method)
3. Find 3 real-world examples in open-source projects
4. Create cheat sheet with key points

### For Patterns/Architecture

1. Implement pattern in small demo project
2. Refactor existing code to use pattern
3. Compare with alternative approaches
4. Document when to use and when not to use

### For Tools/Frameworks

1. Build "hello world" example
2. Complete official getting-started tutorial
3. Build small CRUD app using tool
4. Read documentation cover-to-cover

---

## 📝 Examples of Well-Defined Gaps & Tasks

### Example 1: LINQ Gaps

#### ❌ Gap: Complex LINQ Queries with Multiple Joins

**Status:** 🔴 Open | **Discovered:** Nov 16, 2025 | **Module:** Entity Framework Basics

**What I Missed:**

- How to join multiple tables using LINQ method syntax
- Understanding when to use `Include()` vs explicit joins
- Performance implications of different query approaches

**Why It Matters:**

- LINQ is essential for querying databases in EF Core
- Efficient queries improve application performance
- Common interview topic for .NET positions

**Practice Tasks:**

1. [ ] Write 10 LINQ queries joining 2+ tables using both query and method syntax
2. [ ] Refactor existing foreach loops in a project to use LINQ
3. [ ] Compare SQL generated by different LINQ approaches using SQL Profiler
4. [ ] Complete LINQPad exercises for joins and grouping

**Resources:**

- [Microsoft LINQ Documentation](https://learn.microsoft.com/dotnet/csharp/linq/)
- [LINQPad](https://www.linqpad.net/) - Interactive LINQ learning tool
- [101 LINQ Samples](https://learn.microsoft.com/samples/dotnet/try-samples/101-linq-samples/)

**Status:** 🔴 Not Reinforced

---

### Example 2: Async/Await Gaps

#### ❌ Gap: Proper Async/Await Usage in Blazor

**Status:** 🔴 Open | **Discovered:** Nov 16, 2025 | **Module:** Blazor Component Lifecycle

**What I Missed:**

- Difference between `OnInitialized()` and `OnInitializedAsync()`
- When to use `Task.Run()` vs direct async methods
- Avoiding deadlocks with `.ConfigureAwait(false)`
- Proper error handling with async methods

**Why It Matters:**

- Blazor heavily relies on async operations for data fetching
- Improper async usage can freeze UI or cause errors
- Understanding async is critical for responsive applications

**Practice Tasks:**

1. [ ] Convert 5 synchronous methods to async in current project
2. [ ] Create demo showing proper async lifecycle in Blazor components
3. [ ] Implement proper loading states during async operations
4. [ ] Read "Async/Await Best Practices" article by Stephen Cleary
5. [ ] Handle exceptions properly in async component methods

**Resources:**

- [Async/Await Best Practices](https://docs.microsoft.com/archive/msdn-magazine/2013/march/async-await-best-practices-in-asynchronous-programming)
- [Blazor Component Lifecycle](https://learn.microsoft.com/aspnet/core/blazor/components/lifecycle)

**Status:** 🔴 Not Reinforced

---

### Example 3: Dependency Injection Gaps

#### ❌ Gap: Service Lifetimes (Transient vs Scoped vs Singleton)

**Status:** 🔴 Open | **Discovered:** Nov 16, 2025 | **Module:** ASP.NET Core Fundamentals

**What I Missed:**

- When to use each service lifetime
- Impact on memory and performance
- Risks of injecting scoped service into singleton
- How Blazor Server handles scoped services differently

**Why It Matters:**

- Incorrect lifetime can cause memory leaks or unexpected behavior
- Essential pattern in .NET development
- Common source of bugs for beginners

**Practice Tasks:**

1. [ ] Create demo project with all three lifetime types
2. [ ] Intentionally create a scoped-in-singleton bug and fix it
3. [ ] Write documentation explaining each lifetime with examples
4. [ ] Refactor existing services in BlazorIntro with proper lifetimes
5. [ ] Research how Blazor WASM handles service lifetimes differently than Server

**Resources:**

- [Dependency Injection in .NET](https://learn.microsoft.com/dotnet/core/extensions/dependency-injection)
- [Service Lifetimes Explained](https://learn.microsoft.com/aspnet/core/fundamentals/dependency-injection#service-lifetimes)

**Status:** 🔴 Not Reinforced

---

## 🏆 Reinforced Gaps (Archive)

Track previously identified gaps that have been successfully reinforced.

### ✅ Gap: [Topic] - Reinforced on [Date]

**Original Issue:** [Brief description]
**How Reinforced:** [What you did to master it]
**Confidence Level:** ⭐⭐⭐⭐⭐ (5/5)

---

## 📅 Weekly Gap Review Schedule

**Every Sunday:**

1. Review this week's learning materials
2. Identify new gaps from modules completed
3. Add gaps with specific practice tasks
4. Schedule time to work on 2-3 gaps next week
5. Mark reinforced gaps and move to archive

**Monthly Deep Review:**

1. Review all reinforced gaps - are they truly mastered?
2. Identify patterns in gaps (e.g., always struggling with async)
3. Adjust learning approach based on gap patterns
4. Update practice task templates based on what works

---

## 🎯 Current Priority Gaps (Top 5)

Ranked by importance for job readiness:

1. **Gap:** [Not yet identified]

   - **Practice By:** [Date]

2. **Gap:** [Not yet identified]

   - **Practice By:** [Date]

3. **Gap:** [Not yet identified]

   - **Practice By:** [Date]

4. **Gap:** [Not yet identified]

   - **Practice By:** [Date]

5. **Gap:** [Not yet identified]
   - **Practice By:** [Date]

---

## 💡 Gap Detection Strategies

**How to Identify Gaps:**

- ❓ Concepts you needed to Google multiple times
- ❓ Topics you skipped in tutorials
- ❓ Questions you couldn't answer in practice problems
- ❓ Code patterns you copied without understanding
- ❓ Interview questions you couldn't answer
- ❓ Errors you fixed without understanding why
- ❓ Concepts peers/online discussions assume everyone knows

**Red Flags:**

- 🚩 "I'll learn this later" (Add to gaps immediately)
- 🚩 "I kind of understand" (Need reinforcement)
- 🚩 "It works, but I'm not sure why" (Major gap)
- 🚩 Copy-pasting code without modification (Understanding gap)

---

## 📊 Gap Analysis Dashboard

### This Month's Stats

- **Gaps Identified:** 0
- **Gaps Reinforced:** 0
- **Active Gaps:** 0
- **Success Rate:** N/A

### Most Common Gap Categories

1. [Category] - X gaps
2. [Category] - X gaps
3. [Category] - X gaps

### Average Time to Reinforce

- **C# Fundamentals:** N/A days
- **Blazor:** N/A days
- **Backend:** N/A days

---

_This document grows with your learning journey. Embrace gaps as learning opportunities, not failures._
