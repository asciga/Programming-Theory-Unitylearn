using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    //ENCAPSULATION
    public string GunName { get; set; }
    public int Cost {get; set;}
    public int Damage {get; set;}

        //POLYMORPHISM
    public virtual void printGunInfo()
    {
        Debug.Log("Gun name: " + GunName + " Cost: " + Cost + " Damage: " + Damage);
    }

}



