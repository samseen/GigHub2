using GigHub2.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GigHub2.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult Attend(int gigId)
        {
            var attendance = new Attendance
            {
                GigId = gigId,
                AttendeeId = User.Identity.GetUserId()
            };
        }
    }
}
