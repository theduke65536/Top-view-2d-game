using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Minor script that causes an object to be deleted after some time after instantiation
// Mostly used on effect prefabs
public class SelfDestruct : MonoBehaviour
{
    public float time;


    IEnumerator BeginCountdown() {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }


    private void Start() {
        StartCoroutine(BeginCountdown());
    }
}
