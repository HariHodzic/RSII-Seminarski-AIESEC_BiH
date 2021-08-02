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
        public TasksController(ITaskService service):base(service)
        {

        }
    }
}
