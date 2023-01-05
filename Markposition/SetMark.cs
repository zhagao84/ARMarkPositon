using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Microsoft.MixedReality.Toolkit.UI;
public class SetMark : MonoBehaviour
{
  //  public InputField field;
    public GameObject toggle;
    [HideInInspector]
    public string id;//Ãû³Æ
    int idc;
    [HideInInspector]
    [Range(0,1)]
    public int state;//Ìî»òÕßÍÚ
    public TextMeshProUGUI hint;
    [HideInInspector]
    public TextMeshPro TextMeshPro;
    public PinchSlider pinchSlider;
    public List<Transform> txts=new List<Transform>();
    public GameObject openTxt;
    Csv csv;

    private void Awake()
    {
        csv = GameObject.FindObjectOfType<Csv>();
    }
    public void Set()
    {
         
            id = GameObject.FindObjectsOfType<CancellatedStructure>().Length.ToString();
     //   idc = GameObject.FindObjectsOfType<CancellatedStructure>();
            hint.text = id;
            if (toggle.gameObject.activeSelf)
            {
                state = 1;
                TextMeshPro.text = "[" + "ID:" + id + "]" + "[" + "digging" + "]";
            }

            else 
            {
                TextMeshPro.text = "[" + "ID:" + id + "]" + "[" + "dumping" + "]";
                state = 0;
            }

        float x = txts[txts.Count - 1].gameObject.transform.position.x;
        float y = txts[txts.Count - 1].gameObject.transform.position.y;
        float z = txts[txts.Count - 1].gameObject.transform.position.z;
        csv.Save(x,y,z,int.Parse(id), state);
    }

    private void Update()
    {
       
        for (int i=0;i< txts.Count;i++)
        {
            txts[i].GetChild(1).gameObject.SetActive(openTxt.activeSelf);
            txts[i].GetChild(1).GetComponent<TextMeshPro>().transform.localScale =new Vector3(Mathf.Clamp(pinchSlider.SliderValue, 0.005f, pinchSlider.SliderValue*0.02f), Mathf.Clamp(pinchSlider.SliderValue, 0.005f, pinchSlider.SliderValue* 0.02f), Mathf.Clamp(pinchSlider.SliderValue, 0.005f, pinchSlider.SliderValue * 0.02f))  ;
        }
    }

}
