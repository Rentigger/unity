using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject sourceGo;//切割的物体
    public GameObject slicerGo;//切片物体
    public Material sectionMat;//切面材质

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Console.WriteLine("000000000");
            Vector3 sp = slicerGo.transform.position;
            Vector3 su = new Vector3(slicerGo.transform.rotation.x, slicerGo.transform.rotation.y+90, slicerGo.transform.rotation.z);
            SlicedHull hull = sourceGo.Slice(sp,su);
            //GameObject upper = hull.CreateUpperHull(sourceGo, sectionMat);
            GameObject lower = hull.CreateLowerHull(sourceGo, sectionMat);
            //upper.transform.position.Set(upper.transform.position.x+100, upper.transform.position.y + 100, upper.transform.position.z + 100);
            //lower.transform.position.Set(lower.transform.position.x - 100, lower.transform.position.y - 100, lower.transform.position.z - 100);
            slicerGo.SetActive(false);
            sourceGo.SetActive(false);
        }

    }
}
