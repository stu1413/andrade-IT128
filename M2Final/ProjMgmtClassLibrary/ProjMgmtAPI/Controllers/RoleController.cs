using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjMgmtDataLibrary.Data;
using ProjMgmtDataLibrary.Models;
using System.Data;
using System.Security.Claims;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class rolesController : ControllerBase
    {
        private ISqlData _db;

        public rolesController(ISqlData db)
        {
            _db = db;
        }

        //[Authorize]
        [HttpGet]
        public ActionResult ListRoles()
        {
            List<ListRoleModel> role = _db.ListRoles();

            return Ok(role);
        }

        //[Authorize]
        [HttpPost]
        [Route("/api/[controller]/add")]
        public ActionResult AddRole([FromBody] RoleForm form)
        {
            RoleModel role = new RoleModel();
            role.Role = form.Role;
            _db.AddRole(role);

            return Ok("Role added.");
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{id}")]
        public ActionResult ShowRoleDetails(int id)
        {
            ListRoleModel role = _db.ShowRoleDetails(id);

            return Ok(role);
        }

        //[Authorize]
        [HttpPut]
        [Route("/api/[controller]/{id}/edit")]
        public ActionResult EditRole([FromBody] RoleEdit form, int id)
        {
            RoleEdit role = new RoleEdit();
            role.Role = form.Role;
            _db.EditRole(role, id);

            return Ok("Role edited.");
        }

        //[Authorize]
        [HttpDelete]
        [Route("/api/[controller]/{id}/delete")]
        public ActionResult DeleteRole(int id)
        {
            _db.DeleteRole(id);

            return Ok("Role deleted.");
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{id}/employees")]
        public ActionResult ListRoleEmployees(int id)
        {
            List<ListRoleEmployeesModel> role = _db.ListRoleEmployees(id);

            return Ok(role);
        }

    }
}