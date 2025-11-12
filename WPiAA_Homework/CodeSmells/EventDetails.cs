namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class EventDetails
    {
        public required string EventName { get; set; }
        public required DateTime EventDate { get; set; }
        public required string Location { get; set; }

        public void RegisterEvent(EventDetails eventDetails)
        {
            Console.WriteLine($"Event: {eventDetails.EventName}, Date: {eventDetails.EventDate}, Location: {eventDetails.Location}");
        }
    }
}
