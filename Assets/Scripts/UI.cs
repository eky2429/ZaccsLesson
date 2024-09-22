using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int numClicks = 0;
    private string clicksText = "# of clicks: ";

    // Start is called before the first frame update
    void Start()
    {
        text.SetText(clicksText + numClicks.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateNumClicks()
    {
        numClicks++;
        text.SetText(clicksText + numClicks.ToString());
    }
}
