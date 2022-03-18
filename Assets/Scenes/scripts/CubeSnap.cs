using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSnap : MonoBehaviour
{
    void Start()
    {
        Snap();
    }

    private void Update()
    {
    }

    public void Snap()
    {
        transform.position = new Vector3(Mathf.Round(transform.position.x * 10) / 10, Mathf.Round(transform.position.y * 10) / 10, Mathf.Round(transform.position.z * 10) / 10);
        transform.rotation = new Quaternion(0,0,0,0);
    }
}
