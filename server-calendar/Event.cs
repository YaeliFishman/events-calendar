namespace server_calendar
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Event()
        {
        }

        public  Event(int id, string title, DateTime start, DateTime end)
        {
            Id = id;
            Title = title;
            Start = start;
            End = end;
        }
    }
}
