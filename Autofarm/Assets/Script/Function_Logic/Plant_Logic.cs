using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//[CreateAssetMenu(fileName = "Plant", menuName = "functions/plant")]
public class Plant : BaseFunction
{
    public TMP_InputField textbox;
    public override void Execute()
    {
        Debug.Log("Menanam");
    }
    public override string GetTextBoxContent()
    {
        return textbox.text;
    }
}
