using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    [SerializeField]
    private string startScene = "01_Tutorial";

    [SerializeField]
    private string settingsScene = "M2_Settings";

    [SerializeField]
    private string creditScene = "M3_Credits";

    [SerializeField]
    private string scoreScene = "M4_Score";

    public void OnStart()
    {
        Debug.Log("Start Game");
        SceneManager.LoadScene(startScene);
    }

    public void OnSettings()
    {
        SceneManager.LoadScene(settingsScene);
    }

    public void OnCredits()
    {
        SceneManager.LoadScene(creditScene);
    }

    public void OnScore()
    {
        SceneManager.LoadScene(scoreScene);
    }
}
