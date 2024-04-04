public class TwoPoints : FieldGoal {
    
    public TwoPoints() {}
    public TwoPoints(int shotsMade, int shotsAttempted) : base(shotsMade, shotsAttempted) {
        
    }
    public override double CalculateTrueShooting() {
        int shots = base.ShotsMade;
        int attempts = base.ShotsAttempted;
        double percentage = (double)shots/attempts;
        return percentage;
    }
}