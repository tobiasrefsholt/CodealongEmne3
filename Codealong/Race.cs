namespace Codealong;

public class Race
{
    private List<Horse> _horses = new List<Horse>();
    private int _rounds;
    private int _roundLength;

    public Race(int roundLength, int rounds)
    {
        _roundLength = roundLength;
        _rounds = rounds;
    }

    public void AddHorse(Horse horse)
    {
        _horses.Add(horse);
    }

    private void NewRound()
    {
        foreach (var horse in _horses)
        {
            Console.WriteLine(horse.GetRoundTime(_roundLength));
        }
    }

    public void Start()
    {
        for (int round = 0; round < _rounds; round++)
        {
            NewRound();
        }

        /*foreach (var horse in _horses)
        {
            horse.GetTotalTime();
        }*/
        Console.WriteLine("Løpet er ferdig.");
    }
}