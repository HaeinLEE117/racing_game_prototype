using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{    
    public float targetTime = 1f;

    IEnumerator GasMover()
    {
        while (true)
        {
            yield return new WaitForSeconds(targetTime);
            transform.position -= Vector3.forward;

            if (transform.position.z < -5)
            {
                Destroy(gameObject);
            }
        }
    }

    public void Awake()
    {
        StartCoroutine(GasMover());
    }
    
    
}
