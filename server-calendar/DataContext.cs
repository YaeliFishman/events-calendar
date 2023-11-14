using server_calendar;

namespace server_calendar
{
    public class DataContext
    {
        public List<Event> EventList { get; set; }

        public List<string> SomeList { get; set; }

        public DataContext()
        {
            EventList = new List<Event>();
            EventList.Add(new Event { Id = 1, Title = "hello" });
        }

    }
}