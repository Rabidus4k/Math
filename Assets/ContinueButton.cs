using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    private Button button;
    private LevelDataHandler levelDataHandler;
    private void Awake()
    {
        button = GetComponent<Button>();
        levelDataHandler = FindObjectOfType<LevelDataHandler>();
    }

    private void OnEnable()
    {
        button.onClick.AddListener(Continue);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(Continue);
    }

    private void Continue()
    {
        levelDataHandler.ContinueGame();
    }
}
