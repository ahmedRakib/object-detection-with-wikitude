using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCATrough : MonoBehaviour
{
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(0.16f, 0.84f, -0.75f);
        //gameObject.transform.position = startPosition;
        //transform.position = new Vector3(0, 0, 0);
        //transform.localScale = new Vector3(0.5f, 0.5f, -0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        startPosition = new Vector3(0.16f, 0.84f, -0.75f);
        gameObject.transform.position = startPosition;
        //startPosition = new Vector3(0.16f, 0.84f, -0.75f);
        //transform.position = startPosition;
        //transform.localScale = new Vector3(0.5f, 0.5f, -0.5f);
    }
}
