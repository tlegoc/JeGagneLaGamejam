using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float speed = 5;
    public Collider2D coll;

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.position += new Vector3(movement.x, movement.y, 0) * Time.deltaTime * speed;

        Collider2D[] list = new Collider2D[10];
        coll.OverlapCollider(new ContactFilter2D(), list);

        foreach (Collider2D c in list)
        {
            GameObject g = c.gameObject;
            if (g != null)
            {
                Debug.Log(g.name);
            }
        }
    }
}
