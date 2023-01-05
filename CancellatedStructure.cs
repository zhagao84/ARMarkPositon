using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
public class CancellatedStructure : MonoBehaviour
{
    [HideInInspector]
    public Material mat;
    MeshRenderer render;
    MeshFilter meshFilter;
    Mesh mesh;
    public List<Transform> pos=new List<Transform>();
    int oricount=0;
    Vector3[] v3s;
    [HideInInspector]
    public TextMeshPro meshPro;
    private void OnEnable()
    {
        transform.AddComponent<MeshRenderer>();
        render =GetComponent<MeshRenderer>();
        transform.AddComponent<MeshFilter>();
        meshFilter =GetComponent<MeshFilter>();
        mesh = new Mesh();
        meshFilter.mesh = mesh;
        render.material = mat;

    }

    public void Add(Transform po)
    {
        pos.Add(po);
    }

    private void Update()
    {
       

        if (pos.Count != oricount) 
        {
           
            Structure();
            oricount= pos.Count;
        }

        for (int i = 0; i < pos.Count; i++)
        {
            v3s[i] = pos[i].localPosition;
        }
        mesh.vertices = v3s;
        if (meshPro.gameObject != null) meshPro.transform.position = pos[pos.Count - 1].position + new Vector3(0,0.07f,0) ;
    }

    public void Structure()
    {
        
        v3s = new Vector3[pos.Count] ;
        for (int i=0;i< pos.Count;i++)
        {
            v3s[i] = pos[i].localPosition;
        }
        mesh.vertices = v3s;
        int[] index = StrucPointData.Point(pos.Count);
        mesh.triangles = index;
        meshFilter.mesh = mesh;
        render.material = mat;

    }
}
