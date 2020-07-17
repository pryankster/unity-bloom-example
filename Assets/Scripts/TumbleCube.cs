using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbleCube : MonoBehaviour
{
    // Start is called before the first frame update
    public bool random = true;
    public Vector3 rotate;

    private void Awake()
    {
        if (random) rotate = new Vector3(Random.Range(-180f, 180f), Random.Range(-180f, 180f), Random.Range(-180f, 180f));
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotate * Time.deltaTime, Space.Self);
    }
}
