﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BarberShop.DoMain;
using BarberShop.Entity.DataContexts;

namespace BarberShop.Api.Controllers
{
    [RoutePrefix("api/guru/public")]
    public class UsuariosController : ApiController
    {
        private BarberShopDataContext db = new BarberShopDataContext();

        [Route("usuario")]
        public HttpResponseMessage GetFuncionarios()
        {
            var result = db.Usuario.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);

        }/*
        // GET: api/Usuarios
        public IQueryable<Usuario> GetUsuario()
        {
            return db.Usuario;
        }

        // GET: api/Usuarios/5
        [ResponseType(typeof(Usuario))]
        public IHttpActionResult GetUsuario(int id)
        {
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        // PUT: api/Usuarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUsuario(int id, Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usuario.id)
            {
                return BadRequest();
            }

            db.Entry(usuario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
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

        // POST: api/Usuarios
        [ResponseType(typeof(Usuario))]
        public IHttpActionResult PostUsuario(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Usuario.Add(usuario);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = usuario.id }, usuario);
        }

        // DELETE: api/Usuarios/5
        [ResponseType(typeof(Usuario))]
        public IHttpActionResult DeleteUsuario(int id)
        {
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }

            db.Usuario.Remove(usuario);
            db.SaveChanges();

            return Ok(usuario);
        }*/

        protected override void Dispose(bool disposing)
        {
                db.Dispose();           
        }
        /*
        private bool UsuarioExists(int id)
        {
            return db.Usuario.Count(e => e.id == id) > 0;
        }*/
    }
}