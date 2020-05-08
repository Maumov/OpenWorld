using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersManager : MonoBehaviour
{
    public List<PlayerSetup> AllPlayers;

    private void Awake() {
        AllPlayers = new List<PlayerSetup>();
    }
    private void Start() {
        DontDestroyOnLoad(gameObject);
    }

    public void AddNewPlayer(PlayerSetup newPlayer) {
        AllPlayers.Add(newPlayer);
        Debug.Log("Player added");
    }
}


[System.Serializable]
public class PlayerSetup
{
    public int playerIndex;
    public string characterName;
    public string characterClass;
}
