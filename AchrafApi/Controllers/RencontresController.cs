using System;
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
using AchrafApi.Models;

namespace AchrafApi.Controllers
{
    public class RencontresController : ApiController
    {
        private AchrafApiContext db = new AchrafApiContext();

        // GET: api/Rencontres
        public IQueryable<Rencontre> GetRencontres()
        {
            return db.Rencontres;
        }

        // GET: api/Rencontres/5
        [ResponseType(typeof(Rencontre))]
        public async Task<IHttpActionResult> GetRencontre(int id)
        {
            Rencontre rencontre = await db.Rencontres.FindAsync(id);
            if (rencontre == null)
            {
                return NotFound();
            }

            return Ok(rencontre);
        }

        // PUT: api/Rencontres/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRencontre(int id, Rencontre rencontre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rencontre.Id)
            {
                return BadRequest();
            }

            db.Entry(rencontre).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RencontreExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Rencontres
        [ResponseType(typeof(Rencontre))]
        public async Task<IHttpActionResult> PostRencontre(Rencontre rencontre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rencontres.Add(rencontre);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = rencontre.Id }, rencontre);
        }

        // DELETE: api/Rencontres/5
        [ResponseType(typeof(Rencontre))]
        public async Task<IHttpActionResult> DeleteRencontre(int id)
        {
            Rencontre rencontre = await db.Rencontres.FindAsync(id);
            if (rencontre == null)
            {
                return NotFound();
            }

            db.Rencontres.Remove(rencontre);
            await db.SaveChangesAsync();

            return Ok(rencontre);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RencontreExists(int id)
        {
            return db.Rencontres.Count(e => e.Id == id) > 0;
        }
    }
}