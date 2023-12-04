using System.Net.NetworkInformation;

namespace Codealong;

public class Horse
{
    private int _speed;
    private int _totalTime;

    public Horse(int speed)
    {
        _speed = speed;
    }

    public void Feed()
    {
        Console.WriteLine("Hesten er mett!");
    }

    public void TakeCareOf()
    {
        Console.WriteLine("Hesten er fornøyd");
    }

    public int GetRoundTime(int distance)
    {
        var time = distance * _speed;
        _totalTime += time;
        return _totalTime;
    }
    
}