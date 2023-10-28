using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextPoints : MonoBehaviour
{
    public Stats stats;

    public TextMeshProUGUI textPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textPoints.text = stats.points.ToString();
    }
}
