using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDataHandler : MonoBehaviour
{
    public static LevelDataHandler inst;
    public List<LevelData> Levels = new List<LevelData>();

    public LevelData selectedLevel;

    private void Awake()
    {
        if (inst == null)
            inst = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }


    private int selectedLevelIndex = 0;

    public void SelectLevel(int index) 
    {
        selectedLevelIndex = index;
        selectedLevel = Levels[index];
        SceneManager.LoadScene(1);
    }

    public void NextLevel()
    {
        var newIndex = selectedLevelIndex + 1;
        if (newIndex >= Levels.Count)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SelectLevel(newIndex);
        }
    }
}
