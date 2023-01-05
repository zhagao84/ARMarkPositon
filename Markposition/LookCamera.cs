using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class LookCamera : MonoBehaviour
{
    private void Update()
    {
        transform.forward = (transform.position - Camera.main.transform.position).normalized;
    }
}
