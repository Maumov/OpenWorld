using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnPlayersTest : MonoBehaviour
{
    public Transform[] spawnPositions ;
    //public PlayersManager playersManager;
    public PlayerInputManager playerInputManager;
    public PlayerSetup playerToSpawn;

    public PlayersManager players;
    // Start is called before the first frame update
    void Start() {
        players = FindObjectOfType<PlayersManager>();
        if(players != null) {
            StartCoroutine(CreatePlayers());
        } else {
            AddPlayer();
        }
        
    }
    IEnumerator CreatePlayers() {
        for(int i = 0; i< players.AllPlayers.Count; i++) {
            AddPlayer(i);
            yield return null;
        }
    }

    [ContextMenu("Add player")]
    public void AddPlayer(int count) {
        //playerInputManager.JoinPlayer();
        playerInputManager.JoinPlayer(players.AllPlayers[count].playerIndex, -1, players.AllPlayers[count].controller);
    }
    public void AddPlayer() {
        playerInputManager.JoinPlayer();
        
    }
    public void OnPlayerJoined(PlayerInput playerInput) {
        if(players != null) {
            CharacterSetup cs = playerInput.GetComponent<CharacterSetup>();
            cs.SetupCharacter(players.AllPlayers[playerInput.playerIndex], spawnPositions[playerInput.playerIndex]);
        } else {
            CharacterSetup cs = playerInput.GetComponent<CharacterSetup>();
            cs.SetupCharacter(playerToSpawn, spawnPositions[0]);
        }
        

    }
}
