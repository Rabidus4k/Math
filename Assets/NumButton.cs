using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumButton : MonoBehaviour
{
    public TMPro.TextMeshProUGUI tmpro;
    public Button button;

    private AnswerController answer;

    private void OnEnable()
    {
        button.onClick.AddListener(OnClick);    
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(OnClick);
    }

    private void Awake()
    {
        answer = FindObjectOfType<AnswerController>();
    }

    public void OnClick()
    {
        answer.AddLetter(tmpro.text);
    }
}
