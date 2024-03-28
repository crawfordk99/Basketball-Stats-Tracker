public class ThreePoints : FieldGoal {
   
   public ThreePoints() {}
   public ThreePoints(int shotsMade, int shotsAttempted) : base(shotsMade, shotsAttempted) {
    
   }
   public override double CalculateTrueShooting() {
        return 0;
   }
}