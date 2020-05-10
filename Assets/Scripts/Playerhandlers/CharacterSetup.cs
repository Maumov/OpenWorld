using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterSetup : MonoBehaviour
{
    public List<GameObject> characters;
    public CharacterMovement[] characterMovements;
    public void SetupCharacter(PlayerSetup playerSetup, Transform spawnPos) {
        transform.position = spawnPos.position;
        transform.rotation = spawnPos.rotation;

        string characterClass = playerSetup.characterClass;
        PlayerInput playerInput;
        foreach(CharacterMovement c in characterMovements) {
            c.enabled = false;
        }      
        
        switch(characterClass) {
            case "Warrior":
            playerInput = GetComponent<PlayerInput>();
            playerInput.SwitchCurrentActionMap("Warrior");
            characters[0].SetActive(true);
            characterMovements[0].enabled = true;
            //playerInput.GetComponent<Warrior>().anim = playerInput.GetComponentInChildren<Animator>();
            characterMovements[0].anim = playerInput.GetComponentInChildren<Animator>();
            break;
            case "Rogue":
            characters[1].SetActive(true);
            break;
            case "Hunter":
            characters[2].SetActive(true);
            break;
            case "Paladin":
            characters[3].SetActive(true);
            break;
            case "Druid":
            characters[4].SetActive(true);
            break;
            case "Fire Mage":
            playerInput = GetComponent<PlayerInput>();
            playerInput.SwitchCurrentActionMap("Fire Mage");
            characters[5].SetActive(true);
            characterMovements[5].enabled = true;
            //playerInput.GetComponent<FireMage>().anim = playerInput.GetComponentInChildren<Animator>();
            characterMovements[5].anim = playerInput.GetComponentInChildren<Animator>();
            break;
            case "Frost Mage":
            characters[6].SetActive(true);
            break;
            case "Warlock":
            characters[7].SetActive(true);
            break;
            case "Priest":
            characters[8].SetActive(true);
            break;
        }

        SetUI(playerSetup.playerIndex);

    }
    void SetUI(int index) {
        PlayerUIStatsController[] playerUIs = FindObjectsOfType<PlayerUIStatsController>();
        foreach(PlayerUIStatsController ui in playerUIs) {
            if(ui.playerIndex == index) {
                ui.SetStats(GetComponent<Stats>());
            }
        }
    }
}
