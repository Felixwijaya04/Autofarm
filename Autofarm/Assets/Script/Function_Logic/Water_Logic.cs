using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//[CreateAssetMenu(fileName = "Water", menuName ="functions/water")]
public class Water : BaseFunction
{
    public InputField inputfield;
    public TMP_InputField textbox;
    public override void Execute()
    {
        Debug.Log("Menyiram");
    }

    public override string GetTextBoxContent()
    {
        return textbox.text;
    }
}
