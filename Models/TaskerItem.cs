using System.ComponentModel.DataAnnotations;

namespace BlazorIntro.Models;

public class TaskerItem
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "every task must have a name")]
    public string Name { get; set; } = "";

    public bool IsComplete { get; set; } = false;
}