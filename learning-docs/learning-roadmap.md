# Blazor/.NET Learning Roadmap

**Created:** November 16, 2025
**Last Updated:** November 18, 2025
**Course:** Blazor WebAssembly Fundamentals
**Target Completion:** February 15, 2026

---

## 📚 Course Progress Overview

**Overall Progress:** 🟢 25% Complete ⬆️ +10%

| Phase | Status | Progress | Completion Date |
|-------|--------|----------|-----------------|
| Phase 1: Fundamentals | 🟢 Mostly Complete | 75% ⬆️ | Nov 18, 2025 |
| Phase 2: Backend & Data | 🟡 Starting | 5% | - |
| Phase 3: Advanced Features | 🔴 Not Started | 0% | - |
| Phase 4: Real-World Projects | 🔴 Not Started | 0% | - |
| Phase 5: Deployment & Production | 🔴 Not Started | 0% | - |

---

## Phase 1: C# & Blazor Fundamentals

### 1.1 C# Basics
**Status:** 🟡 In Progress | **Progress:** 50% ⬆️

- 🟡 **Variables & Data Types** - In Progress
  - *Takeaway:* Understanding value types vs reference types; Guid for unique IDs

- 🟡 **Control Flow** - In Progress
  - *Takeaway:* if/else, switch, loops, foreach for collections

- 🟡 **Methods & Functions** - In Progress
  - *Takeaway:* async/await patterns for asynchronous operations

- 🔴 **OOP Fundamentals** - Not Started
  - Classes, Objects, Inheritance, Polymorphism
  - *Takeaway:* TBD

- 🟡 **Collections** - In Progress
  - *Takeaway:* List<T> for dynamic collections, Add/Remove operations

- 🟡 **Exception Handling** - In Progress
  - *Takeaway:* Try-catch for graceful error handling (localStorage failures)

### 1.2 Blazor Component Basics
**Status:** ✅ Completed | **Progress:** 90% ⬆️

- ✅ **Component Structure** - Completed
  - *Takeaway:* Components are the building blocks; @code block separates logic from markup

- ✅ **Routing** - Completed
  - *Takeaway:* @page directive makes components routable; can have multiple routes per component

- ✅ **Data Binding** - Completed
  - *Takeaway:* @bind-Value for two-way binding with form inputs, @ for one-way display; @bind-Value:after for post-change events

- ✅ **Event Handling** - Completed
  - *Takeaway:* @onclick, @onchange events connect UI to logic; can use async event handlers

- ✅ **Component Parameters** - Completed
  - *Takeaway:* [Parameter] for parent-to-child data, [EditorRequired] for mandatory params; use nullable types (?) for optional

- ✅ **Component Lifecycle** - Completed
  - *Takeaway:* OnInitializedAsync for data loading, OnAfterRenderAsync for JS interop; firstRender parameter prevents repeated execution

### 1.3 CSS & Styling
**Status:** ✅ Completed | **Progress:** 60% ⬆️

- ✅ **Scoped CSS** - Completed
  - *Takeaway:* Component-specific styles (.razor.css files) prevent global conflicts; styles apply only to that component

- ✅ **Bootstrap Integration** - Completed
  - *Takeaway:* Bootstrap classes for responsive layouts (d-flex, flex-row, gap-2); utility classes reduce custom CSS

- ✅ **Custom Styling** - Completed
  - *Takeaway:* Conditional classes with @(expression ? "class" : "") for dynamic styling; combine with scoped CSS

### 1.4 JavaScript Interop ⭐ NEW
**Status:** ✅ Completed | **Progress:** 70%

- ✅ **IJSRuntime Setup** - Completed
  - *Takeaway:* Inject with @inject IJSRuntime JS; available throughout component

- ✅ **Calling JS Functions** - Completed
  - *Takeaway:* InvokeVoidAsync for no return value, InvokeAsync<T> for returning data; all calls are async

- ✅ **localStorage API** - Completed
  - *Takeaway:* setItem(key, value) and getItem(key) for client-side persistence; data survives page refresh; 5-10MB limit

- ✅ **JSON Serialization** - Completed
  - *Takeaway:* System.Text.Json.JsonSerializer for converting objects to/from JSON strings; provide defaults for null

### 1.5 Forms & Validation ⭐ NEW
**Status:** ✅ Completed | **Progress:** 75%

- ✅ **EditForm Component** - Completed
  - *Takeaway:* Use EditForm instead of HTML <form> for Blazor validation; Model property binds to data object

- ✅ **DataAnnotationsValidator** - Completed
  - *Takeaway:* Add inside EditForm to enable attribute-based validation ([Required], [StringLength], etc.)

