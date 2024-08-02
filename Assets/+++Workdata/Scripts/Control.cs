using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    
    // Start is called before the first frame update
    void Start()
    {
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
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
    
    private void WinGame()
    {
        winScreen.SetActive(true);
        // Stop the timer and disable further clicks
        Time.timeScale = 0f;
    }

    private void LoseGame()
    {
        loseScreen.SetActive(true);
        // Stop the timer and disable further clicks
        Time.timeScale = 0f;
    }
}
