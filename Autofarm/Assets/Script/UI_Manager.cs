using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public Compiler compiler;
    public GameObject[] panel;
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
    }
}
