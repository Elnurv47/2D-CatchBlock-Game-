using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyBlocks : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ColliderToFinish"))
        {                           // All the blocks which are falling have this script and
            Destroy(gameObject);    // they are destroying themselves when they got out of screen
        }                           // Doing this will help us to optimize game and increase fps
    }
}
