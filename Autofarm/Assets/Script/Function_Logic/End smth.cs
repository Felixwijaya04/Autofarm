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
    private Color itscolor;

    private void Update()
    {
        if (textbox.text == "Loop")
        {
            image.GetComponent<Image>().color = new Color32(207, 130, 40, 255);
        }
        else if (textbox.text == "If")
        {
            image.GetComponent<Image>().color = new Color32(125, 70, 217, 255);
        }
        else
        {
            image.GetComponent<Image>().color = new Color32(207, 82, 52, 255);
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
