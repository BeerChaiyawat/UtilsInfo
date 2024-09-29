using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UtilsInfoAPI.Models;

namespace UtilsInfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {

        }

        [HttpPost]
        public IActionResult CreateDateString([FromBody] DateTimeUtils dateFormat)
        {
            DateTimeUtils data = new DateTimeUtils();
            try
            {
                if (string.IsNullOrEmpty(dateFormat.CreateDateString))
                    throw new ArgumentNullException(nameof(dateFormat.CreateDateString));

                data.CreateDateString = dateFormat.CreateDateString;
                return Ok(data);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
