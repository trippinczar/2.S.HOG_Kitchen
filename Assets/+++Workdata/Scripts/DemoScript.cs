using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoScript : MonoBehaviour
{
    public void MainMenu()
    {
        AudioManager.Instance.PlaySFX("Click");
        Debug.Log("button pressed");
        SceneManager.LoadScene("MainMenu");
    }
}
