using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed = 3;
    public float frequency = 1.0f;
    public float magnitude = 0.5f;

    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos += transform.up * Time.deltaTime * speed;
        transform.position = pos + transform.right * Mathf.Sin(Time.time * frequency) * magnitude;
    }
}
