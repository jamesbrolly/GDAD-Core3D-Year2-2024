using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.Rendering; // Use TextMeshPro for UI elements

public class UI_EventListener : MonoBehaviour
{
    
    private UI_Display uiDisplay;

    private void Awake()
    {

    // Get the UI_Display component
        uiDisplay = GetComponent<UI_Display>();

    }
        
    private void OnEnable()
    {
        // Subscribe to UI Events
        UIEventHandler.OnPlayerNameChanged += UpdatePlayerName;
        UIEventHandler.OnPlayerHealthChanged += UpdatePlayerHealth;
        UIEventHandler.OnScoreChanged += UpdateScore;
    }
    
    
    private void OnDisable()
    {
        // Unsubscribe from UI Events
        UIEventHandler.OnPlayerNameChanged -= UpdatePlayerName;
        UIEventHandler.OnPlayerHealthChanged -= UpdatePlayerHealth;
        UIEventHandler.OnScoreChanged -= UpdateScore;
    }

    
    //Update the player name in the UI
    private void UpdatePlayerName(string playerName)
    {
        if(uiDisplay != null)
        {
            uiDisplay.UpdatePlayerName(playerName);
        }

    }

    //Update the player health in the UI
    private void UpdatePlayerHealth(int playerHealth)
    {
        if(uiDisplay != null)
        {
            uiDisplay.UpdatePlayerHealth(playerHealth);
        }
    }

    //Update the score in the UI
    private void UpdateScore(int score)
    {
        if(uiDisplay != null)
        {
            uiDisplay.UpdateScore(score);
        }
    }


}
