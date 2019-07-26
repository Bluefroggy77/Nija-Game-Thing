using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRabbleStay : MonoBehaviour
{
    GameObject player;
    LineRenderer line;
    void Start()
    {
        line = gameObject.GetComponent<LineRenderer>();
        player = GameObject.Find("Player");
    }
    void Update()
    {
        line.SetPosition(0, player.transform.position);
    }
}
