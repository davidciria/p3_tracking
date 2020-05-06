using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public float totalTime; //Total time to pick up objects in seconds.
    public Text timer;
    public Text counterText;
    private int totalCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (totalTime <= 0.0f)
        {
            TimeEnded();
        }
        else
        {
            counterText.text = "Count = " + totalCounter;
            totalTime -= Time.deltaTime;
            timer.text = ((int)totalTime).ToString();
        }

    }

    void TimeEnded()
    {
        timer.text = "Time finished, you get " + totalCounter + " points";
        counterText.text = "";
    }

    public void elevateCounter()
    {
        totalCounter++;
    }
}
