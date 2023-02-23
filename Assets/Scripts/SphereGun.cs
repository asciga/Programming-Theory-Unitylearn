using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGun : Gun
{
    private void Start() {
        GunName = "sphere";
        Cost = 5;
        Damage = 1;
        printGunInfo();
    }
    
    
}
