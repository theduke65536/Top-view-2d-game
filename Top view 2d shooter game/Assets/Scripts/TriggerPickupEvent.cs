using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// This script is attatched to item triggers that can be picked up by the player
public class TriggerPickupEvent : MonoBehaviour
{
    public UnityEvent equipItem;
    public GameObject thisInstance;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            equipItem.Invoke();

            Destroy(thisInstance);
        }
    }
}
