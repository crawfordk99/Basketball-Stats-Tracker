public class Record {
    private string _type;
    private int _wins;
    private int _losses;

    public string Type {get{return _type;} set{_type = value;}}
    public int Wins {get{return _wins;} set{_wins = value;}}
    public int Loses {get{return _losses;} set{_losses = value;}}

    public Record() {}
    public Record(string type, int wins, int losses) {
        _wins = wins;
        _losses = losses;
        _type = type;
    }
    
}