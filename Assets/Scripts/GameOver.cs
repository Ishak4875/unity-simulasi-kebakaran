using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject Success, Fail, RestartButton, OffButton;
    int trueAnswerNumber;
    int questionsSum;
    int health;
    bool isTimerRun;
    public static bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        isTimerRun = true;
        isGameOver = false;
        questionsSum = SpawnQuestions.questionsSum;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        isTimerRun = TapScriptPrefabs.isTimerRun;
        health = TapScriptPrefabs.health;
        if (!isTimerRun || health == 0)
        {
            Fail.SetActive(true);
            RestartButton.SetActive(true);
            OffButton.SetActive(true);
            isGameOver = true;
            GameObject.Find("Fire").GetComponent<AudioSource>().Stop();
            Time.timeScale = 0;
        }

        trueAnswerNumber = SpawnQuestions.trueAnswerNumber;
        if (trueAnswerNumber == questionsSum)
        {
            Success.SetActive(true);
            RestartButton.SetActive(true);
            OffButton.SetActive(true);
            GameObject.Find("Fire").GetComponent<AudioSource>().Stop();
            Time.timeScale = 0;
        }
    }
}
