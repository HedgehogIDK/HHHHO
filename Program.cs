using System;
using static System.Console;

Magazine a = new Magazine(123);
Magazine b = new Magazine(200);
a += 100;
WriteLine(a.NumberOfEmployees);
a -= 100;
WriteLine(a.NumberOfEmployees);
WriteLine(a == b);
WriteLine(a > b);
WriteLine(a < b);
WriteLine(a != b);
WriteLine(a.Equals(b));

class Magazine
{
    private string _name, _description, _phone, _mail;
    private int _age, _numberOfEmployees;

    public Magazine(int numberOfEmployees)
    {
        _numberOfEmployees = numberOfEmployees;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public string Phone
    {
        get { return _phone; }
        set { _phone = value; }
    }
    public string Mail
    {
        get { return _mail; }
        set { _mail = value; }
    }
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
    public int NumberOfEmployees
    {
        get { return _numberOfEmployees; }
        set { _numberOfEmployees = value; }
    }
    public static Magazine operator +(Magazine first, int second)
    {
        return new Magazine(first._numberOfEmployees + second);
    }
    public static Magazine operator -(Magazine first, int second)
    {
        return new Magazine(first._numberOfEmployees - second);
    }
    public static bool operator ==(Magazine obj1, Magazine obj2)
    {
        if (obj1._numberOfEmployees == obj2._numberOfEmployees)
            return true;
        return false;
    }
    public static bool operator !=(Magazine obj1, Magazine obj2)
    {
        if (obj1._numberOfEmployees != obj2._numberOfEmployees)
            return true;
        return false;
    }
    public static bool operator <(Magazine obj1, Magazine obj2)
    {
        if (obj1._numberOfEmployees < obj2._numberOfEmployees)
            return true;
        return false;
    }
    public static bool operator >(Magazine obj1, Magazine obj2)
    {
        if (obj1._numberOfEmployees > obj2._numberOfEmployees)
            return true;
        return false;
    }
    public override bool Equals(object? obj)
    {
        if (obj is Magazine magazine) return NumberOfEmployees == magazine.NumberOfEmployees;
        return false;
    }

    public void Print()
    {
        WriteLine($"Название журнала: {_name}");
        WriteLine($"Год основания: {_age}");
        WriteLine($"Описание: {_description}");
        WriteLine($"Контактный номер: {_phone}");
        WriteLine($"Электронная почта: {_mail}");
    }
}
