using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Lets the player pick up weapons. Attatched to 'Inventory'
public class PickupItems : MonoBehaviour
{
    public Transform defaultGunInstantiationPosition; // Position where the gun will be rendered

    // Prefab of each gun
    public GameObject rocketLauncherObject;
    public GameObject sniperRifleObject;
    public GameObject sampleGunObject;
    public GameObject handgunObject;
    public GameObject assaultrifleObject;
    public GameObject shotgunObject;

    // Instantiates the gun and sets it's parent the Inventory
    public void PickupGun(GameObject gunObject)
    {

        GameObject instantiatedGun = GameObject.Instantiate(gunObject, defaultGunInstantiationPosition.position, transform.rotation);

        instantiatedGun.transform.parent = transform;
        instantiatedGun.SetActive(false);
    }


    // These methods are called when the player player picks up an item
    public void pickupRocketLauncher() {
        PickupGun(rocketLauncherObject);
    }


    public void pickupSniperRifle() {
        PickupGun(sniperRifleObject);
    }


    public void pickupSampleGun() {
        PickupGun(sampleGunObject);
    }


    public void pickupHandgun() {
        PickupGun(handgunObject);
    }


    public void pickupAssaultRifle() {
        PickupGun(assaultrifleObject);
    }


    public void pickupShotgun() {
        PickupGun(shotgunObject);
    }
}
