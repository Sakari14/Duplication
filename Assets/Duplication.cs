using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplication : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(player, transform.position, Quaternion.identity);
        }
    }
}