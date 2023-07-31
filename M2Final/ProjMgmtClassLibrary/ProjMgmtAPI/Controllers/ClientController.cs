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
    public class clientsController : ControllerBase
    {
        private ISqlData _db;

        public clientsController(ISqlData db)
        {
            _db = db;
        }

        //[Authorize]
        [HttpGet]
        public ActionResult ListClients()
        {
            List<ListClientModel> client = _db.ListClients();

            return Ok(client);
        }

        //[Authorize]
        [HttpPost]
        [Route("/api/[controller]/add")]
        public ActionResult AddClient([FromBody] ClientForm form)
        {
            ClientModel client = new ClientModel();
            client.Name = form.Name;
            client.Phone = form.Phone;
            client.Email = form.Email;
            client.RegionId = form.RegionId;
            _db.AddClient(client);

            return Ok("Client added.");
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{id}")]
        public ActionResult ShowClientDetails(int id)
        {
            ListClientModel client = _db.ShowClientDetails(id);

            return Ok(client);
        }

        //[Authorize]
        [HttpPut]
        [Route("/api/[controller]/{id}/edit")]
        public ActionResult EditClient([FromBody] ClientEdit form, int id)
        {
            ClientEdit client = new ClientEdit();
            client.Phone = form.Phone;
            client.Email = form.Email;
            _db.EditClient(client, id);

            return Ok("Client edited.");
        }

        //[Authorize]
        [HttpDelete]
        [Route("/api/[controller]/{id}/delete")]
        public ActionResult DeleteRole(int id)
        {
            _db.DeleteClient(id);

            return Ok("Client deleted.");
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{id}/projects")]
        public ActionResult ListClientProjects(int id)
        {
            List<ListClientProjectsModel> client = _db.ListClientProjects(id);

            return Ok(client);
        }

    }
}