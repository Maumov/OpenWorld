using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBarController : MonoBehaviour
{
    // Start is called before the first frame update
    public float green, red;
    public Image imageColor;
    public float gap50f = 0.66f, gap25f = 0.33f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHealthColor(float value) {
        if(value > gap50f) {
            red = Mathf.Lerp(1f, 0f, (value - gap50f) / (1f - gap50f));
            green = 1f;
        } else if(value > gap25f) {
            green = Mathf.Lerp(0f, 1f, (value - gap25f) / (gap50f - gap25f));
            red = 1f;
        } else {
            green = 0f;
            red = 1f;
        }
        imageColor.color = new Color(red, green, 0f);

    }
}
