using UnityEngine;
using UnityEngine.SceneManagement;

public class MapElementsUsage : MonoBehaviour
{

    public Material defaultMaterial;
    public Material customMaterial;
    public Material overrideMaterial;

    private void OnMouseEnter()
    {
        foreach (City city in City.cityList)
        {
            if (gameObject == city.CityObject & city.Availability)
            {
                gameObject.transform.localScale = new Vector2(1.25f, 1.25f);
            }
        }
    }

    private void OnMouseDown()
    {
        foreach(City city in City.cityList)
        {
            if (gameObject.name == city.CityName & city.CityName == "Moscow")
            {
                SceneManager.LoadScene("Scene_01");
            }
        }
    }

    private void OnMouseExit()
    {
        gameObject.transform.localScale = new Vector2(1f, 1f);
    }

    private void FixedUpdate()
    {
        foreach(City city in City.cityList)
        {
            if (city.Availability)
            {
                city.CityObject.GetComponent<SpriteRenderer>().material = defaultMaterial; 
            }
            else
            {
                city.CityObject.GetComponent<SpriteRenderer>().material = customMaterial;
            }
        }
    }

}
