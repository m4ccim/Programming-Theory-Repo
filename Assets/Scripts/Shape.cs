using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{ 
    
    void Start()
    {
        Name = name;
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private string name1;
    public Color color;

    // ENCAPSULATION
    protected string Name { get => name1; set => name1 = value; }
    public Color Color { get => color; set => color = value; }


    // ABSTRACTION
    protected virtual void DisplayText()
    {
        UIManager.Instance.tMP_Text.text = $"Hi, I'm {Name} of {Color} color!";
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    private void OnMouseExit()
    {
        UIManager.Instance.tMP_Text.text = "Shape?";
    }
}
