using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Loop : BaseFunction
{
    public TMP_InputField textbox;
    public override void Execute()
    {
        Debug.Log("Looping");
    }

    public override string GetTextBoxContent()
    {
        return textbox.text;
    }
}
