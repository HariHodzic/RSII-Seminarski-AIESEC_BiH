using AiesecBiH.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Controllers
{
    public class TasksController : BaseCRUDController<Model.Response.TaskDetails,Model.Search.Task,Model.Update.Task,Model.Insert.Task>
    {
        private readonly ITaskService _taskService; 
        public TasksController(ITaskService service):base(service)
        {
            _taskService = service;
        }


        [HttpPost("Execute/{id}")]
        public async Task<Model.Response.TaskDetails> Execute(int id,[FromBody]int memberId)
        {
            var result = await _taskService.Execute(id, memberId);
            return result;
        }
    }
}
