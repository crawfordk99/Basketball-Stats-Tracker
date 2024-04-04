public class ThreePoints : FieldGoal {
   
   public ThreePoints() {}
   public ThreePoints(int shotsMade, int shotsAttempted) : base(shotsMade, shotsAttempted) {
    
   }
   public override double CalculateTrueShooting() {
        int shots = base.ShotsMade;
        int attempts = base.ShotsAttempted;
        double percentage = (double) shots/attempts;
        return percentage * 1.5;
   }
}