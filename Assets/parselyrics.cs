using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class parselyrics : MonoBehaviour
{

public InputField iField;
public string lyrics;
public List<string> lyricsArray = new List<string>();
public int currentTextField=0;
public int currentLine=0;
public int totalTextFields=6;
public int lineNum=0;
public string line="";
public int totalLines=0;

public TextMeshPro t0;
public TextMeshPro t1;
public TextMeshPro t2;
public TextMeshPro t3;
public TextMeshPro t4;
public TextMeshPro t5;

    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro t0 = GetComponent<TextMeshPro>();
        TextMeshPro t1 = GetComponent<TextMeshPro>();
        TextMeshPro t2 = GetComponent<TextMeshPro>();
        TextMeshPro t3 = GetComponent<TextMeshPro>();
        TextMeshPro t4 = GetComponent<TextMeshPro>();
        TextMeshPro t5 = GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void readTextFileLines() {

        lyrics = iField.text;
        Debug.Log(lyrics);

        string[] linesInFile = lyrics.Split('\n');
        foreach (string line in linesInFile)
        {
            lyricsArray.Add(line);
            totalLines++;
        }
        updateTexts();
        
    }

    public void updateTexts(){


    if(lineNum<totalLines){
            

        Debug.Log(lyricsArray[lineNum]);
        
        t0.SetText(lyricsArray[lineNum]);
        t1.SetText(lyricsArray[lineNum+1]);
        t2.SetText(lyricsArray[lineNum+2]);
        t3.SetText(lyricsArray[lineNum+3]);
        t4.SetText(lyricsArray[lineNum+4]);
        t5.SetText(lyricsArray[lineNum+5]);

        lineNum+=6;
    }

        

    }

}