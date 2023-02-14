using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coinRotate : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.left, 45 * Time.deltaTime * 1);

    }
}
