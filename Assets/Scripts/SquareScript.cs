using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    //Possible colors in shapes
    Color[] colorWheel = {Color.black, Color.blue, Color.red, Color.cyan, Color.clear, Color.green, Color.magenta, Color.white, Color.yellow, Color.gray};
    Renderer m_Renderer;
    public int shiftCount = 0; 

    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShiftColor();
        }
    }

    public Color ReturnColor()
    {
        return m_Renderer.material.color;
    }

    public void ShiftColor()
    {
        Color randColor = colorWheel[Random.Range(0, 9)];
        Debug.Log("The color is: " + randColor);
        m_Renderer.material.color = randColor;
        shiftCount++;
    }
}
