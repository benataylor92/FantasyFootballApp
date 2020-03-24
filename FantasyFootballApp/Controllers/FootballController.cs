using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using FantasyFootballApp.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace FantasyFootballApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Football")]
    public class FootballController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            HttpClient footballClient = new HttpClient();
            var result = await footballClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/");
            var json = await result.Content.ReadAsStringAsync();
            JObject jsonTree = JObject.Parse(json);
            var footballerJson = jsonTree["elements"].ToString();
            List<Footballer> data = JsonConvert.DeserializeObject<List<Footballer>>(footballerJson);

            return Ok(data);
        }
    }
}