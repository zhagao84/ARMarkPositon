using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CreaterPoint : MonoBehaviour
{
    public GameObject point;
    public GameObject text;
    public Transform tar;
    CancellatedStructure cancellatedStructure;
    public Transform parent;
    public Material mat;
    public GameObject setMarkObj;
    public void Create()
    {
        if (cancellatedStructure == null) 
        {
            GameObject cls = new GameObject();
            cls.name = "CancellatedStructure";
            cancellatedStructure = cls.AddComponent<CancellatedStructure>();
            cancellatedStructure.enabled = false;
            cancellatedStructure.mat= mat;
            parent = cancellatedStructure.transform;
        }
        GameObject g= Instantiate(point,tar.position,tar.rotation, parent);
        g.transform.GetChild(0).GetComponent<TextMeshPro>().text = (cancellatedStructure.pos.Count + 1).ToString();
        cancellatedStructure.Add(g.transform);
    }

    public void OpenMesh()
    {
        GameObject tx= Instantiate(text, cancellatedStructure.transform.position, cancellatedStructure.transform.rotation, parent);
        cancellatedStructure.meshPro = tx.transform.GetChild(0).GetComponent<TextMeshPro>();
        SetMark setMark=  Instantiate(setMarkObj, cancellatedStructure.transform.position, cancellatedStructure.transform.rotation, parent).GetComponent<SetMark>();
        setMark.TextMeshPro = cancellatedStructure.meshPro;
        setMark.txts = cancellatedStructure.pos;
        setMark.transform.position = cancellatedStructure.pos[0].position+new Vector3(0,0.07f,0);
        cancellatedStructure.enabled = true;
        cancellatedStructure = null;
    }

    //public void Bj()
    //{
    //    GameObject g = Instantiate(text, tar.position, tar.rotation, parent);
    //}

}
