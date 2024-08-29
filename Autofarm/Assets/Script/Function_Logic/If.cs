using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class If : BaseFunction
{
    public TMP_InputField textbox;
    public override void Execute()
    {
        Debug.Log("If smth");
    }

    public override string GetTextBoxContent()
    {
        return textbox.text;
    }
}
