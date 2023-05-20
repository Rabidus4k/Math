using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level")]
public class LevelData : ScriptableObject
{
    public int Index;
    public string Answer;
    public Sprite QuizSprite;
}
