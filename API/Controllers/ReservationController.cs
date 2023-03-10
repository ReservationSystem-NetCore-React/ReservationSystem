using Domain.DomainEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class ReservationController : ControllerBase
    {
        private readonly ILogger<ReservationController> _logger;
        private readonly IReservationRepository _reservationRepository;

        public ReservationController(ILogger<ReservationController> logger, IReservationRepository reservationRepository)
        {
            _logger = logger;
            _reservationRepository = reservationRepository;
        }


        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetReservation(int id)
        {
            try
            {
                var reservation = await _reservationRepository.GetReservation(id);
                return Ok(reservation);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message); //User nie moze tego wiedziec do zrefactorowania
            }
        }

        [HttpGet(Name = "GetReservations")]
        [AllowAnonymous]
        public IActionResult GetReservations()
        {
            try
            {
                var reservationList = _reservationRepository.GetReservations();
                return Ok (reservationList.Result);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message); //User nie moze tego wiedziec do zrefactorowania
            }
        }

        [HttpPost("Create")]
        public IActionResult CreateReservation([FromBody] Reservation reservation)
        {
            // TODO Reservation musi pobierac customerId z zalogowanego usera.
            try
            {
                _reservationRepository.InsertReservation(reservation);
                return Ok();
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Reservation reservation)
        {
            try
            {
                await _reservationRepository.UpdateReservation(reservation);
                return Ok();
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteReservation(int id)
        {
            try
            {
                _reservationRepository.DeleteReservation(id);
                return Ok();
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
