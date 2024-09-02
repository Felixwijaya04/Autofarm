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
    [SerializeField] public LevelMaker[] levelMaker;
    [HideInInspector] public int levels = 0;
    [HideInInspector] public int maxLevels;

   
    public Animator animator;

    private void Start()
    {
        maxLevels = levelMaker.Length;
        Debug.Log("MaxLevel: " + maxLevels);
    }

    public void checkAnswer()
    {
        if (levels < maxLevels)
        {
            bool allCorrect = true;
            int len = levelMaker[levels].ExpectedFunctions.Count;
            Debug.Log("len" + len);
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
                            Debug.Log("Output Wrong");
                            allCorrect = false;
                            break;
                        }
                    }
                    else
                    {
                        Debug.Log("Output Wrong" + levels);
                        allCorrect = false;
                        break;
                    }
                }
                else
                {
                    Debug.Log("Output Wrong" + levels);
                    allCorrect = false;
                    break;
                }
            }

            if (allCorrect)
            {
                levels++;
                Debug.Log("Going next level is " + levels);
            }
            else
            {
                
                animator.SetBool("isSubmitWrong", true);
                StartCoroutine(ResetAnimation());
            }
        }
        else
        {
            Debug.Log("You have finished all levels");
        }
    }

  
    private IEnumerator ResetAnimation()
    {
        yield return new WaitForSeconds(2f);
        animator.SetBool("isSubmitWrong", false);
    }
}
