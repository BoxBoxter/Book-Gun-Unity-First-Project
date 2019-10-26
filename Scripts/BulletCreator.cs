using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    public GameObject projectilePrefabReference;
    public float thrust = 5f;
    public AudioClip shootSoundReference;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(projectilePrefabReference, transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>().AddForce(-transform.right * thrust, ForceMode.Impulse);

            AudioSource.PlayClipAtPoint(shootSoundReference, Camera.main.transform.position);

            Destroy(projectile, 5.0f);
        }
    }
}
