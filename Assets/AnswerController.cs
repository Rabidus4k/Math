using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class AnswerController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI answerText;
    private int maxLen = 6;
    public GameObject HintText;

    public Image quizimage;
    public string answer;

    private LevelData currentLevel;

    private void OnEnable() => YandexGame.RewardVideoEvent += SkipLevel;

    // Отписываемся от события открытия рекламы в OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= SkipLevel;

    private void Start()
    {
        currentLevel = LevelDataHandler.inst.selectedLevel;
        quizimage.sprite = currentLevel.QuizSprite;
        ChangeCorrectAnswer(currentLevel.Answer);
    }

    public void AddLetter(string letter)
    {
        HintText.SetActive(false);
        if (answerText.text.Length == maxLen)
            return;

        var result = answerText.text + letter;
        answerText.SetText(result);
    }

    public void ResetAnser()
    {
        HintText.SetActive(true);
        answerText.SetText(string.Empty);
    }

    public void SubmitAnswer()
    {
        if (answer == answerText.text)
        {
            FinishLevel();

        }
        else
        {
            Debug.Log("wrong");
        }
    }

    private void FinishLevel()
    {
        //TODO: SAVE PROGRESS;
        Debug.Log("correct");
        LevelDataHandler.inst.NextLevel();
    }

    public void ChangeCorrectAnswer(string ans)
    {
        answer = ans;
    }

    private void SkipLevel(int id)
    {
        if (id == 0)
            FinishLevel();
    }

    public void OnSkipLevel()
    {
        YandexGame.RewVideoShow(0);
    }
}
