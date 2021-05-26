using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void FlipRight()
    {
        mySpriteRenderer.flipX = false;
    }

    public void FlipLeft()
    {
        mySpriteRenderer.flipX = true;
    }
}
