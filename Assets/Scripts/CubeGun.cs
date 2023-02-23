using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class CubeGun : Gun
{
    private void Start() {
        GunName = "cube";
        Cost = 15;
        Damage = 3;
        printGunInfo();
    }
}
