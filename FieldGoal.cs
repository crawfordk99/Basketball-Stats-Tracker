// Parent Class, to determine type of field goal, and set stats
// to be kept tracked of
public abstract class FieldGoal {
    private int _shotsMade;
    private int _shotsAttempted;

    public int ShotsMade {get{return _shotsMade;} set{ _shotsMade = value;}}
    public int ShotsAttempted {get{return _shotsAttempted;} set{_shotsAttempted = value;}}

    public FieldGoal() {}
    public FieldGoal(int shotsMade, int shotsAttempted) {
        _shotsMade = shotsMade;
        _shotsAttempted = shotsAttempted;
    }

    public abstract double CalculateTrueShooting();
}

