﻿namespace RelaxAndSport.Web.Features
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using RelaxAndSport.Application.Booking.MassagesAppointments.Commands.CreateMassageAppointment;
    using RelaxAndSport.Web.Common;
    using System.Threading.Tasks;

    public class MassagesAppointmentsController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreateMassageAppointmentOutputModel>> Create(CreateMassageAppointmentCommand command)
            => await this.Send(command);
    }
}
