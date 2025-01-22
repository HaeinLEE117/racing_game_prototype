using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject[] _maps;
    private float _timer = 0f;
    public float targetTime = 1f;
    public Vector3 resetPosition;
    
    void Start()
    {
        foreach (var obj in _maps)
        {
            StartCoroutine(MapMover(obj));
        }
    }

    IEnumerator MapMover(GameObject map)
    {
        while(true)
        {
            yield return new WaitForSeconds(targetTime);
            if (map.transform.position.z < -10)
            {
                map.transform.position = resetPosition;
            }
            map.transform.position -= Vector3.forward;
        }
    }
    
}
