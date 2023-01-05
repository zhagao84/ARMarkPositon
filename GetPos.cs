using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetPos : MonoBehaviour
{
    public TextMeshPro meshPro;
    private void Update()
    {
        meshPro.text="Y"+ "["+transform.position.y.ToString("f4")+"]";
    }
}
