using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
            if (transform.position.x < -1)
            {
                transform.position += Vector3.right;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
            if (transform.position.x > 1)
            {
                transform.position += Vector3.left;
            }
        }
    }
}
