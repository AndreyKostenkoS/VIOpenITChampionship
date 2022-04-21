using UnityEngine;

public class EndlessRoadScrolling : MonoBehaviour
{

    [SerializeField]
    private float _speed;

    private Vector2 _offset;

    void Update()
    {
        _offset = new Vector2(-Time.time * _speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = _offset;
    }
}
