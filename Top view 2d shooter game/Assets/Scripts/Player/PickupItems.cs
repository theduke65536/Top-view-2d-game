using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickupItems : MonoBehaviour
{
    public Transform defaultGunInstantiationPosition;

    public GameObject rocketLauncherObject;
    public GameObject sniperRifleObject;
    public GameObject sampleGunObject;


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
