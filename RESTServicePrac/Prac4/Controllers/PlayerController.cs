using Prac4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prac4.Controllers
{
    public class PlayerController : ApiController
    {
        List<Player> pList = Player.GetAllPlayers();
        // GET api/player
        public IHttpActionResult GetAllPlayers()
        {
            return Ok(pList);
        }

        // GET api/player/5
        public IHttpActionResult GetPlayer(String value)
        {
            Player p = pList.FirstOrDefault(o => o.RegistrationID == value);
            if (p == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(p);
            }
        }
        public IHttpActionResult GetPlayerByName(String value)
        {
            List<Player> findList = pList.Where(o => (o.FirstName.ToUpper().Contains(value.ToUpper()) || o.LastName.ToUpper().Contains(value.ToUpper())) || (o.FirstName + " " + o.LastName).ToUpper().Contains(value.ToUpper())).ToList();
            if (findList == null || findList.Count ==0)
            {
                return NotFound();
            }
            else
            {
                return Ok(findList);
            }
        }

        public IHttpActionResult DeletePlayer(String value)
        {
            Player p = pList.FirstOrDefault(o => o.RegistrationID == value);
            if (p == null)
            {
                return NotFound();
            }
            else
            {
                pList.Remove(p);
                Player.UpdateFile(pList);
                return Ok(pList);
            }
        }

        public IHttpActionResult DeletePlayerByName(String value)
        {
            List<Player> findList = pList.Where(o => o.FirstName.ToUpper().Contains(value.ToUpper()) || o.LastName.ToUpper().Contains(value.ToUpper())).ToList();
            if (findList == null || findList.Count == 0)
            {
                return NotFound();
            }
            else
            {
                List<Player> rest = pList.Except(findList).ToList();
                Player.UpdateFile(rest);
                return Ok(rest);
            }
        }

        public IHttpActionResult PostPlayer(Player p)
        {
            if (ModelState.IsValid)
                p.SaveToFile();
            else
                return Ok<string>("WI");

            if (p.DateOfBirth == DateTime.MinValue) 
                return Ok<String>("WD");

            return Ok(Player.GetAllPlayers());
        }

        // PUT api/player/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/player/5
        public void Delete(int id)
        {
        }
    }
}
