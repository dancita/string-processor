using Microsoft.AspNetCore.Mvc;

namespace StringProcessor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringController : ControllerBase
    {
        /// <summary>
        /// Retrieves the populated StringStatsModel of the specified string
        /// </summary>
        /// <param name="inputString">The string to retrieve the StringStatsModel of</param>
        /// <returns>The populated StringStatsModel</returns>
        [HttpGet("{inputString}")]
        public ActionResult<StringStatsModel> GetStringStatsModelByString(string inputString)
        {
            var stringStatsProcessor = new StringStatsProcessor();
            var stringStatsModel = stringStatsProcessor.Run(inputString);

            return Ok(stringStatsModel);
        }
    }
}