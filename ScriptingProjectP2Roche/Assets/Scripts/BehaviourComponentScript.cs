using System.Collections;
using UnityEngine;

public class BehaviourComponentScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
         {
            GetComponent<Renderer>().material.color = Color.red;
         }
        if (Input.GetKeyDown(KeyCode.G))
         {
            GetComponent<Renderer>().material.color = Color.green;
         }
        if(Input.GetKeyDown(KeyCode.B))
         {
            GetComponent<Renderer>().material.color = Color.blue;
         }
        if (Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
    }
}