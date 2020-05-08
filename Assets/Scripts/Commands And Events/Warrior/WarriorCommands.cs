using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WarriorCommands : CharacterCommands 
{
    
    public float specialButton;
    

    public void SpecialButton(InputAction.CallbackContext context) {
        if(context.performed) {
            specialButton = context.ReadValue<float>();
            if(specialButton >= 0.5f) {
                Debug.Log("Special button");
            }
        }
    }

}
