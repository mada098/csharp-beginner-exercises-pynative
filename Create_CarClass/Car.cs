namespace CarClass;

public class Car
{
    private string _make;
    private string _model;
    private int _year;

    public Car(string make, string model, int year)
    {
        _make = make;
        _model = model;
        _year = year;
    }

    public void DisplayCarInfo()
    {
        Console.WriteLine($"Make: {_make}\nModel: {_model}\nYear: {_year}");
    }
    
}