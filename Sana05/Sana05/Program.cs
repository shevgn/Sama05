// See https://aka.ms/new-console-template for more information

var startDate = new MyDate(2023, 12, 21, 12, 00);
var finishDate = new MyDate(2023, 12, 21, 22, 00);
var airplane = new Airplane("Ukraine", "Egypt", startDate, finishDate);

Console.WriteLine("Total time in minutes:  {0}", airplane.GetTotalTime());
Console.WriteLine("Is arriving today: {0}", airplane.IsArrivingToday());

class Airplane
{
    protected string _startCity { get; set; } = null!;
    protected string _finishCity { get; set; } = null!;
    protected MyDate _startDate { get; set; } = null!;
    protected MyDate _finishDate { get; set; } = null!;

    public Airplane()
    {
        
    }

    public Airplane(string startCity, MyDate startDate)
    {
        _startCity = startCity;
        _startDate = startDate;
    }
    public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
    {
        _startCity = startCity;
        _finishCity = finishCity;
        _startDate = startDate;
        _finishDate = finishDate;
    }

    public Airplane(Airplane airplane)
    {
        _startCity = airplane._startCity;
        _finishCity = airplane._finishCity;
        _startDate = airplane._startDate;
        _finishDate = airplane._finishDate;
    }
    public int GetTotalTime()
    {
        return (_finishDate.Hours - _startDate.Hours)*60 + (_finishDate.Minutes - _startDate.Minutes);
    }

    public bool IsArrivingToday()
    {
        return _finishDate.Day == _startDate.Day;
    }

    public string StartCity
    {
        get => _startCity;
        set => _startCity = value;
    }
    public string FinishCity
    {
        get => _finishCity;
        set => _finishCity = value;
    }
    public MyDate StartDate
    {
        get => _startDate;
        set => _startDate = value;
    }
    public MyDate FinishDate
    {
        get => _finishDate;
        set => _finishDate = value;
    }
}

class MyDate
{
    protected int _year { get; set; }
    protected int _month { get; set; }
    protected int _day { get; set; }
    protected int _hours { get; set; }
    protected int _minutes { get; set; }

    public MyDate(int year, int month, int day, int hours, int minutes)
    {
        _year = year;
        _month = month;
        _day = day;
        _hours = hours;
        _minutes = minutes;
    }

    public int Year
    {
        get => _year;
        set => _year = value;
    }
    public int Month
    {
        get => _month;
        set => _month = value;
    }
    public int Day
    {
        get => _day;
        set => _day = value;
    }
    public int Hours
    {
        get => _hours;
        set => _hours = value;
    }
    public int Minutes
    {
        get => _minutes;
        set => _minutes = value;
    }
}