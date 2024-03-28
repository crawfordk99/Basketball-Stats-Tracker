public class DreamTeam {
    private string _team;
    private int _jerseyNumber;
    
    public DreamTeam() {}
    public DreamTeam(string team, int jerseyNumber) {
        _team = team;
        _jerseyNumber = jerseyNumber;
    }  
    public string Team {get; set;}
    public int JerseyNumber {get; set;}

    public string GetTeam() {
        return Team;
    }
}