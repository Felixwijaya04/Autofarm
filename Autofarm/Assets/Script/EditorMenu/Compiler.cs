using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.IO;

public abstract class BaseFunction : MonoBehaviour
{
    public abstract void Execute();
    public abstract string GetTextBoxContent();
}
public class Compiler : MonoBehaviour
{
    public RectTransform[] codeSlots;
    [SerializeField] private LevelMaker[] levelMaker;
    [HideInInspector]public int levels = 0;

    public void checkAnswer()
    {
        bool allCorrect = true;
        int len = levelMaker[levels].ExpectedFunctions.Count;
        Debug.Log("len"+ len);
        for (int i = 0; i < len; i++)
        {
            BaseFunction attachedFunction = codeSlots[i].GetComponentInChildren<BaseFunction>();
            Debug.Log("Attached Function at slot " + i + ": " + (attachedFunction != null ? attachedFunction.GetType().Name : "null"));
            if (attachedFunction != null)
            {
                if (attachedFunction.GetType() == levelMaker[levels].ExpectedFunctions[i].GetType())
                {
                    string inputText = attachedFunction.GetTextBoxContent();
                    if (levelMaker[levels].ExpectedText[i] == inputText)
                    {
                        Debug.Log("benar text " + levels);
                    }
                    else
                    {
                        Debug.Log("salah text");
                        allCorrect = false;
                    }
                    
                }
                else
                {
                    Debug.Log("salah " + levels);
                    allCorrect = false;
                }
            }
            else
            {
                Debug.Log("incomplete answer " + levels);
                allCorrect = false;
            }
        }

        if (allCorrect)
        {
            levels++;
        }
    }
}
