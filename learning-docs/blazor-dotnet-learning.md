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

---

## JavaScript Interop — 2025-11-18

Definitions

- IJSRuntime interface allows C# code to invoke JavaScript functions
- Common use cases: localStorage, browser APIs, third-party JS libraries
- InvokeVoidAsync for functions with no return value
- InvokeAsync<T> for functions returning data

Key Points

- Must inject IJSRuntime via @inject directive
- localStorage is browser-based key-value storage (client-side only)
- Data persists across browser sessions until cleared
- All JSInterop calls are asynchronous
- Data must be serialized/deserialized (JSON)

Best Practices

- Always wrap JSInterop calls in try-catch blocks
- Use System.Text.Json for serialization (built-in, fast)
- Provide fallback values when loading from localStorage
- Store complex objects as JSON strings
- Use meaningful key names for localStorage items

Gotchas

- localStorage data persists indefinitely (not automatically cleared)
- 5-10MB storage limit per domain (browser-dependent)
- Data is stored as strings only (must serialize/deserialize)
- Not available during prerendering (server-side)
- Can fail if user disabled localStorage or in private browsing

Example

```csharp
@inject IJSRuntime JS

// Save to localStorage
var json = JsonSerializer.Serialize(data);
await JS.InvokeVoidAsync("localStorage.setItem", "key", json);

// Load from localStorage
var json = await JS.InvokeAsync<string>("localStorage.getItem", "key") ?? "[]";
var data = JsonSerializer.Deserialize<List<T>>(json);
```

---

## Component Lifecycle Methods — 2025-11-18

Definitions

- OnInitialized/OnInitializedAsync: Called when component is initialized (once)
- OnAfterRender/OnAfterRenderAsync: Called after component has rendered
- firstRender parameter: true only on first render, useful for JS interop

Key Points

- OnInitializedAsync is ideal for loading data from APIs or storage
- OnAfterRender runs after every render cycle unless you check firstRender
- Can't invoke JS interop in OnInitialized (DOM not ready yet)
- Use OnAfterRender with firstRender check for focus management, JS initialization

Best Practices

- Load data in OnInitializedAsync, not constructor
- Use firstRender parameter to avoid repeated JS calls
- Keep lifecycle methods focused and simple
- Call StateHasChanged() only when needed

Gotchas

- OnAfterRender called after EVERY render (can be performance issue)
- JS interop fails in OnInitialized (use OnAfterRender instead)
- Async lifecycle methods need await for proper execution

Example

```csharp
protected override async Task OnInitializedAsync()
{
    await LoadDataAsync();  // Load data on init
}

protected override async Task OnAfterRenderAsync(bool firstRender)
{
    if (firstRender)
    {
        await textBox.Element.Value.FocusAsync();  // Focus input after first render
    }
}
```

---

## Form Validation — 2025-11-18

Definitions

- EditForm: Blazor component for handling forms with validation
- DataAnnotationsValidator: Enables validation using data annotation attributes
- ValidationMessage: Displays validation errors for specific properties
- OnValidSubmit: Event triggered only when form passes validation

Key Points

- Model property must use [Required], [StringLength], etc. attributes
- ValidationMessage shows field-specific errors
- Form won't submit if validation fails
- Can customize error messages in data annotations

Best Practices

- Always use EditForm over plain HTML forms
- Include DataAnnotationsValidator inside EditForm
- Provide user-friendly error messages
- Use ValidationMessage for each validated input
- Reset model after successful submit

Gotchas

- Must use InputText, InputCheckbox (not plain HTML inputs) for binding
- Validation only works with EditForm, not regular forms
- Model must be non-null for binding to work

Example

```csharp
<EditForm Model="model" OnValidSubmit="HandleSubmit">
    <DataAnnotationsValidator />
    <InputText @bind-Value="model.Name" />
    <ValidationMessage For="() => model.Name" />
    <button type="submit">Submit</button>
</EditForm>

// Model
public class TaskerItem
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = "";
}
```

---

## Component Parameters & EventCallback — 2025-11-18

Definitions

- [Parameter]: Attribute marking properties that receive data from parent
- [EditorRequired]: Indicates parameter is mandatory (design-time warning)
- EventCallback: Type-safe way to invoke parent methods from child components
- EventCallback<T>: Generic version passing data to parent

Key Points

- Parameters enable parent-to-child communication
- EventCallback enables child-to-parent communication
- EventCallback.InvokeAsync() calls the parent's method
- Use generic EventCallback<T> to pass data up to parent

Best Practices

- Mark required parameters with [EditorRequired]
- Use nullable types (?) for optional parameters
- Name EventCallbacks clearly (OnDeleteCallback, OnCompleteCallback)
- Document parameters with XML comments (///)
- Keep child components reusable and generic

Gotchas

- Parameters are one-way by default (parent to child)
- Must use EventCallback.InvokeAsync(), not direct invocation
- Changed parameters don't automatically trigger re-render

Example

```csharp
// Child component
[Parameter]
[EditorRequired]
public TaskerItem? Item { get; set; }

[Parameter]
public EventCallback<TaskerItem> OnDeleteCallback { get; set; }

private async Task OnDelete()
{
    await OnDeleteCallback.InvokeAsync(Item);
}

// Parent component
<TaskerLine Item="item" OnDeleteCallback="DeleteTask" />

@code {
    private void DeleteTask(TaskerItem item) { }
}
```

---

## State Management Basics — 2025-11-18

Definitions

- Component state: Data stored within a component (private fields/properties)
- State persistence: Saving state beyond component lifecycle (localStorage, database)
- Two-way binding: Automatic sync between UI and model (@bind-Value)

Key Points

- State resets when navigating away unless persisted
- localStorage keeps data client-side between sessions
- List modifications require new list instance for re-render
- After state changes, call StateHasChanged() if needed

Best Practices

- Save state after every modification (add, delete, update)
- Load state in OnInitializedAsync
- Provide default/empty state if load fails
- Use meaningful state variable names

Gotchas

- Modifying list items doesn't trigger auto-refresh
- localStorage only works client-side (not during SSR)
- Forgetting to await async save operations loses data

Example

```csharp
private List<TaskerItem> items = new();

protected override async Task OnInitializedAsync()
{
    await LoadListAsync();
}

private async void AddTask()
{
    items.Add(newItem);
    await SaveListAsync();
}

private async Task SaveListAsync()
{
    var json = JsonSerializer.Serialize(items);
    await JS.InvokeVoidAsync("localStorage.setItem", "items", json);
}
```

