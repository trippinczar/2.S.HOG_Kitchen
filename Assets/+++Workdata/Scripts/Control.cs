using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    [Header("Objects and Texts")]
    public List<GameObject> objects;
    public List<GameObject> objectTexts;

    [Header("UI Elements")]
    public GameObject winScreen;
    public GameObject loseScreen;

    private int objectsFound = 0;
    private Timer timerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
        Time.timeScale = 1f;

        timerScript = FindObjectOfType<Timer>(); // Link to Timer script
        timerScript.ResetTimer(); // Resets timer so upon reloading the scene the timer works
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnObjectClicked(GameObject obj)
    {
        int index = objects.IndexOf(obj);
        if (index != -1)
        {
            objects[index].SetActive(false);
            objectTexts[index].SetActive(false);
            objectsFound++;

            if (objectsFound == objects.Count)
            {
                WinGame();
            }
        }
    }
    
    public void WinGame()
    {
        winScreen.SetActive(true);
        // Stop the timer and disable further clicks
        Time.timeScale = 0f;
    }

    public void LoseGame()
    {
        loseScreen.SetActive(true);
        // Stop the timer and disable further clicks
        Time.timeScale = 0f;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void Continue()
    {
        SceneManager.LoadScene("Level1");
    }
}
