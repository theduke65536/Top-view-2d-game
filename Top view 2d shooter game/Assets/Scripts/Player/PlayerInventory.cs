using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private List<GameObject> Weapons = new List<GameObject>();

    IEnumerator CheckInventoryChanges() {
        while (true) {
            foreach (Transform child in transform) {
                if (!Weapons.Contains(child.gameObject)) {
                    Weapons.Add(child.gameObject);
                }
            }

            yield return new WaitForSeconds(0.1f);
        }
    }


    private void setSiblingsInactive(GameObject GameObjNotToUnactivate) {
        foreach(GameObject sibling in Weapons) {
            if (sibling != GameObjNotToUnactivate) {
                sibling.SetActive(false);
            }
        }
    }


    private void Start() {
        StartCoroutine(CheckInventoryChanges());
    }


    private void Update() {
        print(Weapons.Count);

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            Weapons[0].SetActive(!Weapons[0].activeSelf);
            setSiblingsInactive(Weapons[0]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            Weapons[1].SetActive(!Weapons[1].activeSelf);
            setSiblingsInactive(Weapons[1]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            Weapons[2].SetActive(!Weapons[2].activeSelf);
            setSiblingsInactive(Weapons[2]);
        }
    }
}
