
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using UnityEngine;

public class Csv : MonoBehaviour
{
    string filePath ;
    string createText;

    public void Start()
    {
        filePath = Application.persistentDataPath + @"\Posa.txt";
        print(filePath);
        if (!File.Exists(filePath))
        {
            createText += "X" + "\u3000" + "\u3000" + "\u3000" + "\u3000" + "\u3000" + "\u3000"+
                          "Y" + "\u3000" + "\u3000" + "\u3000" + "\u3000" + "\u3000" + "\u3000"+
                          "Z" + "\u3000" + "\u3000" + "\u3000" +
                             "ID" + "\u3000" + "\u3000" + "\u3000" +
                             "M/P" + Environment.NewLine;
            File.WriteAllText(filePath, createText, Encoding.UTF8);
            PlayerPrefs.SetString("data", createText);
        }
    }   
       

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space)) 
        //{
        //    Save(0.3524f,0.4f,0.789f,6,5);
        //}

        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerPrefs.DeleteKey("data");
        }
       
    }

    private void OnEnable()
    {
        createText = PlayerPrefs.GetString("data"); 
    }

    public void Save(float X, float Y,float Z, int id,int fd)
    {
        createText += X.ToString("f3") + "\u3000" + "\u3000" + "\u3000" +
                      Y.ToString("f3") + "\u3000" + "\u3000" + "\u3000" +
                      Z.ToString("f3") + "\u3000" + "\u3000" + "\u3000" +
                      id.ToString() + "\u3000" + "\u3000" + "\u3000" +
                      fd.ToString() + Environment.NewLine;
        File.WriteAllText(filePath, createText, Encoding.UTF8);
        PlayerPrefs.SetString("data", createText);
    }
}
