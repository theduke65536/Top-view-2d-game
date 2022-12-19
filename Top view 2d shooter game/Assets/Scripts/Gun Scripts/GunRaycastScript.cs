using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRaycastScript : MonoBehaviour
{
    public Transform gunBarrelPosition;         // The position that the raycast will be fired from.
    public float damage;                        // Damage dealt by the raycasst
    public GameObject impactEffectBlood;        // Effect on impacting an alive GameObject

    public GameObject impactEffectSpillBlood1;   // Blood that's left on the floor when an enemy has been hit
    public GameObject impactEffectSpillBlood2;

    private void FireRaycast() {
        RaycastHit2D raycastHitInfo = Physics2D.Raycast(gunBarrelPosition.position, gunBarrelPosition.right);

        if (raycastHitInfo) {
            if (raycastHitInfo.transform.gameObject.layer == LayerMask.NameToLayer("Alive")) {
                // Makes the GameObject take damage
                HealthSystemScript healthSystemScript = raycastHitInfo.transform.GetComponent<HealthSystemScript>();
                healthSystemScript.TakeDamage(damage);

                Instantiate(impactEffectBlood, raycastHitInfo.point, Quaternion.identity, raycastHitInfo.transform);

                // Gets a random blood spill effect and instantiates it
                GameObject[] spillBloodEffectArr = new GameObject[] { impactEffectSpillBlood1, impactEffectSpillBlood2 };
                int index = Random.Range(0, spillBloodEffectArr.Length);

                // This is to instantiated it behind everything else.
                Vector3 hitPosition = new Vector3(raycastHitInfo.point.x, raycastHitInfo.point.y, 1);

                Instantiate(spillBloodEffectArr[index], hitPosition, Quaternion.identity);
            }
        }
    }


    private void Update() {
        if (Input.GetButtonDown("Fire1")) {
            FireRaycast();
        }
    }
}
