using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Endsmth : BaseFunction
{
    public TMP_InputField textbox;
    /*SpriteRenderer sprite;*/
    public Image image;
    public Sprite end;
    public Sprite endLoop;
    public Sprite endIf;

    private void Update()
    {
        if (textbox.text == "Loop")
        {
            //image.GetComponent<Image>().color = new Color32(207, 130, 40, 255);
            image.sprite = endLoop;
        }
        else if (textbox.text == "If")
        {
            //image.GetComponent<Image>().color = new Color32(125, 70, 217, 255);
            image.sprite = endIf;
        }
        else
        {
            //image.GetComponent<Image>().color = new Color32(207, 82, 52, 255);
            image.sprite= end;
        }
    }
    public override void Execute()
    {
        Debug.Log("End Loop");
    }

    public override string GetTextBoxContent()
    {
        return textbox.text;
    }
}
