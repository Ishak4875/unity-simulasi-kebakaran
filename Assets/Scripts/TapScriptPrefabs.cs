using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapScriptPrefabs : MonoBehaviour
{
    public static int health;
    public static bool falseAnswer = false;
    public static bool trueAnswer = false;
    public static int trueAnswerNumber;
    float time;
    public static bool isTimerRun;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        time = 15;
        isTimerRun = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isTimerRun)
        {
            if(time > 0)
            {
                time -= Time.deltaTime;
                time = Mathf.Round(time * 1000f) / 1000f;
            }
            else
            {
                isTimerRun = false;
                time = 0;
            }
            GameObject.Find("Time Text").GetComponent<Text>().text = "Waktu : " + time.ToString();
        }

        if (falseAnswer)
        {
            health--;
            GameObject.Find("Health Text").GetComponent<Text>().text = "Nyawa : " + health.ToString();
            falseAnswer = false;
        }
        if (trueAnswer)
        {
            trueAnswer = false;
        }   
    }

    public void FalseAnswer()
    {
        GameObject.FindGameObjectWithTag("FalseAnswer").GetComponent<AudioSource>().Play();
        falseAnswer = true;
    }

    public void TrueAnswer()
    {
        trueAnswerNumber++;
        GameObject.FindGameObjectWithTag("TrueAnswer").GetComponent<AudioSource>().Play();
        trueAnswer = true;
    }
}
