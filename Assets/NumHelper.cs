using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class NumHelper : MonoBehaviour
{
    private LevelDataHandler LevelDataHandler;
    public TMPro.TextMeshProUGUI text;

    public int Index;
    private void Awake()
    {
        Init();
    }

    [ContextMenu("Init")]
    private void Init()
    {
        LevelDataHandler = FindObjectOfType<LevelDataHandler>();
        Index = int.Parse(Regex.Match(gameObject.name, @"\d+").Value);
        text.SetText((Index + 1).ToString());
    }

    public void SelectLevel()
    {
        LevelDataHandler.SelectLevel(Index);
    }

}
