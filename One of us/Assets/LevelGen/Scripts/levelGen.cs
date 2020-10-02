using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

public class levelGen : MonoBehaviour
{
    // Varibles
    public GameObject levelCube;
    public string levelByte = "0011";
    public int chunkSize;
    public bool askForFile = false;

    private float xPOS, zPOS, yPOS;

    // Start is called before the first frame update
    void Start()
    {
        if(askForFile) loadLevel();
        makeChunk();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void loadLevel()
    {
        string levelPath = EditorUtility.OpenFilePanel("Open Level", "", "map");
        if(levelPath != null)
        {
            WWW www = new WWW("file:///" + levelPath);
            levelByte = www.text;
        }

        GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<playerCamera>().lockMouse();
    }

    private void makeChunk()
    {
        int normIndex = 0;

        for (int i = 0; i < levelByte.Length; i++)
        {
            if(levelByte[i] == '0')
            {
                xPOS++;
            }
            if (levelByte[i] == '1')
            {
                Instantiate(levelCube, new Vector3(xPOS, yPOS, zPOS) + transform.position, Quaternion.identity);
                xPOS++;
            }
            if(xPOS >= chunkSize)
            {
                zPOS++;
                xPOS = 0;
            }

            normIndex++;

            if(normIndex >= (chunkSize * chunkSize))
            {
                normIndex = 0;
                yPOS++;
                zPOS = 0;
            }
        }
    }
}
