using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;

        }
        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }
        public Stuff ()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }

    public Stuff myStuff = new Stuff(50, 5, 5);

    public Stuff myOtherStuff = new Stuff(50, 1.5f);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myStuff.bullets);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
