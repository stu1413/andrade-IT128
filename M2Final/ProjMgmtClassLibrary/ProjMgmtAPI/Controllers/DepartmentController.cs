using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjMgmtDataLibrary.Data;
using ProjMgmtDataLibrary.Models;
using System.Security.Claims;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class departmentsController : ControllerBase
    {
        private ISqlData _db;

        public departmentsController(ISqlData db)
        {
            _db = db;
        }

        //[Authorize]
        [HttpGet]
        public ActionResult ListDepartments()
        {
            List<ListDepartmentModel> department = _db.ListDepartments();

            return Ok(department);
        }

        //[Authorize]
        [HttpPost]
        [Route("/api/[controller]/add")]
        public ActionResult AddDepartment([FromBody] DepartmentForm form)
        {
            DepartmentModel department = new DepartmentModel();
            department.Department = form.Department;
            department.Description = form.Description;
            _db.AddDepartment(department);

            return Ok("Department added.");
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{id}")]
        public ActionResult ShowDepartmentDetails(int id)
        {
            ListDepartmentModel department = _db.ShowDepartmentDetails(id);

            return Ok(department);
        }

        //[Authorize]
        [HttpPut]
        [Route("/api/[controller]/{id}/edit")]
        public ActionResult EditDepartment([FromBody] DepartmentEdit form, int id)
        {
            DepartmentEdit department = new DepartmentEdit();
            department.Department = form.Department;
            _db.EditDepartment(department, id);

            return Ok("Department edited.");
        }

        //[Authorize]
        [HttpDelete]
        [Route("/api/[controller]/{id}/delete")]
        public ActionResult DeleteDepartment(int id)
        {
            _db.DeleteDepartment(id);

            return Ok("Department deleted.");
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{id}/employees")]
        public ActionResult ListDepartmentEmployees(int id)
        {
            List<ListDepartmentEmployeesModel> department = _db.ListDepartmentEmployees(id);

            return Ok(department);
        }

    }
}