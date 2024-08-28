using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Endsmth : BaseFunction
{
    public TMP_InputField textbox;
    public override void Execute()
    {
        Debug.Log("End Loop");
    }

    public override string GetTextBoxContent()
    {
        return textbox.text;
    }
}
