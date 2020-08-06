﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using GiftListEditor.BLL.Models;
using GiftListEditor.DAL;
using GiftListEditor.DAL.DTO;
using PDCore.Repositories.IRepo;

namespace GiftListEditor.Api
{
    [RoutePrefix("api")]
    public class TaskController : ApiController
    {
        private readonly ISqlRepositoryEntityFrameworkDisconnected<BLL.Models.Task> taskRepository;

        public TaskController(ISqlRepositoryEntityFrameworkDisconnected<BLL.Models.Task> taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        // GET: api/Task
        [Route("tasks")]
        [ResponseType(typeof(TaskDtos))]
        public async Task<IHttpActionResult> GetTasks()
        {
            TaskDtos tasks = await taskRepository.GetAllAsync();

            return Ok(tasks);
        }

        //private WebmailContext db = new WebmailContext();

        //// GET: api/Task
        //public IQueryable<Task> GetTasks()
        //{
        //    return db.Tasks;
        //}

        //// GET: api/Task/5
        //[ResponseType(typeof(Task))]
        //public async Task<IHttpActionResult> GetTask(int id)
        //{
        //    Task task = await db.Tasks.FindAsync(id);
        //    if (task == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(task);
        //}

        //// PUT: api/Task/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutTask(int id, Task task)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != task.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(task).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TaskExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Task
        //[ResponseType(typeof(Task))]
        //public async Task<IHttpActionResult> PostTask(Task task)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Tasks.Add(task);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = task.Id }, task);
        //}

        //// DELETE: api/Task/5
        //[ResponseType(typeof(Task))]
        //public async Task<IHttpActionResult> DeleteTask(int id)
        //{
        //    Task task = await db.Tasks.FindAsync(id);
        //    if (task == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Tasks.Remove(task);
        //    await db.SaveChangesAsync();

        //    return Ok(task);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool TaskExists(int id)
        //{
        //    return db.Tasks.Count(e => e.Id == id) > 0;
        //}
    }
}