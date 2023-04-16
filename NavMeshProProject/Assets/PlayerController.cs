using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;

    public int health;
    public float healthcount;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }

    public void TakeDamage()
    {
        health -= 1;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
        gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);

        Invoke("GoBack", 0.75f);
    }

    public void GoBack()
    {
        gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.white);
    }
}
