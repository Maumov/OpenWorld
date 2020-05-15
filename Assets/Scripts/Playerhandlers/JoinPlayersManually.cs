using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class JoinPlayersManually : MonoBehaviour
{
    public static int amountOfPlayers = 0;
    public PlayerInputManager playerInputManager;

    public List<PlayerConfigurationUI> playerUI;
    public List<PlayerConfiguration> players;

    public Text EveryoneIsReadyUI;
    public List<string> characters;

    // Start is called before the first frame update
    void Start(){
        players = new List<PlayerConfiguration>();
        StartCoroutine(CreatePlayers());
        EveryoneIsReadyUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CreatePlayers() {

        for(int i = 0; i< amountOfPlayers; i++) {
            AddPlayer();
            yield return null;
        }

        yield return null;
    }

    [ContextMenu("Add player")]
    public void AddPlayer() {
        playerInputManager.JoinPlayer();
    }

    public void SomeoneIsReady() {
        if(CheckForAllPlayersReady()) {
            EveryoneIsReadyUI.gameObject.SetActive(true);
            Debug.Log("Show Go to World UI");
        }
    }
    public void GoToWorld() {
        if(CheckForAllPlayersReady()) {

            Debug.Log("Go To World !");
            SceneManager.LoadScene("World");
        } 
    }
    public void SomeoneBacked() {
        EveryoneIsReadyUI.gameObject.SetActive(false);
        Debug.Log("Hide Go to World UI");
    }
    public void BackToPlayerSetup() {
        Debug.Log("Go back to Player setup !");
        
    }

    bool CheckForAllPlayersReady() {
        foreach(PlayerConfiguration pc in players) {
            if(!pc.isReady) {
                return false;
            }
        }
        return true;
    }


    public void OnPlayerJoined(PlayerInput playerInput) {
        int playerIndex = playerInput.playerIndex;
        PlayerConfiguration pc = playerInput.GetComponent<PlayerConfiguration>();

        PlayerSetup newPlayer = new PlayerSetup();
        newPlayer.characterClass = characters[0];
        newPlayer.characterName = "";
        newPlayer.playerIndex = playerIndex;
        newPlayer.controller = playerInput.currentControlScheme;
        FindObjectOfType<PlayersManager>().AddNewPlayer(newPlayer);
        pc.characterSelectionText = playerUI[playerIndex];
        pc.playerIndex = playerIndex;
        pc.players = this;
        players.Add(pc);
        pc.UIUpdate();
    }


}
