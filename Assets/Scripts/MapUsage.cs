using UnityEngine;

public class MapUsage : MonoBehaviour
{
    private void Start()
    {
        City.cityList.Add(new City(false, "Saint-Peterburg", GameObject.Find("Saint-Peterburg")));
        City.cityList.Add(new City(true, "Moscow", GameObject.Find("Moscow")));
        City.cityList.Add(new City(false, "EKB", GameObject.Find("EKB")));


    }
}
