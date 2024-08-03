using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] private float initialTime;
    private float remainingTime;
    private Control controlScript;
    
    // Start is called before the first frame update
    void Start()
    {
        controlScript = FindObjectOfType<Control>();
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        Countdown();
    }

    void Countdown()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            controlScript.LoseGame();
        }
        
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void ResetTimer()
    {
        remainingTime = initialTime; // Initialize remainingTime with initialTime
    }
}
