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
        mainMenuPanel.SetActive(true); // Sets panel visible
        creditsPanel.SetActive(false); // Sets panel invisible
    }

    // Start Game Button
    public void StartGame()
    {
        AudioManager.Instance.PlaySFX("Click");
        SceneManager.LoadScene("Explain"); // Loads level 1
    }

    // Open Credits Panel
    public void OpenCreditsPanel()
    {
        AudioManager.Instance.PlaySFX("Click");
        creditsPanel.SetActive(true); // Sets panel visible
    }

    // Close Credits Panel
    public void CloseCreditsPanel()
    {
        AudioManager.Instance.PlaySFX("Click");
        creditsPanel.SetActive(false); // Sets panel invisible
        mainMenuPanel.SetActive(true); // Sets panel visible
    }
    
    // Quit Game Button
    public void QuitGame()
    {
        AudioManager.Instance.PlaySFX("Click");
        Application.Quit(); // Quit game
        Debug.Log("Quited Game"); // Debug log to check if code is executing
    }
}
