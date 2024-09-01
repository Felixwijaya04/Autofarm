using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public Compiler compiler;
    public void compileCode()
    {
        //Debug.Log("ui: " + compiler.levels);
        compiler.checkAnswer();
    }
    private void Update()
    {
        
    }
}
