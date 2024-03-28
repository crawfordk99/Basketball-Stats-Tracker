public abstract class FieldGoal {
    private int _shotsMade;
    private int _shotsAttempted;

    public FieldGoal() {}
    public FieldGoal(int shotsMade, int shotsAttempted) {
        _shotsMade = shotsMade;
        _shotsAttempted = shotsAttempted;
    }

    public abstract double CalculateTrueShooting();
}