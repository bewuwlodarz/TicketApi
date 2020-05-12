using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Microsoft.AspNetCore.Mvc;
using TicketApi.Context;
using TicketApi.Models;

namespace TicketApi.Controllers
{
    [Route("api/[controller]")]

    public class CustomerController : Controller
    {
       
            private readonly ApiContext _ctx;
            public CustomerController(ApiContext ctx)
            {
                _ctx = ctx;
            }
            [HttpGet]
            public IActionResult Get()
            {
                var data = _ctx.Customers.OrderBy(c => c.ID);

                return Ok(data);
            }

            [HttpGet("{id}", Name = "GetCustomer")]
            public IActionResult Get(int id)
            {
                var customer = _ctx.Customers.Find(id);
                return Ok(customer);
            }
        // POST: api/Customers
        [ResponseType(typeof(CustomerModel))]
        public IActionResult PostCustomer(CustomerModel customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _ctx.Customers.Add(customer);
            _ctx.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = customer.ID }, customer);
        }
    }

}