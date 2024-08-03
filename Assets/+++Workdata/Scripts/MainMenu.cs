using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    #region Declaration

    [Header("MainMenuPanels")]
    public GameObject mainMenuPanel;
    public GameObject creditsPanel;

    #endregion
    
    
    // Start is called before the first frame update
    void Start()
    {
        //set to visible
        mainMenuPanel.SetActive(true);
        //set to invisible
        creditsPanel.SetActive(false);
    }

    // Start Game Button
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenCreditsPanel()
    {
        creditsPanel.SetActive(true);
    }

    public void CloseCreditsPanel()
    {
        creditsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
    
    // Quit Game Button
    public void QuitGame()
    {
        Application.Quit(); // Quit game
        Debug.Log("Quited Game");
    }
}
