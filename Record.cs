public class Record {
    private string _teamGames;
    private string _oneOnOne;

    public Record() {}
    public Record(string teamGames, string oneOnOne) {
        _teamGames = teamGames;
        _oneOnOne = oneOnOne;
    }
    public string TeamGames {get; set;}
    public string OneOnOne {get; set;}
}