- ✅ **ValidationMessage** - Completed
  - *Takeaway:* Display field-specific errors with For="() => model.Property"; shows custom error messages from attributes

- ✅ **OnValidSubmit Event** - Completed
  - *Takeaway:* Only fires when form passes all validation; use for submit logic; form prevents submit if invalid

- ✅ **InputText & InputCheckbox** - Completed
  - *Takeaway:* Blazor input components (not plain HTML) required for binding; @bind-Value connects to model properties

### 1.6 Component Communication ⭐ NEW
**Status:** ✅ Completed | **Progress:** 80%

- ✅ **[Parameter] Attribute** - Completed
  - *Takeaway:* Marks properties to receive data from parent; enables parent-to-child communication

- ✅ **EventCallback Pattern** - Completed
  - *Takeaway:* Type-safe child-to-parent communication; InvokeAsync() calls parent method; supports async operations

- ✅ **Component References (@ref)** - Completed
  - *Takeaway:* Access component instance programmatically; useful for focus management and direct method calls

- ✅ **Parent-Child Architecture** - Completed
  - *Takeaway:* Separate concerns (data management vs. display); reusable child components with clear interfaces

---

## Phase 2: Backend & Data Management

### 2.1 Entity Framework Core ⚠️ NEXT FOCUS
**Status:** 🟡 Starting | **Progress:** 5%

- 🔴 **DbContext Setup** - Not Started
  - *Takeaway:* TBD - Will replace localStorage with database

- 🔴 **Entity Models** - Not Started
  - *Takeaway:* TBD - TaskerItem ready to become entity

- 🔴 **Migrations** - Not Started
  - Code-First approach
  - *Takeaway:* TBD

- 🔴 **CRUD Operations** - Not Started
  - *Takeaway:* TBD - Similar to localStorage operations but with DbContext

- 🔴 **Relationships** - Not Started
  - One-to-Many, Many-to-Many
  - *Takeaway:* TBD

- 🔴 **Querying with LINQ** - Not Started
  - *Takeaway:* TBD

### 2.2 Database Design
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **Normalization** - Not Started
  - *Takeaway:* TBD

- 🔴 **Primary/Foreign Keys** - Not Started
  - *Takeaway:* TBD

- 🔴 **Data Annotations** - Partial Knowledge
  - *Takeaway:* Know [Required] for validation; need to learn EF-specific annotations

- 🔴 **Seeding Data** - Not Started
  - *Takeaway:* TBD

### 2.3 Service Layer Architecture
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **Dependency Injection** - Not Started
  - *Takeaway:* TBD

- 🔴 **Service Interfaces** - Not Started
  - *Takeaway:* TBD

- 🔴 **Repository Pattern** - Not Started
  - *Takeaway:* TBD

- 🔴 **Unit of Work** - Not Started
  - *Takeaway:* TBD

---

## Phase 3: Web APIs & Integration

### 3.1 ASP.NET Core Web API
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **Creating API Controllers** - Not Started
  - *Takeaway:* TBD

- 🔴 **RESTful Routing** - Not Started
  - *Takeaway:* TBD

- 🔴 **HTTP Methods** - Not Started
  - GET, POST, PUT, DELETE
  - *Takeaway:* TBD - Will mirror Tasker CRUD operations

- 🔴 **Status Codes** - Not Started
  - *Takeaway:* TBD

- 🔴 **Model Validation** - Not Started
  - *Takeaway:* TBD

### 3.2 API Integration in Blazor
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **HttpClient Setup** - Not Started
  - *Takeaway:* TBD

- 🔴 **Making API Calls** - Not Started
  - *Takeaway:* TBD - Will replace localStorage calls

- 🔴 **Async/Await Patterns** - Partial Knowledge
  - *Takeaway:* Understand async/await from component lifecycle; need to apply to HttpClient

- 🔴 **Error Handling** - Not Started
  - *Takeaway:* TBD

- 🔴 **Loading States** - Not Started
  - *Takeaway:* TBD

### 3.3 DTOs & Data Transfer
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **Creating DTOs** - Not Started
  - *Takeaway:* TBD

- 🔴 **AutoMapper** - Not Started
  - *Takeaway:* TBD

- 🔴 **JSON Serialization** - Partial Knowledge
  - *Takeaway:* Used JsonSerializer for localStorage; same concepts apply to APIs

---

## Phase 4: Authentication & Security

### 4.1 ASP.NET Core Identity
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **Identity Setup** - Not Started
  - *Takeaway:* TBD

- 🔴 **User Registration** - Not Started
  - *Takeaway:* TBD

- 🔴 **Login/Logout** - Not Started
  - *Takeaway:* TBD

- 🔴 **Password Hashing** - Not Started
  - *Takeaway:* TBD

