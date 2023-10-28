using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tinta : MonoBehaviour
{
    public Stats stats;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Sageata"))
        {
            if (stats.platform1active)
                stats.points = stats.points + 1;

            if (stats.platform2active)
                stats.points = stats.points + 3;

            if (stats.platform3active)
                stats.points = stats.points + 5;

            if (stats.platform4active)
                stats.points = stats.points + 9;

            if (stats.platform5active)
                stats.points = stats.points + 14;

            if (stats.platform6active)
                stats.points = stats.points + 25;

            Destroy(other.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
