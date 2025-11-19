# Knowledge Gaps & Practice Tasks

**Last Updated:** November 18, 2025
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
| C# Fundamentals         | 2         | 0          | 2     |
| Blazor                  | 1         | 0          | 1     |
| Entity Framework Core   | 0         | 0          | 0     |
| Web APIs                | 0         | 0          | 0     |
| Authentication/Security | 0         | 0          | 0     |
| Testing                 | 0         | 0          | 0     |
| DevOps/Deployment       | 0         | 0          | 0     |
| **Total**               | **3**     | **0**      | **3** |

---

## 🔴 C# Fundamentals Gaps

### ❌ Gap: Async void vs async Task in Event Handlers

**Status:** 🔴 Open | **Discovered:** Nov 18, 2025 | **Module:** Tasker Component Development

**What I Missed:**

- Initially used `async void` for AddTask() and DeleteTask() methods
- Didn't understand when async void is acceptable vs when to use async Task
- Confusion about event handlers specifically (when async void is OK)
- Proper awaiting patterns for fire-and-forget vs critical operations

**Why It Matters:**

- async void cannot be awaited and swallows exceptions
- Can cause race conditions and data loss if not handled properly
- Critical for data persistence operations (like SaveListAsync)
- Common interview question for .NET positions

**Practice Tasks:**

1. [ ] Read Stephen Cleary's "Async/Await Best Practices" article thoroughly
2. [ ] Refactor all async methods in Tasker to use proper return types
3. [ ] Write demo project showing difference between async void and async Task
4. [ ] Create examples of proper exception handling in async methods
5. [ ] Practice converting synchronous methods to async equivalents

**Resources:**

