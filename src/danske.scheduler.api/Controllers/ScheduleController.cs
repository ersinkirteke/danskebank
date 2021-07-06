using danske.scheduler.api.services;
using danske.scheduler.common.domain.models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace danske.scheduler.producer.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScheduleController : BaseController<ScheduleController>
    {
        private readonly IScheduleService _scheduleService;
        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        /// <summary>
        /// insert a schedule data
        /// </summary>
        /// <param name="notification"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> CreateSchedule([FromBody] ScheduleRequest schedule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _scheduleService.CreateNotifications(schedule);

            return Created("Notifications", result);
        }
    }
}
