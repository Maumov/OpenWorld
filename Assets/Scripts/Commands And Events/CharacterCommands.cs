using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCommands : MonoBehaviour
{
    protected Animator anim;
    // Start is called before the first frame update
    public virtual void Start()
    {
        anim = GetComponent<Animator>();
    }

   
}
