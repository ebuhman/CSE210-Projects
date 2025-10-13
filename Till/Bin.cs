class Bin
{
    // Attributes
    private string _denomination;
    private double _value;
    private int _count;

    // Behaviors
    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }
    public void Alter(int delta)
    {
        _count += delta;
    }
    // accessory "getter" methods
    public string GetDemonination() 
    {
        return _denomination; 
    }
    public int GetCount()
    {
        return _count; 
    }


}