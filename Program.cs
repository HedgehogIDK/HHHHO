using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

Shop c = new Shop(123);
Shop f = new Shop(200);
c += 100;
WriteLine(c.Square);
c -= 100;
WriteLine(c.Square);
WriteLine(c == f);
WriteLine(c > f);
WriteLine(c < f);
WriteLine(c != f);
WriteLine(c.Equals(f));




class Magazine
{
    private string _name, _description, _phone, _mail;
    private int _age, numberOfEmployees;

    public Magazine(int numberOfEmployees)
    {
        this.numberOfEmployees = numberOfEmployees;
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
        get { return numberOfEmployees; }
        set { numberOfEmployees = value; }
    }
    public static Magazine operator +(Magazine first, int second)
    {
        return new Magazine(first.numberOfEmployees + second);
    }
    public static Magazine operator -(Magazine first, int second)
    {
        return new Magazine(first.numberOfEmployees - second);
    }
    public static bool operator ==(Magazine obj1, Magazine obj2)
    {
        if (obj1.numberOfEmployees == obj2.numberOfEmployees)
            return true;
        return false;
    }
    public static bool operator !=(Magazine obj1, Magazine obj2)
    {
        if (obj1.numberOfEmployees != obj2.numberOfEmployees)
            return true;
        return false;
    }
    public static bool operator <(Magazine obj1, Magazine obj2)
    {
        if (obj1.numberOfEmployees < obj2.numberOfEmployees)
            return true;
        return false;
    }
    public static bool operator >(Magazine obj1, Magazine obj2)
    {
        if (obj1.numberOfEmployees > obj2.numberOfEmployees)
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

class Shop
{
    private string _name, _description, _phone, _mail, _address;
    private int square;

    public Shop(int _square)
    {
        square = _square;
    }

    public int Square
    {
        get { return square; }
        set { square = value; }
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
    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public static Shop operator +(Shop first, int second)
    {
        return new Shop(first.square + second);
    }
    public static Shop operator -(Shop first, int second)
    {
        return new Shop(first.square - second);
    }
    public static bool operator ==(Shop obj1, Shop obj2)
    {
        if (obj1.square == obj2.square)
            return true;
        return false;
    }
    public static bool operator !=(Shop obj1, Shop obj2)
    {
        if (obj1.square != obj2.square)
            return true;
        return false;
    }
    public static bool operator <(Shop obj1, Shop obj2)
    {
        if (obj1.square < obj2.square)
            return true;
        return false;
    }
    public static bool operator >(Shop obj1, Shop obj2)
    {
        if (obj1.square > obj2.square)
            return true;
        return false;
    }
    public override bool Equals(object? obj)
    {
        if (obj is Shop magazine) return Square == magazine.Square;
        return false;
    }

    public void Print()
    {
        WriteLine($"Название магазина: {_name}");
        WriteLine($"Адрес: {_address}");
        WriteLine($"Описание: {_description}");
        WriteLine($"Электронная почта: {_mail}");
    }
}

class ListOfBooks
{
    private string[] list;
    private int size;

    public ListOfBooks(int sizeList)
    {
        size = sizeList;
        list = new string[size];
    }
    public void Print()
    {
        foreach(var obj in list)
        {
            WriteLine(obj);
        }
    }
    public void Add(string userBook)
    {
        Array.Resize(ref list,size++);
        
        list[size - 1] = userBook;
    }
    public void Del()
    {
        Array.Resize(ref list, size--);
    }
    public bool Search(string userBook)
    {
        if (list.Contains(userBook))
            return true;

        return false;
    }
    public static ListOfBooks operator +(ListOfBooks first, ListOfBooks second)
    {
        ListOfBooks buffer = new ListOfBooks(first.size + second.size);
        for (int i = 0; i < first.size; i++)
        {
            buffer.list[i] = first.list[i];
        }
        for (int i = 0; i < second.size; i++)
        {
            buffer.list[i + first.size] = second.list[i]; 
        }
        return buffer;
    }
    public static bool operator ==(ListOfBooks obj1, ListOfBooks obj2)
    {
        if (obj1.list == obj2.list)
            return true;
        return false;
    }
    public static bool operator !=(ListOfBooks obj1, ListOfBooks obj2)
    {
        if (obj1.list != obj2.list)
            return true;
        return false;
    }

    public override bool Equals(object? obj)
    {
        if (obj is ListOfBooks buf) return list == buf.list;
        return false;
    }
}