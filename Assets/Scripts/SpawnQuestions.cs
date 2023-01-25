using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnQuestions : MonoBehaviour
{
    public GameObject[] questionPrefabs;
    public static int questionsSum;
    public static List<GameObject> activeQuestions;
    bool trueAnswer;
    bool isGameOver;
    public static int trueAnswerNumber;
    // Start is called before the first frame update
    void Start()
    {
        questionsSum = questionPrefabs.Length;
        trueAnswerNumber = 0;
        activeQuestions = new List<GameObject>();
        SpawnQuestion(trueAnswerNumber);
    }

    // Update is called once per frame
    void Update()
    {
        trueAnswer = TapScriptPrefabs.trueAnswer;
        isGameOver = GameOver.isGameOver;
        if (trueAnswer)
        {
            trueAnswerNumber++;
            DeleteQuestion();
            if (trueAnswerNumber < questionsSum)
            {
                SpawnQuestion(trueAnswerNumber);
            }
            trueAnswer = false;
        }
        if (isGameOver)
        {
            Destroy(activeQuestions[0]);
        }
    }

    public void SpawnQuestion(int questionIndex)
    {
        GameObject go = Instantiate(questionPrefabs[questionIndex]) as GameObject;
        go.transform.SetParent(GameObject.FindGameObjectWithTag("canvas").transform, false);
        activeQuestions.Add(go);
    }

    private void DeleteQuestion()
    {
        Destroy(activeQuestions[0]);
        activeQuestions.RemoveAt(0);
    }
}
