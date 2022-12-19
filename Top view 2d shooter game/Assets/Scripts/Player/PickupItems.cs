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

    // Instantiates the gun and sets it's parent the Inventory
    public void PickupGun(Vector3 position, Quaternion rotation, GameObject gunObject) {
        GameObject instantiatedGun = GameObject.Instantiate(gunObject, position, rotation);

        instantiatedGun.transform.parent = transform;
        instantiatedGun.SetActive(false);
    }


    // These methods are called when the player player picks up an item
    public void pickupRocketLauncher() {
        PickupGun(defaultGunInstantiationPosition.position, transform.rotation, rocketLauncherObject);
    }


    public void pickupSniperRifle() {
        PickupGun(defaultGunInstantiationPosition.position, transform.rotation, sniperRifleObject);
    }


    public void pickupSampleGun() {
        PickupGun(defaultGunInstantiationPosition.position, transform.rotation, sampleGunObject);
    }
}
