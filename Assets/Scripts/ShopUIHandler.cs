using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShopUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Button cubeButton, capsuleButton, sphereButton;
    public CubeGun cubeGun;
    public CapsuleGun capsuleGun;
    public SphereGun sphereGun;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI gunInfoText;

    private void Start() 
    {
        nameText.text = "Welcome, " + MenuUIHandler.Instance.playerName;
        cubeButton.onClick.AddListener(delegate {ChooseGun(cubeGun); });
        capsuleButton.onClick.AddListener(delegate {ChooseGun(capsuleGun); });
        sphereButton.onClick.AddListener(delegate {ChooseGun(sphereGun); });
    }

    //ABSTRACTION
    private void ChooseGun(Gun gunObject)
    {
        gunObject.printGunInfo();
        gunInfoText.text = gunObject.GunName + " DMG: " + gunObject.Damage + " Cost: " + gunObject.Cost;
    }

    

}
