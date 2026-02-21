using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class GeoController : MonoBehaviour
{

    string rubix = "Hello guys";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Wold");   
    }

    // Update is called once per frame
   private void Update()
    {
    if (Input.GetKeyUp(KeyCode.W)) {
    }
}       Transform.position += new Vector3(0,  1,  0);
