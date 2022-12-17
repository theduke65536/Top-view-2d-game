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

    // These methods are called when the player player picks up an item
    public void pickupRocketLauncher() {
        Gun equipedRocketLauncher = new Gun(rocketLauncherObject, gameObject);
        equipedRocketLauncher.InstantiateGun(defaultGunInstantiationPosition.position, transform.rotation);
    }


    public void pickupSniperRifle() {
        Gun equipedSniperRifle = new Gun(sniperRifleObject, gameObject);
        equipedSniperRifle.InstantiateGun(defaultGunInstantiationPosition.position, transform.rotation);
    }


    public void pickupSampleGun() {
        Gun equipedSampleGun = new Gun(sampleGunObject, gameObject);
        equipedSampleGun.InstantiateGun(defaultGunInstantiationPosition.position, transform.rotation);
    }
}
