using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectScript : MonoBehaviour
{    
    private void Update()
    {
        gameObject.transform.Rotate(Vector3.up, 0.5f);
    }
}
