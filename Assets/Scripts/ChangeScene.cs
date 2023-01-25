using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }

    public void ChangeScenes()
    {
        SceneManager.LoadScene("Question");
    }

    public void RestartScenes()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        SceneManager.LoadScene("Opening");
    }
}
