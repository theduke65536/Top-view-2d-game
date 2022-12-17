using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script attatched to the 'Inventory' child of Player. Manages the inventory.
public class PlayerInventoryScript : MonoBehaviour
{
    private List<GameObject> Weapons = new List<GameObject>(); // List that holds the items in the player's inventory.

    // Only checks inventory spaces periodically to save a bit of processing power.
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

    // When the player equips an item in their inventory the other items are set inactive
    // To prevent the player holding multiple items at once
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
        // These if statements allow the player to equip different items in the inventory.
        // The exact same way as the Minecraft hotbar system.
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
