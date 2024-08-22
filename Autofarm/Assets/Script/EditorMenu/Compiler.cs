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
    public List<BaseFunction> ExpectedFunctions;

    public void checkAnswer()
    {
        for(int i=0;i<codeSlots.Length; i++)
        {
            BaseFunction attachedFunction = codeSlots[i].GetComponentInChildren<BaseFunction>();
            if(attachedFunction != null)
            {
                if (attachedFunction.GetType() == ExpectedFunctions[i].GetType())
                {
                    Debug.Log("benar");
                }
                else
                {
                    Debug.Log("salah");
                }
            }
            else
            {
                Debug.Log("incomplete answer");
            }
        }
    }
}
