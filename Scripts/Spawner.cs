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

    [SerializeField] GameObject increaseScoreByFive;
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
            int otherRandom = Random.Range(0, 10);
            if (otherRandom == 1)
            {
                instantiatedObject = Instantiate(increaseScoreByFive);
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
