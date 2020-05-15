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
    public float confirmButtonPressed;
    public float backButtonPressed;
    public PlayerConfigurationUI characterSelectionText;
    public JoinPlayersManually players;

    public PlayersManager playerManager;
    bool isInstantiated;
    
    private void Start() {
        isInstantiated = true;
    }

    public void Selection( InputAction.CallbackContext context) {
        if(!isInstantiated) {
            return;
        }
        if(context.performed) {
            if(!isReady) {
                UIUpdate();
                characterSelected += int.Parse(context.ReadValue<float>().ToString());
                Debug.Log(gameObject.name);
                Debug.Log(characterSelected);
                characterSelected = characterSelected >= players.characters.Count ? 0 : characterSelected < 0 ? players.characters.Count - 1 : characterSelected;
                playerManager.AllPlayers[playerIndex].characterClass = players.characters[characterSelected];
                UIUpdate();
                
            }
            
        }
    }

    public void Confirm( InputAction.CallbackContext context) {
        if(!isInstantiated) {
            return;
        }
        if(context.performed) {
            confirmButtonPressed = context.ReadValue<float>();
            if(confirmButtonPressed >= 0.5f) {
                if(isReady) {
                    players.GoToWorld();
                } else {
                    isReady = true;
                    players.SomeoneIsReady();
                }
                characterSelectionText.SetPlayerReady(isReady);
            }
        }
               
    }

    public void Back(InputAction.CallbackContext context) {

        if(context.performed) {
            backButtonPressed = context.ReadValue<float>();
            if(backButtonPressed >= 0.5f) {
                if(isReady) {
                    isReady = false;
                    players.SomeoneBacked();
                } else {
                    players.BackToPlayerSetup();
                }
                characterSelectionText.SetPlayerReady(isReady);
            }
        }

    }


    public void UIUpdate() {

        if(playerManager != null) {
            if(characterSelectionText != null) {
                characterSelectionText.SetPlayerIndex(playerManager.AllPlayers[playerIndex].playerIndex.ToString());
                characterSelectionText.SetClassName(playerManager.AllPlayers[playerIndex].characterClass);
            }
        } else {
            playerManager = FindObjectOfType<PlayersManager>();
            if(characterSelectionText != null) {
                characterSelectionText.SetPlayerIndex(playerManager.AllPlayers[playerIndex].playerIndex.ToString());
                characterSelectionText.SetClassName(playerManager.AllPlayers[playerIndex].characterClass);
            }
        }
        
    }
}
