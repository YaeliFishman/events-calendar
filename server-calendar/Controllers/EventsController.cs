using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server_calendar.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private DataContext _dataContext;

        public EventsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        //private static List<Event> events = new List<Event> 
        //{ 
        //    //new Event { Id = 1, Title = "wedding" ,Start = new DateTime(2023,09,11)} ,
        //    //new Event { Id = 2, Title = "chanuca", Start = new DateTime(2023,09,25) },
        //    //new Event { Id = 3, Title = "birthday" ,Start = new DateTime(2023,09,10)},
        //    //new Event { Id = 4, Title = "course" ,Start = new DateTime(2023,09,14)} 
        //};

        // GET: api/<EventsController>
        [HttpGet]

        public IEnumerable<Event> Get()
        {
            return _dataContext.EventList;
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Event myEvent)
        {
            _dataContext.EventList.Add(new Event { Id=4,Title=myEvent.Title,Start=myEvent.Start});
            return;
        }
       
        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public Event Put(int id, [FromBody] Event updateEvent)
        {
            var e = _dataContext.EventList.Find(e => e.Id == id);
            e.Title = updateEvent.Title;
            return e;
        }
        
        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var e = _dataContext.EventList.Find(e => e.Id == id);
            _dataContext.EventList.Remove(e);
        }
    }
}
