# Weekly Progress Report

**Week of:** November 10-18, 2025
**Status:** Complete

---

## 📖 What I Learned This Week

### C# Concepts

- **Data Annotations**: Used [Required] attribute for form validation
- **Guid Generation**: Creating unique IDs with Guid.NewGuid()
- **Nullable Reference Types**: Proper use of ? for optional parameters
- **JSON Serialization**: System.Text.Json for converting objects to/from JSON strings
- **Exception Handling**: Try-catch blocks for localStorage operations

### Blazor Features

- **JavaScript Interop**: Invoking browser localStorage via IJSRuntime
- **Component Lifecycle**: OnInitializedAsync for data loading, OnAfterRenderAsync for JS interop
- **Form Validation**: EditForm with DataAnnotationsValidator and ValidationMessage
- **Component Parameters**: [Parameter] and [EditorRequired] attributes
- **EventCallback**: Child-to-parent communication pattern
- **Two-Way Binding**: @bind-Value with InputText and InputCheckbox
- **Component References**: @ref for accessing component instances
- **Conditional CSS Classes**: Using @() for dynamic class application

### Backend & Architecture

- **Data Models**: Created TaskerItem model with validation attributes
- **Component Architecture**: Separation of concerns (Tasker page + TaskerLine UI component)
- **State Persistence**: localStorage for client-side data persistence

### Tools & DevOps

- **Bootstrap Icons**: Integrated bi-trash-fill icon for delete action
- **Browser DevTools**: Testing localStorage in browser console

---

## 🚀 What I Built

### Projects

1. **BlazorIntro - Tasker Component** ⭐ Major Addition
   - Full-featured task management app with localStorage persistence
   - Features: Add, Delete, Complete tasks with data persistence
   - Tech: Blazor WASM, Bootstrap, localStorage, Form Validation
   - Status: Functional and deployed locally

### Features Implemented

- ✅ **Task CRUD Operations**: Add new tasks, delete tasks, mark complete
- ✅ **Form Validation**: Required field validation with user-friendly error messages
- ✅ **Data Persistence**: localStorage integration - tasks persist across browser sessions
- ✅ **Component Communication**: Parent-child pattern with EventCallbacks
- ✅ **Auto-Focus**: Input field focuses automatically on page load
- ✅ **Responsive UI**: Bootstrap flexbox layout, mobile-friendly
- ✅ **Visual Feedback**: Strikethrough text for completed tasks, trash icon for delete
- ✅ **Error Handling**: Graceful fallback if localStorage fails

---

## ❌ Mistakes Made & Lessons Learned

### Mistakes

1. **Async void in event handlers**: Used async void for AddTask and DeleteTask initially
2. **Forgot firstRender check**: OnAfterRender was being called repeatedly
3. **Missing null checks**: Didn't handle null TaskerItem in component parameters properly
4. **Not awaiting SaveListAsync**: Caused race conditions and data loss

### What I Learned From Them

1. **Async void is dangerous**: Changed to async Task and properly awaited calls. Only use async void for event handlers when absolutely necessary.
2. **Lifecycle optimization**: Always check firstRender parameter in OnAfterRenderAsync to avoid repeated execution
3. **Null safety**: Using nullable types (?) and [EditorRequired] prevents null reference exceptions
4. **Await all async calls**: Never fire-and-forget async operations when data integrity matters

---

## 🤔 Concepts I Struggled With

### Challenges

1. **JavaScript Interop timing**: Couldn't call JS in OnInitializedAsync
2. **Component re-rendering**: List updates not always triggering UI refresh
3. **EventCallback pattern**: Understanding the parent-child communication flow
4. **JSON serialization quirks**: Handling empty/null data from localStorage

### Resolution Approach

1. **Lifecycle understanding**: Learned OnAfterRenderAsync is correct place for JS interop
2. **StateHasChanged**: Though not needed in this case, learned when to use it
3. **EventCallback practice**: Built TaskerLine component to master the pattern
4. **Defensive programming**: Added try-catch and default values ("[]") for localStorage loads

