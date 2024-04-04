public class DreamTeam {
    private string _team;
    private int _jerseyNumber;
    
    public DreamTeam() {}
    public DreamTeam(string team, int jerseyNumber) {
        _team = team;
        _jerseyNumber = jerseyNumber;
    }  
    public string Team {get{return _team;} set{_team = value;}}
    public int JerseyNumber {get{return _jerseyNumber;} set{_jerseyNumber = value;}}
    


}