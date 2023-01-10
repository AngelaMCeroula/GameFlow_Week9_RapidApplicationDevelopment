using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObstacle : MonoBehaviour
{
    public float rotateX;
    public float rotateY;
    public float rotateZ;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateX * Time.deltaTime,rotateY * Time.deltaTime,rotateZ * Time.deltaTime, Space.Self);
    }
}
