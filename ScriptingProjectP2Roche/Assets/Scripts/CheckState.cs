using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject Sphere;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active Self: " + Sphere.activeSelf);
        Debug.Log("Active in Hierarchy" + Sphere.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
