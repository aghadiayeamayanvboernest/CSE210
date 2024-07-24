using System;

class Program
{
    static void Main()
    {
        // Creating Address instances for each type of event
        Address lectureAddress = new Address("1 Uselu Road", "Benin City", "Edo", "300001");
        Address receptionAddress = new Address("20 Sapele Road", "Benin City", "Edo", "300002");
        Address outdoorAddress = new Address("35 Akpakpava Street", "Benin City", "Edo", "300003");

        // Creating a Lecture instance
        // Parameters: title, description, date, time, address, speaker, capacity
        Lecture lecture = new Lecture(
            "Tech Innovations", 
            "Exploring new tech trends.", 
            new DateTime(2024, 8, 10), 
            new TimeSpan(14, 0, 0), 
            lectureAddress, 
            "Dr. Smith", 
            100
        );

        // Creating a Reception instance
        // Parameters: title, description, date, time, address, RSVP email
        Reception reception = new Reception(
            "Annual Gala", 
            "Join us for an evening of celebration.", 
            new DateTime(2024, 9, 5), 
            new TimeSpan(19, 0, 0), 
            receptionAddress, 
            "rsvp@example.com"
        );

        // Creating an OutdoorGathering instance
        // Parameters: title, description, date, time, address, weather forecast
        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Summer Festival", 
            "A day of fun and festivities.", 
            new DateTime(2024, 7, 22), 
            new TimeSpan(10, 0, 0), 
            outdoorAddress, 
            "Sunny with a chance of clouds"
        );

        // Storing the events in an array
        Event[] events = { lecture, reception, outdoorGathering };

        // Iterating through the events array to print details
        foreach (var ev in events)
        {
            // Print the standard details of the event
            Console.WriteLine(ev.GetStandardDetails());

            // Print the full details of the event
            Console.WriteLine(ev.GetFullDetails());

            // Print the short description of the event
            Console.WriteLine(ev.GetShortDescription());

            // Add a blank line for better readability between events
            Console.WriteLine();
        }
    }
}
