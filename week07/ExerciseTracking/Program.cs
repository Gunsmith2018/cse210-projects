using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>()
        {
            new Running("03 Nov 2022", 30, 3),      // 3 miles (or km)
            new Cycling("03 Nov 2022", 30, 10),     // 10 mph (or kph)
            new Swimming("03 Nov 2022", 30, 40)     // 40 laps
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}