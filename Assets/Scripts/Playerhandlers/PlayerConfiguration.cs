using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerConfiguration : MonoBehaviour
{
    public int playerIndex = 0;
    public int characterSelected = 0;
    public bool isReady = false;

    public PlayerConfigurationUI characterSelectionText;
    public JoinPlayersManually players;

    PlayersManager playerManager;
    private void Start() {
        
    }

    public void Selection( InputAction.CallbackContext context) {
        
        if(context.performed) {
            if(!isReady) {
                characterSelected += int.Parse(context.ReadValue<float>().ToString());
                characterSelected = characterSelected >= players.characters.Count ? 0 : characterSelected < 0 ? players.characters.Count - 1 : characterSelected;
                playerManager.AllPlayers[playerIndex].characterClass = players.characters[characterSelected];
                UIUpdate();
            }
        }
    }

    public void Confirm( InputAction.CallbackContext context) {
        
        if(context.performed) {
            if(isReady) {
                players.GoToWorld();
            } else {
                isReady = true;
                players.SomeoneIsReady();
            }
            
        }
               
    }

    public void Back(InputAction.CallbackContext context) {

        if(context.performed) {
            if(isReady) {
                isReady = false;
                players.SomeoneBacked();
            } else {
                players.BackToPlayerSetup();
            }
            
        }

    }


    public void UIUpdate() {

        if(playerManager != null) {
            characterSelectionText.SetPlayerIndex(playerManager.AllPlayers[playerIndex].playerIndex.ToString());
            characterSelectionText.SetClassName(playerManager.AllPlayers[playerIndex].characterClass);
        } else {
            playerManager = FindObjectOfType<PlayersManager>();
            characterSelectionText.SetPlayerIndex(playerManager.AllPlayers[playerIndex].playerIndex.ToString());
            characterSelectionText.SetClassName(playerManager.AllPlayers[playerIndex].characterClass);
        }
        
    }
}
