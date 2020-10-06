using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationevents : MonoBehaviour
{

    public GameObject LyricBox;
    private parselyrics parser;
    public Camera LyricCamera;
    public Animator CameraController;

    void Awake()
    {
        parser = LyricBox.GetComponent<parselyrics>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        CameraController = LyricCamera.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            CameraController.enabled=true;
        }
    }

    public void nextLines(){
        Debug.Log("OK");
        parser.updateTexts();
        //LyricBox.SetActive(false);
    }

    public void lineEnd(){
        CameraController.enabled=false;
    }

}
