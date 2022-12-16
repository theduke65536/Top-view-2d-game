using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickupItems : MonoBehaviour
{
    public Transform defaultGunInstantiationPosition;

    public Sprite rocketLauncherSprite;
    public GameObject rocketLauncherObject;

    public void pickupRocketLauncher() {
        Gun equipedRocketLauncher = new Gun(rocketLauncherObject, gameObject);
        equipedRocketLauncher.InstantiateGun(defaultGunInstantiationPosition.position, transform.rotation);
    }
}
