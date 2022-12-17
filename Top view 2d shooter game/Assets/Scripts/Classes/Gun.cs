using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class representing a gun that can be picked up by the player
public class Gun
{
    public GameObject gunObject;    // The gun object itself
    public Sprite sprite;           // Sprite of the gun
    public GameObject parent;       // The parent of the gun (often the player's inventory)


    public Gun(GameObject _gunObject, GameObject _parent) {
        parent = _parent;
        gunObject = _gunObject;
    }

    // Equips the gun once they player picks it up
    public GameObject InstantiateGun(Vector3 position, Quaternion rotation) {
        GameObject instantiatedGun = GameObject.Instantiate(gunObject, position, rotation);

        instantiatedGun.transform.parent = parent.transform;
        instantiatedGun.SetActive(false);

        return instantiatedGun;
    }
}
