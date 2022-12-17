using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickupItems : MonoBehaviour
{
    public Transform defaultGunInstantiationPosition;

    public GameObject rocketLauncherObject;
    public GameObject sniperRifleObject;


    public void pickupRocketLauncher() {
        Gun equipedRocketLauncher = new Gun(rocketLauncherObject, gameObject);
        equipedRocketLauncher.InstantiateGun(defaultGunInstantiationPosition.position, transform.rotation);
    }


    public void pickupSniperRifle() {
        Gun equipedRocketLauncher = new Gun(sniperRifleObject, gameObject);
        equipedRocketLauncher.InstantiateGun(defaultGunInstantiationPosition.position, transform.rotation);
    }
}
