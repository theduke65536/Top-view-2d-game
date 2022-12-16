using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun
{
    public GameObject gunObject;
    public Sprite sprite;
    public GameObject parent;


    public Gun( GameObject _gunObject, GameObject _parent) {
        parent = _parent;
        gunObject = _gunObject;
    }


    public GameObject InstantiateGun(Vector3 position, Quaternion rotation) {
        GameObject instantiatedGun = GameObject.Instantiate(gunObject, position, rotation);

        instantiatedGun.transform.parent = parent.transform;

        return instantiatedGun;
    }
}
