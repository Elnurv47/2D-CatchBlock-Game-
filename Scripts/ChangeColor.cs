using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    int i = 1;

    Renderer cubeRenderer;

    [SerializeField] GameObject mainCube;
    void Start()
    {
        cubeRenderer = mainCube.GetComponent<Renderer>();
        StartCoroutine(ColorChange());
    }
    IEnumerator ColorChange()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            switch (i)
            {
                case 1:
                    cubeRenderer.material.SetColor("_Color", Color.green);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
                    break;
                case 2:
                    cubeRenderer.material.SetColor("_Color", Color.yellow);
                    break;
                case 3:
                    cubeRenderer.material.SetColor("_Color", Color.red);
                    break;
                default: i = 0; break;
            }
            i++;
        }
    }
}
