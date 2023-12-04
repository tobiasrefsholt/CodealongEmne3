namespace Codealong;

public class Race
{
    private readonly List<Horse> _horses = new List<Horse>();
    private readonly int _rounds;
    private readonly int _roundLength;

    public Race(int roundLength, int rounds)
    {
        _roundLength = roundLength;
        _rounds = rounds;
    }

    public void AddHorse(Horse horse)
    {
        _horses.Add(horse);
    }

    private void NewRound(int round)
    {
        Console.WriteLine("Runde " + round);
        foreach (var horse in _horses)
        {
            Console.WriteLine(horse.GetRoundTime(_roundLength));
        }
    }

    public void Start()
    {
        for (var round = 0; round < _rounds; round++)
        {
            NewRound(round + 1);
        }

        Console.WriteLine("Løpet er ferdig.");
    }
}