- 🔴 **Role Management** - Not Started
  - *Takeaway:* TBD

### 4.2 JWT Authentication
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **JWT Basics** - Not Started
  - *Takeaway:* TBD

- 🔴 **Token Generation** - Not Started
  - *Takeaway:* TBD

- 🔴 **Token Validation** - Not Started
  - *Takeaway:* TBD

- 🔴 **Refresh Tokens** - Not Started
  - *Takeaway:* TBD

### 4.3 Authorization
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **Role-Based Authorization** - Not Started
  - *Takeaway:* TBD

- 🔴 **Policy-Based Authorization** - Not Started
  - *Takeaway:* TBD

- 🔴 **Securing API Endpoints** - Not Started
  - *Takeaway:* TBD

---

## Phase 5: Advanced Blazor Features

### 5.1 State Management
**Status:** 🟡 Partial | **Progress:** 30%

- 🔴 **Cascading Parameters** - Not Started
  - *Takeaway:* TBD

- 🔴 **State Containers** - Not Started
  - *Takeaway:* TBD

- ✅ **Local Storage** - Completed
  - *Takeaway:* Client-side only; good for simple persistence; will migrate to database for multi-user support

- 🔴 **AppState Pattern** - Not Started
  - *Takeaway:* TBD

### 5.2 Form Handling
**Status:** ✅ Basics Complete | **Progress:** 60%

- ✅ **EditForm Component** - Completed
  - *Takeaway:* Already implemented in Tasker

- ✅ **Data Annotations Validation** - Completed
  - *Takeaway:* [Required] attribute working in Tasker

- 🔴 **Custom Validation** - Not Started
  - *Takeaway:* TBD

- ✅ **Form Submission** - Completed
  - *Takeaway:* OnValidSubmit event in Tasker

### 5.3 Component Communication
**Status:** ✅ Completed | **Progress:** 80%

- ✅ **Parent-Child Communication** - Completed
  - *Takeaway:* Implemented in Tasker/TaskerLine relationship

- ✅ **EventCallback** - Completed
  - *Takeaway:* Used for Delete and Complete callbacks

- 🔴 **State Management Services** - Not Started
  - *Takeaway:* TBD

### 5.4 JavaScript Interop
**Status:** ✅ Basics Complete | **Progress:** 60%

- ✅ **Calling JS from C#** - Completed
  - *Takeaway:* localStorage.setItem/getItem via IJSRuntime

- 🔴 **Calling C# from JS** - Not Started
  - *Takeaway:* TBD

- 🔴 **Using JS Libraries** - Not Started
  - *Takeaway:* TBD

---

## Phase 6: Testing

### 6.1 Unit Testing
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **xUnit Basics** - Not Started
  - *Takeaway:* TBD

- 🔴 **Testing Services** - Not Started
  - *Takeaway:* TBD

- 🔴 **Mocking with Moq** - Not Started
  - *Takeaway:* TBD

- 🔴 **Assertions** - Not Started
  - *Takeaway:* TBD

### 6.2 Integration Testing
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **Testing API Endpoints** - Not Started
  - *Takeaway:* TBD

- 🔴 **In-Memory Database** - Not Started
  - *Takeaway:* TBD

### 6.3 Blazor Component Testing
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **bUnit Framework** - Not Started
  - *Takeaway:* TBD

- 🔴 **Testing User Interactions** - Not Started
  - *Takeaway:* TBD

---

## Phase 7: DevOps & Deployment

### 7.1 Docker
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **Docker Basics** - Not Started
  - *Takeaway:* TBD

- 🔴 **Creating Dockerfile** - Not Started
  - *Takeaway:* TBD

- 🔴 **Docker Compose** - Not Started
  - *Takeaway:* TBD

- 🔴 **Container Orchestration** - Not Started
  - *Takeaway:* TBD

### 7.2 Cloud Deployment
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **Azure App Service** - Not Started
  - *Takeaway:* TBD

- 🔴 **Azure SQL Database** - Not Started
  - *Takeaway:* TBD

- 🔴 **Static Web Apps** - Not Started
  - For Blazor WASM
  - *Takeaway:* TBD

- 🔴 **Environment Configuration** - Not Started
  - *Takeaway:* TBD

### 7.3 CI/CD
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **GitHub Actions Basics** - Not Started
  - *Takeaway:* TBD

- 🔴 **Build Pipelines** - Not Started
  - *Takeaway:* TBD

- 🔴 **Automated Deployment** - Not Started
  - *Takeaway:* TBD

- 🔴 **Automated Testing** - Not Started
  - *Takeaway:* TBD

---

## Phase 8: Real-World Project

