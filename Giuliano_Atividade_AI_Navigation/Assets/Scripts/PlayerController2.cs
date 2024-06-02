using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerController2 : MonoBehaviour
{
    Camera cam;
    NavMeshAgent agent;

    private void Start()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
