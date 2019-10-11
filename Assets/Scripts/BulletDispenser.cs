using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDispenser : MonoBehaviour
{
    public float interval = 1f;
    public GameObject bullet;
    public Transform shootPoint;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }
    IEnumerator Shoot()
    {
        while(true)
        {
            Instantiate(bullet, shootPoint.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }
    }
}
