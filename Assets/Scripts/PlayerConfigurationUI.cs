using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerConfigurationUI : MonoBehaviour
{
    public Text playerIndex;
    public Text className;
    
    public void SetClassName(string value) {
        className.text = value;
    }

    public void SetPlayerIndex(string value) {
        playerIndex.text = value;
    }
}
