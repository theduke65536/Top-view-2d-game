using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerPickupEvent : MonoBehaviour
{
    public UnityEvent equipItem;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            equipItem.Invoke();
        }
    }
}