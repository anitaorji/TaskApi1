using Microsoft.AspNetCore.Mvc;
using TaskApi1.Models;

namespace TaskApi1.Repository
{
    public class TaskRepository
    {
        public static List<Models.Task> Tasks { get; set; } = new();
    }
}
