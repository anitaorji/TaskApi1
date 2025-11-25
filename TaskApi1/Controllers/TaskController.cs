using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Mvc;
using TaskApi1.Models;
using TaskApi1.Repository;

namespace TaskApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private static readonly List<string> Tasks = [];
        
        // GET: api/tasks
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(TaskRepository.Tasks);
        }


        // POST: api/tasks
        [HttpPost]
        public IActionResult Create(TaskApi1.Models.Task task)
        {
            //task.Id = TaskRepository.Tasks.Count + 1;
            TaskRepository.Tasks.Add(task);
            return Ok(task);
        }

        // PUT: api/tasks/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, TaskApi1.Models.Task updated)
        {
            var task = TaskRepository.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return NotFound();
            task.Title = updated.Title;
            task.IsCompleted = updated.IsCompleted;
            return Ok(task);
        }


    }

}


