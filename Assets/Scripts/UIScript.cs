using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public float totalTime; //Tiempo total para poder recoger objetos.
    private float initTime;
    public Text timer;
    public Text counterText;
    private int totalCounter = 0;
    public GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        initTime = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (totalTime <= 0.0f)
        {
            TimeEnded();
            restartButton.GetComponent<Button>().onClick.AddListener(() =>
            {
                restartConfig();
                restartButton.SetActive(false);
            });

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
        restartButton.SetActive(true);
    }

    public void elevateCounter()
    {
        if(totalTime > 0.0f)
        {
            totalCounter++;
        }
    }

    void restartConfig()
    {
        totalCounter = 0;
        totalTime = initTime;
    }

}
