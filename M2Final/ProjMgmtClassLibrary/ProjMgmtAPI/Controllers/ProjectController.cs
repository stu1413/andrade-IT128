using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjMgmtDataLibrary.Data;
using ProjMgmtDataLibrary.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class projectsController : ControllerBase
    {
        private ISqlData _db;

        public projectsController(ISqlData db)
        {
            _db = db;
        }

        /* Project */

        //[Authorize]
        [HttpGet]
        public ActionResult ListProjects()
        {
            List<ListProjectModel> project = _db.ListProjects();

            return Ok(project);
        }

        //[Authorize]
        [HttpPost]
        [Route("/api/[controller]/add")]
        public ActionResult AddProject([FromBody] ProjectForm form)
        {
            ProjectModel project = new ProjectModel();
            project.Title = form.Title;
            project.Description = form.Description;
            project.ClientId = form.ClientId;
            project.Budget = form.Budget;
            project.EmployeeId = form.EmployeeId;
            project.StartDate = form.StartDate;
            project.EndDate = form.EndDate;
            _db.AddProject(project);

            return Ok("Project created.");
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{pId}")]
        public ActionResult ShowProjectDetails(int pId)
        {
            ListProjectModel project = _db.ShowProjectDetails(pId);

            return Ok(project);
        }

        //[Authorize]
        [HttpPut]
        [Route("/api/[controller]/{pId}/edit")]
        public ActionResult EditProject([FromBody] ProjectEdit form, int pId)
        {
            ProjectEdit project = new ProjectEdit();
            project.Title = form.Title;
            project.Description = form.Description;
            project.Budget = form.Budget;
            _db.EditProject(project, pId);

            return Ok("Project edited.");
        }

        //[Authorize]
        [HttpDelete]
        [Route("/api/[controller]/{pId}/delete")]
        public ActionResult DeleteProject(int pId)
        {
            _db.DeleteProject(pId);

            return Ok("Project deleted.");
        }

        /* Task */

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/tasks")]
        public ActionResult ListTasks()
        {
            List<ListTaskModel> task = _db.ListTasks();

            return Ok(task);
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{pId}/tasks")]
        public ActionResult ListProjectTasks(int pId)
        {
            List<ListProjectTasksModel> task = _db.ListProjectTasks(pId);

            return Ok(task);
        }

        //[Authorize]
        [HttpPost]
        [Route("/api/[controller]/{pId}/tasks/add")]
        public ActionResult AddTask([FromBody] TaskForm form, int pId)
        {
            TaskModel task = new TaskModel();
            task.Description = form.Description;
            task.ProjectId = form.ProjectId;
            task.BeginDate = form.BeginDate;
            task.DueDate = form.DueDate;
            _db.AddTask(task, pId);

            return Ok("Task created.");
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{pId}/tasks/{tId}")]
        public ActionResult ShowTaskDetails(int tId)
        {
            ListTaskModel task = _db.ShowTaskDetails(tId);

            return Ok(task);
        }

        //[Authorize]
        [HttpPut]
        [Route("/api/[controller]/{pId}/tasks/{tId}/edit")]
        public ActionResult EditTask([FromBody] TaskEdit form, int tId)
        {
            TaskEdit task = new TaskEdit();
            task.Description = form.Description;
            _db.EditTask(task, tId);

            return Ok("Task edited.");
        }

        //[Authorize]
        [HttpDelete]
        [Route("/api/[controller]/{pId}/tasks/{tId}/delete")]
        public ActionResult DeleteTask(int tId)
        {
            _db.DeleteTask(tId);

            return Ok("Task deleted.");
        }

        /* Assignment */

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/tasks/assignments")]
        public ActionResult ListAssignments()
        {
            List<ListAssignmentModel> assignment = _db.ListAssignments();

            return Ok(assignment);
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{pId}/tasks/{tId}/assignments")]
        public ActionResult ListTaskAssignments(int tId)
        {
            List<ListTaskAssignmentsModel> assignment = _db.ListTaskAssignments(tId);

            return Ok(assignment);
        }

        //[Authorize]
        [HttpPost]
        [Route("/api/[controller]/{pId}/tasks/{tId}/assignments/add")]
        public ActionResult AddAssignment([FromBody] AssignmentForm form, int tId)
        {
            AssignmentModel assignment = new AssignmentModel();
            assignment.TaskId = form.TaskId;
            assignment.DepartmentId = form.DepartmentId;
            assignment.EmployeeId = form.EmployeeId;
            assignment.StartDate = form.StartDate;
            assignment.EndDate = form.EndDate;
            _db.AddAssignment(assignment, tId);

            return Ok("Assignment created.");
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{pId}/tasks/{tId}/assignments/{aId}")]
        public ActionResult ShowAssignmentDetails(int aId)
        {
            ListAssignmentModel assignment = _db.ShowAssignmentDetails(aId);

            return Ok(assignment);
        }

        //[Authorize]
        [HttpPut]
        [Route("/api/[controller]/{pId}/tasks/{tId}/assignments/{aId}/edit")]
        public ActionResult EditAssignment([FromBody] AssignmentEdit form, int aId)
        {
            AssignmentEdit assignment = new AssignmentEdit();
            assignment.EmployeeId = form.EmployeeId;
            assignment.StartDate = form.StartDate;
            assignment.EndDate = form.EndDate;
            _db.EditAssignment(assignment, aId);

            return Ok("Assignmet edited.");
        }

        //[Authorize]
        [HttpDelete]
        [Route("/api/[controller]/{pId}/tasks/{tId}/assignments/{aId}/delete")]
        public ActionResult DeleteAssignment(int aId)
        {
            _db.DeleteAssignment(aId);

            return Ok("Assignment deleted.");
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{pId}/tasks/{tId}/assignments/{aId}/employees")]
        public ActionResult ListAssignmentEmployees(int aId)
        {
            List<ListAssignmentEmployeesModel> employees = _db.ListAssignmentEmployees(aId);

            return Ok(employees);
        }

    }
}