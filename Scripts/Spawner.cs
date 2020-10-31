using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    GameObject instantiatedObject;

    GameObject[] blocks;

    [SerializeField] GameObject whiteBlock;
    [SerializeField] GameObject redBlock;
    [SerializeField] GameObject greenBlock;
    [SerializeField] GameObject yellowBlock;

    void Start()
    {
        blocks = new GameObject[3];
        blocks[0] = redBlock;
        blocks[1] = greenBlock;
        blocks[2] = yellowBlock;
        StartCoroutine(SpawnBlocks());
    }
    IEnumerator SpawnBlocks()
    {
        while (true)
        {
            int whiteBlockChance = Random.Range(0, 10);
            if (whiteBlockChance == 1) // whiteBlockChance has a %10 chance to be 1, so it will instantiate white block (which cause to increase score by 5) only 1 times per 10
            {
                instantiatedObject = Instantiate(whiteBlock);
                instantiatedObject.transform.position = new Vector3(Random.Range(-2, 13), 14f, 0f);
            }
            else
            {
                int random = Random.Range(0, 3);
                instantiatedObject = Instantiate(blocks[random]);
                instantiatedObject.transform.position = new Vector3(Random.Range(-2, 13), 14f, 0f);
            }
            yield return new WaitForSeconds(1);
        }
    }
}
