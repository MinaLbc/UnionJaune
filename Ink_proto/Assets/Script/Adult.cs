using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adult : MonoBehaviour
{
    public float Speed;
    public Vector3 StartPosition;
    public Vector3 EndPosition;
    public float Distance;

    void Start()
    {
    	StartPosition = this.transform.position;
        EndPosition = StartPosition;

    }

    public void StartMove(Vector3 hit_position)
    {   
        
        this.transform.LookAt(hit_position);

        StartPosition = this.transform.position;
        EndPosition = hit_position;

        Distance = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 m_position = Input.mousePosition;

            RaycastHit r_out;
            Ray r_mouse = Camera.main.ScreenPointToRay(m_position);

            if (Physics.Raycast(r_mouse, out r_out)){
                if (r_out.collider.gameObject.CompareTag("Floor")) {
                    Vector3 hit_position = r_out.point;
                    StartMove(hit_position);
                }
                
            }
        }

        Distance += Time.deltaTime * Speed;
        this.transform.position = Vector3.Lerp(StartPosition, EndPosition, Distance);
        
    }
}
