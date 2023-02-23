using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class CapsuleGun : Gun
{
    private void Start() {
        GunName = "capsule";
        Cost = 10;
        Damage = 2;
        printGunInfo();
    }
}
