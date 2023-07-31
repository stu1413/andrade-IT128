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
    public class regionsController : ControllerBase
    {
        private ISqlData _db;

        public regionsController(ISqlData db)
        {
            _db = db;
        }

        //[Authorize]
        [HttpGet]
        public ActionResult ListRegions()
        {
            List<ListRegionModel> region = _db.ListRegions();

            return Ok(region);
        }

        //[Authorize]
        [HttpPost]
        [Route("/api/[controller]/add")]
        public ActionResult AddRegion([FromBody] RegionForm form)
        {
            RegionModel region = new RegionModel();
            region.Region = form.Region;
            region.Code = form.Code;
            _db.AddRegion(region);

            return Ok("Region added.");
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{id}")]
        public ActionResult ShowRegionDetails(int id)
        {
            ListRegionModel region = _db.ShowRegionDetails(id);

            return Ok(region);
        }

        //[Authorize]
        [HttpPut]
        [Route("/api/[controller]/{id}/edit")]
        public ActionResult EditRegion([FromBody] RegionEdit form, int id)
        {
            RegionEdit region = new RegionEdit();
            region.Region = form.Region;
            region.Code = form.Code;
            _db.EditRegion(region, id);

            return Ok("Region edited.");
        }

        //[Authorize]
        [HttpDelete]
        [Route("/api/[controller]/{id}/delete")]
        public ActionResult DeleteRegion(int id)
        {
            _db.DeleteRegion(id);

            return Ok("Region deleted.");
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{id}/employees")]
        public ActionResult ListRegionEmployees(int id)
        {
            List<ListRegionEmployeesModel> region = _db.ListRegionEmployees(id);

            return Ok(region);
        }

        //[Authorize]
        [HttpGet]
        [Route("/api/[controller]/{id}/clients")]
        public ActionResult ListRegionClients(int id)
        {
            List<ListRegionClientsModel> region = _db.ListRegionClients(id);

            return Ok(region);
        }

    }
}