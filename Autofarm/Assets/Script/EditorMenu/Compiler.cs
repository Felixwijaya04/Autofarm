using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseFunction : MonoBehaviour
{
    public abstract void Execute();
}
public class Compiler : MonoBehaviour
{
    public RectTransform[] codeSlots;
    [SerializeField] private LevelMaker[] levelMaker;
    public int levels = 0;
    //private bool NextLevel = false;

    public void checkAnswer()
    {
        /*for(int i=0;i<codeSlots.Length; i++)
        {
            BaseFunction attachedFunction = codeSlots[i].GetComponentInChildren<BaseFunction>();
            if(attachedFunction != null)
            {
                if (attachedFunction.GetType() == levelMaker[levels].ExpectedFunctions[i].GetType())
                {
                    Debug.Log("benar " + levels);
                    NextLevel = true;
                }
                else
                {
                    Debug.Log("salah " + levels);
                    NextLevel = false;
                }
            }
            else
            {
                Debug.Log("incomplete answer " + levels);
                NextLevel = false;
            }
        }
        if(NextLevel == true)
        {
            levels++;
        }*/
        bool allCorrect = true;

        for (int i = 0; i < codeSlots.Length; i++)
        {
            BaseFunction attachedFunction = codeSlots[i].GetComponentInChildren<BaseFunction>();
            if (attachedFunction != null)
            {
                if (attachedFunction.GetType() == levelMaker[levels].ExpectedFunctions[i].GetType())
                {
                    Debug.Log("benar " + levels);
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