---

## 💪 What I Feel Confident About

- Blazor component structure and @code blocks
- Routing and navigation in Blazor
- Creating and styling components with scoped CSS
- **JavaScript Interop for localStorage** ✨ New
- **Form validation with data annotations** ✨ New
- **Component lifecycle methods** ✨ New
- **Parent-child component communication** ✨ New
- **State management with persistence** ✨ New

---

## 🎯 Recommended Focus Areas for Next Week

### Priority 1: Backend Fundamentals ⚠️ CRITICAL

- [ ] **Entity Framework Core**: Learn Code-First migrations and DbContext setup
- [ ] **Database Integration**: Replace localStorage with SQL Server/PostgreSQL
- [ ] **Data Models**: Create proper entity classes with relationships
- [ ] **Connection Strings**: Learn configuration management

### Priority 2: Web API Development ⚠️ CRITICAL

- [ ] Create separate ASP.NET Core Web API project
- [ ] Build RESTful endpoints for Tasker (GET, POST, PUT, DELETE)
- [ ] Learn proper API controller structure
- [ ] Test APIs with Postman/Swagger

### Priority 3: Refactor Tasker with Backend

- [ ] Migrate Tasker from localStorage to database
- [ ] Implement HttpClient in Blazor to call API
- [ ] Add loading states during API calls
- [ ] Implement proper error handling

### Don't Skip These Important Topics

⚠️ **EF Core** - You're ready for this now; localStorage knowledge transfers to database concepts
⚠️ **RESTful APIs** - Essential for any real-world application  
⚠️ **Async Data Fetching** - Build on your async/await understanding from this week
⚠️ **Dependency Injection** - Time to learn proper service patterns

---

## 📊 Time Breakdown

| Category                  | Hours  | Percentage |
| ------------------------- | ------ | ---------- |
| Learning/Tutorials        | 4h     | 30%        |
| Building Projects         | 7h     | 50%        |
| Debugging/Problem Solving | 2h     | 15%        |
| Documentation/Notes       | 0.5h   | 5%         |
| **Total**                 | **13.5h** | **100%**   |

---

## 🎓 Course Progress

**Current Course:** Blazor WebAssembly Fundamentals
**Section Completed:** Component Lifecycle & Forms
**Next Milestone:** Backend Integration with EF Core & Web APIs

---

## 📝 Notes & Reflections

### Personal Insights

- JavaScript interop is easier than expected - just async calls to browser APIs
- Component lifecycle makes more sense now after hands-on implementation
- Building a real feature (Tasker) solidified concepts better than isolated examples
- Data persistence feels satisfying but localStorage has limitations (client-side only, no multi-user support)

### Questions to Explore

- How to migrate from localStorage to database without breaking existing code?
- What's the difference between Blazor WASM and Blazor Server for data access?
- How to implement user authentication so each user has their own tasks?
- Best practices for organizing larger Blazor projects (folder structure)?

### Resources Found

- [Microsoft Docs - JavaScript Interop](https://learn.microsoft.com/aspnet/core/blazor/javascript-interoperability/)
- [Blazor Component Lifecycle](https://learn.microsoft.com/aspnet/core/blazor/components/lifecycle)
- [Data Annotations Reference](https://learn.microsoft.com/dotnet/api/system.componentmodel.dataannotations)

---

## 🎯 Goals for Next Week (Nov 18-24, 2025)

1. **Technical Goals**

   - Complete Entity Framework Core tutorial
   - Set up SQL Server LocalDB or PostgreSQL
   - Create first database migration
   - Build simple Web API with CRUD endpoints

2. **Project Goals**

   - Start "Task Manager Pro" portfolio project (database-backed version of Tasker)
   - Create data models with proper relationships
   - Set up API project structure

3. **Learning Goals**
   - Understand DbContext and DbSet concepts
   - Learn LINQ queries for database operations
   - Master API controller patterns
   - Study repository pattern basics

---

_Generated: November 18, 2025_
_Next Report Due: November 24, 2025_
