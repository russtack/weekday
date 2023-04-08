internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(GetDay(6));
       
    }
    static string GetDay(int dayNum)
    {
        string dayName;
        switch (dayNum)
        {
            case 0:
                dayName = "Monday"; break;
            case 1: dayName = "Tuesday"; break;
            case 2: dayName = "Wednesday"; break;
            case 3: dayName = "Thurday"; break;
            case 4: dayName = "Friday"; break;
            case 5: dayName = "Saturday";break;
            case 6: dayName = "Sunday";break;
            default: dayName = "invalid input"; break;
        }
        return dayName; 
    }
}