using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartInfo
{
    public Part part;
}
public class Enemy : MonoBehaviour
{
    PartInfo[] partInfo;
    void Start()
    {
        for(int i = 0; i < partInfo.Length; i++)
        {
            partInfo[i].part.PartIndex = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
