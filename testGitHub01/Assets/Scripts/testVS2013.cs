using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testVS2013 : MonoBehaviour
{
    Transform _transform;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("aaaaaaaaaaaaaaa");
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _transform.Rotate(Vector3.up * speed);
    }
}
