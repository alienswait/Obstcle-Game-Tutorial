using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    MeshRenderer renderer;
    Rigidbody rigibody;
    [SerializeField] float TimeToWait = 3f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigibody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigibody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimeToWait)
        {
            renderer.enabled = true;
            rigibody.useGravity = true;
        }
        
    }
}
