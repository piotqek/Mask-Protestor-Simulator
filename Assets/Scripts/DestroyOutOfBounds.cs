using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float lowerBound = -6f;
    private float upperBound = 6f;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        if (transform.position.y < lowerBound || transform.position.y > upperBound)
        {
            Destroy(gameObject);
        }
    }
}
