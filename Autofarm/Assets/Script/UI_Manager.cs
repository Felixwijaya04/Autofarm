using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Compiler compiler;
    public GameObject[] panel;
    public GameObject compileBtn;
    private int levelBefore;

    private void Start()
    {
        levelBefore = compiler.levels;
    }
    public void compileCode()
    {
        //Debug.Log("ui: " + compiler.levels);
        compiler.checkAnswer();
    }
    private void Update()
    {
        if(levelBefore < compiler.levels)
        {
            panel[(compiler.levels) -1].SetActive(false);
            levelBefore = compiler.levels;
        }
        panel[compiler.levels].SetActive(true);
        if(compiler.levels >= compiler.maxLevels)
        {
            compileBtn.SetActive(false);
            panel[compiler.levels].SetActive(true);
        }
    }

    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
