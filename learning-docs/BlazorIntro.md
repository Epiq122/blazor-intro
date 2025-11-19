# BlazorIntro Project Documentation

**Project Name:** BlazorIntro
**Created:** November 16, 2025
**Last Updated:** November 18, 2025
**Status:** 🟡 In Development

---

## 📋 Project Overview

**Purpose:** Learning project to understand Blazor WebAssembly fundamentals, component architecture, routing, state management, and JavaScript interop.

**Learning Objectives:**

- ✅ Master Blazor component creation and lifecycle
- ✅ Understand client-side routing
- ✅ Practice CSS scoping and styling
- ✅ Build interactive UI components
- ✅ Learn JavaScript interop for browser APIs
- ✅ Implement form validation with data annotations
- ✅ Master parent-child component communication
- ✅ Understand state persistence with localStorage

---

## ✨ Features

### Current Features

- ✅ **Home Page** - Landing page with welcome message
- ✅ **Counter Component** - Interactive button with state management
- ✅ **String Reverser** - Text input with string manipulation logic
- ✅ **Weather Display** - Mock weather data from JSON
- ✅ **Tasker App** ⭐ NEW - Full-featured task manager with:
  - Add/Delete/Complete tasks
  - Form validation (required field)
  - localStorage persistence (survives page refresh)
  - Checkbox for task completion with visual feedback
  - Auto-focus on input field
  - Responsive Bootstrap layout
  - Parent-child component architecture (Tasker + TaskerLine)
- ✅ **Navigation Menu** - Responsive sidebar navigation
- ✅ **Scoped CSS** - Component-specific styling

### Planned Features

- ⬜ Migrate Tasker to use database instead of localStorage
- ⬜ User authentication (multi-user support for Tasker)
- ⬜ Web API backend for Tasker
- ⬜ Advanced form validation (due dates, priority levels)
- ⬜ Task categories and filtering
- ⬜ Loading states and error handling for API calls

### Future Enhancements

- ⬜ Dark mode toggle
- ⬜ Task search functionality
- ⬜ Task statistics dashboard
- ⬜ Export tasks to CSV
- ⬜ Unit tests for components
- ⬜ Advanced animations

---

## 🛠️ Tech Stack

### Frontend

- **Framework:** Blazor WebAssembly
- **Language:** C# (.NET 8.0)
- **Styling:** CSS, Bootstrap 5, Bootstrap Icons
- **State Management:** Component state + localStorage (via JS Interop)

### Backend

- **Not yet implemented**
- _Planned: ASP.NET Core Web API_

### Database

- **Not yet implemented**
- _Current: localStorage (client-side only)_
- _Planned: SQL Server with EF Core_

### DevOps

- **Version Control:** Git
- **IDE:** JetBrains Rider
- _Planned: Docker, GitHub Actions_

---

## 🗄️ Database Structure

### Current State

Using localStorage (browser-based, client-side only). Data stored as JSON string with key "taskerItems".

**localStorage Schema:**
```json
{
  "key": "taskerItems",
  "value": "[{\"Id\":\"guid\",\"Name\":\"string\",\"IsComplete\":bool}]"
}
```

### Planned Database Schema

#### TaskerItems Table (Future)

| Column     | Type          | Constraints                  |
| ---------- | ------------- | ---------------------------- |
| Id         | uniqueidentifier | PK                        |
| Name       | nvarchar(200) | Not Null                     |
| IsComplete | bit           | Not Null, Default(0)         |
| UserId     | int           | FK to Users (future)         |
| CreatedAt  | datetime2     | Not Null, Default(GETDATE()) |
| DueDate    | datetime2     | Nullable (future)            |
| Priority   | int           | Nullable (future)            |

#### Users Table (Future)

| Column       | Type          | Constraints                  |
| ------------ | ------------- | ---------------------------- |
| Id           | int           | PK, Identity                 |
| Username     | nvarchar(50)  | Unique, Not Null             |
| Email        | nvarchar(100) | Unique, Not Null             |
| PasswordHash | nvarchar(255) | Not Null                     |
| CreatedAt    | datetime2     | Not Null, Default(GETDATE()) |

---

## 📸 Screenshots

### Tasker Component

_[Screenshot placeholder - Task list with add/delete/complete functionality]_

### Home Page

_[Screenshot placeholder - Add when UI is finalized]_

### Counter Component

_[Screenshot placeholder]_

### String Reverser

_[Screenshot placeholder]_

### Weather Display

_[Screenshot placeholder]_

---

## 🏗️ Project Structure

```
BlazorIntro/
├── Components/
│   ├── Pages/          # Routable components
│   │   ├── Home.razor
│   │   ├── Counter.razor
│   │   ├── ReverseAString.razor
│   │   ├── Weather.razor
│   │   └── Tasker.razor ⭐ NEW
│   ├── Layout/         # Layout components
│   │   ├── MainLayout.razor
│   │   └── NavMenu.razor
│   ├── UI/             # Reusable UI components
│   │   ├── Message.razor
│   │   └── TaskerLine.razor ⭐ NEW (child component)
│   ├── App.razor       # Root component
│   └── _Imports.razor  # Global using statements
├── Models/             # Data models
│   └── TaskerItem.cs   ⭐ NEW (with validation)
├── wwwroot/            # Static assets
│   ├── index.html
│   ├── css/
│   ├── img/            # Task images
│   └── sample-data/
├── Program.cs          # Application entry point
└── BlazorIntro.csproj  # Project file
```

---

## 🚀 Deployment

### Local Development

