using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{


    protected override void DisplayText()
    {
        base.DisplayText();
        UIManager.Instance.tMP_Text.text += "\nI'm squarin'";
    }

}
