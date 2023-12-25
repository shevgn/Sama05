// See https://aka.ms/new-console-template for more information

var startDate = new MyDate(2023, 12, 21, 12, 00);
var finishDate = new MyDate(2023, 12, 21, 22, 00);

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