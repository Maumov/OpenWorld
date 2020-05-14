using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerConfigurationUI : MonoBehaviour
{
    public Text playerIndex;
    public Text className;
    public Text ready;
    public void SetClassName(string value) {
        className.text = value;
    }

    public void SetPlayerIndex(string value) {
        playerIndex.text = value;
    }
    public void SetPlayerReady(bool value) {
        ready.gameObject.SetActive(value);
    }
}