1. Clone repository
2. Navigate to project directory
3. Run `dotnet restore`
4. Run `dotnet run`
5. Open browser to displayed URL (typically https://localhost:5001)

### Production Deployment

- **Not yet deployed**
- _Planned hosting: Azure Static Web Apps / Netlify_

### Deployment Checklist

- ⬜ Configure production connection strings
- ⬜ Enable HTTPS
- ⬜ Set up environment variables
- ⬜ Configure CORS policies
- ⬜ Optimize bundle size
- ⬜ Set up CDN for static assets
- ⬜ Configure logging and monitoring

---

## 🔧 Configuration

### Development Settings

- **Target Framework:** net8.0
- **Nullable:** Enable
- **Implicit Usings:** Enable

### Environment Variables

_None configured yet_

---

## 📝 Implementation Notes

### Recent Changes (Nov 18, 2025)

- ✅ Built complete Tasker component with localStorage persistence
- ✅ Implemented TaskerItem model with data validation ([Required])
- ✅ Created reusable TaskerLine child component
- ✅ Added JavaScript interop for localStorage (save/load)
- ✅ Implemented component lifecycle (OnInitializedAsync, OnAfterRenderAsync)
- ✅ Added form validation with EditForm and DataAnnotationsValidator
- ✅ Implemented EventCallback pattern for parent-child communication
- ✅ Applied conditional CSS classes for completed tasks
- ✅ Added auto-focus on task input field using component reference
- ✅ Created scoped CSS for Tasker and TaskerLine components

### Technical Decisions Made

**Why localStorage instead of database initially?**
- Learning JavaScript interop basics
- No backend setup required yet
- Quick prototyping and testing
- Foundation for understanding state persistence
- Will migrate to database in next iteration

**Why EventCallback instead of Action delegates?**
- Blazor-specific, optimized for component rendering
- Supports async operations natively
- Type-safe with IntelliSense support
- Better performance for UI updates

**Why separate TaskerLine component?**
- Separation of concerns (Tasker handles data, TaskerLine handles display)
- Reusability and modularity
- Easier testing and maintenance
- Practice component composition pattern

### Known Issues

- No multi-user support (localStorage is per-browser)
- Data not synced across devices/browsers
- No error handling for localStorage quota exceeded
- Task list doesn't show empty state message
- No confirmation dialog before deleting tasks
- No undo functionality

### Technical Debt

- Need to migrate from localStorage to database
- Should add loading indicators for async operations
- Missing unit tests for Tasker logic
- No error boundaries for graceful failure handling
- Hard-coded styling should use CSS variables
- Need to extract localStorage logic into a service

---

## 🎯 Improvement List

### High Priority

1. **Backend Integration** ⚠️ NEXT STEP

   - Create ASP.NET Core Web API project
   - Implement EF Core with SQL Server
   - Create TaskerItem entity and DbContext
   - Build RESTful API endpoints (GET, POST, PUT, DELETE)

2. **Refactor Tasker to use API**

   - Replace localStorage calls with HttpClient API calls
   - Add loading states during API operations
   - Implement proper error handling
   - Show user-friendly error messages

3. **Authentication**
   - Implement ASP.NET Core Identity
   - Add login/register pages
   - Associate tasks with specific users
   - Secure API endpoints with JWT

### Medium Priority

4. Enhance TaskerItem model (due dates, priority, categories)
5. Add task filtering and search
6. Implement task editing (inline edit)
7. Add confirmation dialogs for destructive actions
8. Empty state UI when no tasks exist
9. Toast notifications for actions (task added, deleted, etc.)

### Low Priority

10. Unit tests for components and services
11. Dark mode support
12. Task drag-and-drop reordering
13. Task statistics and analytics
14. Performance optimization
15. Accessibility improvements (ARIA labels)

---

## 🧪 Testing

### Unit Tests

- **Not yet implemented**
- _Planned: xUnit, bUnit for Blazor components_
- _Target: Test TaskerItem validation, component logic_

### Integration Tests

- **Not yet implemented**
- _Planned: Test API endpoints when created_

### Manual Testing Completed

- ✅ Add task with valid name
- ✅ Add task with empty name (validation works)
- ✅ Delete task
- ✅ Mark task as complete/incomplete
- ✅ Page refresh (persistence verified)
- ✅ Browser localStorage cleared and data reloads
- ✅ Input auto-focus on page load
- ✅ Responsive layout on mobile

### Test Coverage

- Current: 0% (no automated tests)
- Target: 80%+ for business logic

---

## 👥 Contributors

- Rob (Solo Learning Project)

---

## 📚 Learning Resources Used

- [Microsoft Blazor Documentation](https://learn.microsoft.com/aspnet/core/blazor/)
- [JavaScript Interop Guide](https://learn.microsoft.com/aspnet/core/blazor/javascript-interoperability/)
- [Blazor Component Lifecycle](https://learn.microsoft.com/aspnet/core/blazor/components/lifecycle)
- [Data Annotations Reference](https://learn.microsoft.com/dotnet/api/system.componentmodel.dataannotations)

---

## 🎓 Key Learnings from This Project

### JavaScript Interop
- Learned to call browser APIs from C# code
- Understanding async JS calls with IJSRuntime
- Working with localStorage for client-side persistence

### Component Lifecycle
- OnInitializedAsync for data loading
- OnAfterRenderAsync for JS interop timing
- firstRender parameter usage

### Form Validation
- EditForm component usage
- Data annotations ([Required], custom error messages)
- ValidationMessage for user feedback

### Component Communication
- [Parameter] for parent-to-child data flow
- EventCallback<T> for child-to-parent events
- [EditorRequired] for mandatory parameters

### State Management
- Managing component state with private fields
- Persisting state beyond component lifecycle
- Handling async save/load operations

---

## 🔗 Related Projects

_Will be linked as portfolio grows_
- Next: Task Manager Pro (database-backed version with authentication)

---

## 📄 License

Educational/Personal Project

---

_This document is automatically updated as the project progresses._