- [Async/Await Best Practices by Stephen Cleary](https://docs.microsoft.com/archive/msdn-magazine/2013/march/async-await-best-practices-in-asynchronous-programming)
- [Microsoft Docs - Async Return Types](https://learn.microsoft.com/dotnet/csharp/programming-guide/concepts/async/async-return-types)

**Status:** 🔴 Not Reinforced

---

### ❌ Gap: LINQ Fundamentals for Database Queries

**Status:** 🔴 Open | **Discovered:** Nov 18, 2025 | **Module:** Preparing for EF Core

**What I Missed:**

- Haven't used LINQ extensively yet (only basic foreach loops)
- Don't know method syntax vs query syntax
- No experience with Where(), Select(), OrderBy(), GroupBy(), Join()
- Will be essential for EF Core database querying

**Why It Matters:**

- LINQ is the primary way to query databases with EF Core
- Required for 90%+ of .NET jobs in Vancouver
- More efficient than manual loops for filtering and transforming data
- Interview questions often test LINQ knowledge

**Practice Tasks:**

1. [ ] Complete "101 LINQ Samples" tutorial from Microsoft
2. [ ] Practice 20 LINQ exercises on LINQPad
3. [ ] Convert all foreach loops in Tasker to LINQ (where appropriate)
4. [ ] Write LINQ queries for: filtering, sorting, grouping, joining
5. [ ] Compare performance of LINQ vs manual loops

**Resources:**

- [101 LINQ Samples](https://learn.microsoft.com/samples/dotnet/try-samples/101-linq-samples/)
- [LINQPad](https://www.linqpad.net/) - Interactive LINQ learning tool
- [Microsoft LINQ Documentation](https://learn.microsoft.com/dotnet/csharp/linq/)

**Status:** 🔴 Not Reinforced

---

## 🟦 Blazor Gaps

### ❌ Gap: StateHasChanged() - When and Why to Use It

**Status:** 🔴 Open | **Discovered:** Nov 18, 2025 | **Module:** Tasker Component

**What I Missed:**

- Tasker works without calling StateHasChanged() explicitly
- Don't fully understand when Blazor auto-detects changes vs when manual call needed
- Confusion about re-rendering triggers in Blazor
- Might need it for more complex scenarios (background tasks, etc.)

**Why It Matters:**

- Critical for manual UI updates when Blazor doesn't auto-detect changes
- Required for background tasks, timers, external events
- Performance implications if overused
- Common issue in complex Blazor applications

**Practice Tasks:**

1. [ ] Read Blazor rendering documentation thoroughly
2. [ ] Create demo with background task requiring StateHasChanged()
3. [ ] Experiment with timer-based updates in component
4. [ ] Build component with external event subscription
5. [ ] Document scenarios where StateHasChanged() is needed

**Resources:**

- [Blazor Rendering](https://learn.microsoft.com/aspnet/core/blazor/components/rendering)
- [ASP.NET Core Blazor component lifecycle](https://learn.microsoft.com/aspnet/core/blazor/components/lifecycle)

**Status:** 🔴 Not Reinforced

---

## 🟢 Entity Framework Core Gaps

_No gaps identified yet - will populate after starting EF Core module this week_

---

## 🟣 Web API Gaps

_No gaps identified yet - will populate after API development_

---

## 🟠 Authentication & Security Gaps

_No gaps identified yet - will populate after Identity implementation_

---

## 🔵 Testing Gaps

_No gaps identified yet - will populate after testing module_

---

## 🟤 DevOps & Deployment Gaps

_No gaps identified yet - will populate after deployment_

---

## 🏆 Reinforced Gaps (Archive)

_Track previously identified gaps that have been successfully reinforced._

_None yet - will move gaps here as they are mastered_

---

## 📅 Weekly Gap Review Schedule

**Every Sunday:**

1. Review this week's learning materials
2. Identify new gaps from modules completed
3. Add gaps with specific practice tasks
4. Schedule time to work on 2-3 gaps next week
5. Mark reinforced gaps and move to archive

**Next Review:** November 24, 2025

**Monthly Deep Review:**

1. Review all reinforced gaps - are they truly mastered?
2. Identify patterns in gaps (e.g., always struggling with async)
3. Adjust learning approach based on gap patterns
4. Update practice task templates based on what works

---

## 🎯 Current Priority Gaps (Top 5)

Ranked by importance for job readiness:

1. **Gap:** LINQ Fundamentals for Database Queries

   - **Practice By:** December 1, 2025
   - **Priority:** Critical - needed for EF Core

2. **Gap:** Async void vs async Task in Event Handlers

   - **Practice By:** November 24, 2025
   - **Priority:** High - affects data integrity

3. **Gap:** StateHasChanged() Understanding

   - **Practice By:** December 8, 2025
   - **Priority:** Medium - good to know for complex scenarios

4. **Gap:** TBD (will add after EF Core module)

   - **Practice By:** TBD

5. **Gap:** TBD (will add after API development)
   - **Practice By:** TBD

---

## 💡 Gap Detection Strategies

**How to Identify Gaps:**

- ❓ Concepts you needed to Google multiple times ✅ (async void)
- ❓ Topics you skipped in tutorials
- ❓ Questions you couldn't answer in practice problems
- ❓ Code patterns you copied without understanding ✅ (lifecycle methods initially)
- ❓ Interview questions you couldn't answer
- ❓ Errors you fixed without understanding why ✅ (localStorage null handling)
- ❓ Concepts peers/online discussions assume everyone knows ✅ (LINQ, StateHasChanged)

**Red Flags:**

- 🚩 "I'll learn this later" → Add to gaps immediately
- 🚩 "I kind of understand" → Need reinforcement ✅ (StateHasChanged)
- 🚩 "It works, but I'm not sure why" → Major gap ✅ (async patterns)
- 🚩 Copy-pasting code without modification → Understanding gap

---

## 📊 Gap Analysis Dashboard

### This Week's Stats (Nov 18, 2025)

- **Gaps Identified:** 3
- **Gaps Reinforced:** 0
- **Active Gaps:** 3
- **Success Rate:** N/A (first week)

### Most Common Gap Categories

1. C# Fundamentals - 2 gaps
2. Blazor - 1 gap

### Average Time to Reinforce

- **C# Fundamentals:** TBD
- **Blazor:** TBD
- **Backend:** TBD

---

## 📝 Action Plan for This Week

**Focus:** Address LINQ gap before starting EF Core

**Monday-Tuesday:**

- Complete 101 LINQ Samples (at least 50%)
- Install LINQPad and practice queries

**Wednesday:**

- Finish LINQ samples
- Refactor Tasker to use LINQ where appropriate

**Thursday-Friday:**

- Start EF Core module
- Apply LINQ knowledge to database queries

**Weekend:**

- Practice async/await patterns
- Read Stephen Cleary's article
- Document learnings

---

_This document grows with your learning journey. Embrace gaps as learning opportunities, not failures._
