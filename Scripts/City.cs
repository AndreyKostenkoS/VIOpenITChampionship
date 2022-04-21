using System.Collections.Generic;
using UnityEngine;

public class City
{
    private bool _availability;
    private string _cityName;
    private GameObject _cityObject;
    public static List<City> cityList = new List<City>();

    public City(bool availab, string name, GameObject cObj)
    {
        _availability = availab;
        _cityName = name;
        _cityObject = cObj;
    }

    public bool Availability
    {
        get { return _availability; }
        set { _availability = value; }
    }

    public string CityName
    {
        get { return _cityName; }
        set { _cityName = value; }
    }

    public GameObject CityObject
    {
        get { return _cityObject; }
        set { _cityObject = value; }
    }

}
