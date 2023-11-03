using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorForHands : MonoBehaviour
{
    private Stats stats;
    private GameObject stats_GameObject;

    public Material newMaterial1;
    public Material newMaterial2;
    public Material newMaterial3;
    public Material newMaterial4;
    public Material newMaterial5;
    public Material newMaterial6;
    public Material newMaterial7;

    private Renderer objectRenderer;

    private void Awake()
    {
        stats_GameObject = GameObject.FindGameObjectWithTag("Stats");
        stats = stats_GameObject.GetComponent<Stats>();
    }

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();

        if (objectRenderer == null)
        {
            Debug.LogError("!!!Eroare la material!!!");
        }
    }

    private void Update()
    {
        if (stats.platform1active)
            objectRenderer.material = newMaterial1;

        if (stats.platform2active)
            objectRenderer.material = newMaterial2;

        if (stats.platform3active)
            objectRenderer.material = newMaterial3;

        if (stats.platform4active)
            objectRenderer.material = newMaterial4;

        if (stats.platform5active)
            objectRenderer.material = newMaterial5;

        if (stats.platform6active)
            objectRenderer.material = newMaterial6;

        if(stats.platform1active == false &&
            stats.platform2active == false &&
            stats.platform3active == false &&
            stats.platform4active == false &&
            stats.platform5active == false &&
            stats.platform6active == false)
            objectRenderer.material = newMaterial7;
    }
}
