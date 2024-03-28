public class TwoPoints : FieldGoal {
    
    public TwoPoints() {}
    public TwoPoints(int shotsMade, int shotsAttempted) : base(shotsMade, shotsAttempted) {
        
    }
    public override double CalculateTrueShooting() {
        return 0;
    }
}