using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    private Control gameController;
    
    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<Control>();
    }

    private void OnMouseDown()
    {
        gameController.OnObjectClicked(gameObject);
        AudioManager.Instance.PlaySFX("Found");
    }
}
