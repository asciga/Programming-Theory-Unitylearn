using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class SphereGun : Gun
{

    //POLYMORPHISM
    public override void printGunInfo()
    {
        Debug.Log("Gun name: " + GunName + " Cost: " + Cost + " Damage: " + Damage);
        Debug.Log("But this gun is also cooler cause it's round.");
    }

    private void Start() {
        GunName = "sphere";
        Cost = 5;
        Damage = 1;
        printGunInfo();
    }
    
    
}
