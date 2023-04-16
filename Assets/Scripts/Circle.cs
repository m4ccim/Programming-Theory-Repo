using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Circle : Shape
{
    // POLYMORPHISM
    protected override void DisplayText()
    {
        base.DisplayText();
        UIManager.Instance.tMP_Text.text += "\nI'm ballin'";
    }

}