### 8.1 Full-Stack E-Commerce App
**Status:** 🔴 Not Started | **Progress:** 0%

- 🔴 **Project Planning** - Not Started
  - *Takeaway:* TBD

- 🔴 **Database Design** - Not Started
  - Products, Users, Orders, Cart
  - *Takeaway:* TBD

- 🔴 **API Development** - Not Started
  - *Takeaway:* TBD

- 🔴 **Blazor Frontend** - Not Started
  - *Takeaway:* TBD

- 🔴 **Authentication** - Not Started
  - *Takeaway:* TBD

- 🔴 **Shopping Cart** - Not Started
  - *Takeaway:* TBD

- 🔴 **Order Processing** - Not Started
  - *Takeaway:* TBD

- 🔴 **Admin Dashboard** - Not Started
  - *Takeaway:* TBD

- 🔴 **Deployment** - Not Started
  - *Takeaway:* TBD

---

## 🎯 Current Focus

**This Week (Nov 18-24):**
- ✅ Blazor fundamentals - COMPLETED
- ⏳ Start Entity Framework Core module
- ⏳ Set up database (SQL Server LocalDB or PostgreSQL)
- ⏳ Create TaskerItem entity and DbContext
- ⏳ First database migration

**Next Week Preview (Nov 25-Dec 1):**
- Web API creation for Tasker
- RESTful endpoints (GET, POST, PUT, DELETE)
- Replace localStorage with API calls in Blazor
- HttpClient integration

---

## 📈 Learning Velocity Tracking

| Week | Sections Completed | Hours Studied | Key Achievements |
|------|-------------------|---------------|------------------|
| Nov 10-16 | 3 | ~8h | Initial Blazor setup, routing, basic components |
| Nov 17-18 | 6 | ~14h | ✅ Tasker app with JS interop, forms, lifecycle, EventCallback |
| Nov 19-24 | TBD | TBD | Target: EF Core basics, database setup |
| Nov 25-Dec 1 | TBD | TBD | Target: API development |

---

## ⚠️ Critical Path Items (Cannot Skip)

These topics must be completed in order:

1. ✅ Blazor Component Basics → **COMPLETED** ✅
2. ✅ Component Lifecycle → **COMPLETED** ✅
3. ✅ Forms & Validation → **COMPLETED** ✅
4. ✅ JavaScript Interop → **COMPLETED** ✅
5. 🔴 **Entity Framework Core** → ⚠️ **START THIS WEEK**
6. 🔴 **Web APIs** → Required for job readiness
7. 🔴 **Identity & JWT** → Required for portfolio projects
8. 🔴 **Unit Testing** → Industry standard
9. 🔴 **Docker** → Modern deployment requirement
10. 🔴 **CI/CD** → Professional workflow

**Enforcement Rule:**
✅ Phase 1 (Fundamentals) is COMPLETE enough to move forward. **DO NOT** spend more time on frontend-only features. Your next focus MUST be:
- Entity Framework Core (this week)
- Web APIs (next week)
- Authentication (following week)

---

## 📚 Supplementary Topics (Optional but Valuable)

- SignalR for real-time features
- gRPC services
- GraphQL APIs
- Microservices architecture
- Domain-Driven Design
- CQRS pattern
- Event Sourcing
- Message Queues (RabbitMQ)

---

## 🏆 Milestones & Rewards

- [✅] **Milestone 1:** Complete Phase 1 Basics - *COMPLETED Nov 18, 2025* 🎉
- [ ] **Milestone 2:** First Database Integration - *Target: Nov 24*
- [ ] **Milestone 3:** First Web API - *Target: Dec 1*
- [ ] **Milestone 4:** Authentication Implemented - *Target: Dec 29*
- [ ] **Milestone 5:** First Project Deployed - *Target: Jan 12*
- [ ] **Milestone 6:** Portfolio Ready - *Target: Feb 1*
- [ ] **FINAL MILESTONE:** Job Application Ready - *Target: Feb 15*

---

## 📝 Notes & Reflections

### Learning Insights
- Component lifecycle is crucial for timing JS interop calls correctly
- EventCallback pattern is elegant for parent-child communication
- Data annotations provide easy validation with minimal code
- localStorage is great for learning but has limitations (client-side only)

### Challenging Topics
- Understanding when to use OnInitializedAsync vs OnAfterRenderAsync
- Async/await patterns with void vs Task return types
- JSON serialization edge cases (null handling)

### Quick Wins
- ✅ Tasker component functional in 1 day
- ✅ Form validation "just worked" with data annotations
- ✅ Component reference for auto-focus was straightforward

---

*This roadmap is updated weekly. Stay focused on the critical path. Backend mastery is non-negotiable.*
