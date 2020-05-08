using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissilePyroblast : Missile
{
    public float acceleration = 2f;
    public override void Update() {
        movementSpeed += (acceleration * Time.deltaTime);
        base.Update();
    }
}
