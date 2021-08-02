using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.Services.BaseServices;

namespace AiesecBiH.IServices
{
    public interface ITaskService:ICRUDService<Model.Response.TaskDetails, Model.Search.Task, Model.Update.Task, Model.Insert.Task>
    {
    }
}
