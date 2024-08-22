using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public Compiler compiler;

    public void compileCode()
    {
        compiler.checkAnswer();
    }
}
