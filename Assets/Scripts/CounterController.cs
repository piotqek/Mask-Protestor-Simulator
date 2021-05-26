using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{
    public Text countText;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
    }



    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        
    }

    public void IncreaseCount()
    {
        count++;
        SetCountText();
    }

    public void ResetGame() //wymaga jeszcze pracy
    {
        count = 0;
    }

    public int WhatsTheScore()
    {
        return count;
    }
}
