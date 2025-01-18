// To separate shooting percentages depending on amount of dribbles 
// taken beforehand, and to separate 2 pt shots from 3 pt shots
public class TypeOfShot {
    private string _dribbles;
    private string _pointsType;

    public TypeOfShot() {}
    public TypeOfShot(string dribbles, string pointsType) {
        _dribbles = dribbles;
        _pointsType = pointsType;
    }
    public string Dribbles {get{return _dribbles;} set{_dribbles = value;}}
    public string PointsType {get{return _pointsType;} set{_pointsType = value;}}
}