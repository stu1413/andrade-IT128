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
    public class employeesController : ControllerBase
    {
        private ISqlData _db;

        public employeesController(ISqlData db)
        {
            _db = db;
        }

        //[Authorize]
        [HttpGet]
        public ActionResult ListEmployees()
        {
            List<ListEmployeeModel> employee = _db.ListEmployees();

            return Ok(employee);
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{id}")]
        public ActionResult ShowEmployeeDetails(int id)
        {
            ListEmployeeModel employee = _db.ShowEmployeeDetails(id);

            return Ok(employee);
        }

        //[Authorize]
        [HttpPut]
        [Route("/api/[controller]/{id}/edit")]
        public ActionResult EditEmployee([FromBody] EmployeeEdit form, int id)
        {
            EmployeeEdit employee = new EmployeeEdit();
            employee.Phone = form.Phone;
            employee.Password = form.Password;
            _db.EditEmployee(employee, id);

            return Ok("Client edited.");
        }

        //[Authorize]
        [HttpDelete]
        [Route("/api/[controller]/{id}/delete")]
        public ActionResult DeleteEmployee(int id)
        {
            _db.DeleteEmployee(id);

            return Ok("Employee deleted.");

        }
    }
}