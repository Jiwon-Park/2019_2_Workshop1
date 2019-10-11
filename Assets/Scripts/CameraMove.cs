using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    public Vector3 relative;
    public Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(rotation);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + relative;
        
    }
}
