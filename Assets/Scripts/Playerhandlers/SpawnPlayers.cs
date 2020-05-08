using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnPlayers : MonoBehaviour
{
    public List<Transform> spawnPositions;
    public PlayersManager playersManager;
    public PlayerInputManager playerInputManager;
    // Start is called before the first frame update
    void Start()
    {
        playersManager = FindObjectOfType<PlayersManager>();
        StartCoroutine(CreatePlayers());
    }
    IEnumerator CreatePlayers() {
        for(int i = 0; i < playersManager.AllPlayers.Count; i++) {
            AddPlayer();
            yield return null;
        }

        yield return null;
    }

    [ContextMenu("Add player")]
    public void AddPlayer() {
        playerInputManager.JoinPlayer();
    }
    void OnPlayerJoined(PlayerInput playerInput) {
        int playerIndex = playerInput.playerIndex;
        CharacterSetup cs = playerInput.GetComponent<CharacterSetup>();
        cs.SetupCharacter(playersManager.AllPlayers[playerIndex], spawnPositions[playerIndex]);
    }

}
