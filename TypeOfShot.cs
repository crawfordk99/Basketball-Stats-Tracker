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