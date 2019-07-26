using UnityEngine;

public class Grapple : MonoBehaviour
{
    public float PullPower;
    Rigidbody2D rb;
    public LineRenderer Line;
    Vector2 aim;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 MousePos2D = new Vector2(MousePos.x, MousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(MousePos2D, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject != gameObject && hit.collider.tag == "grab")
            {
                aim = new Vector2(MousePos2D.x - transform.position.x, MousePos2D.y - transform.position.y);
                aim = aim / aim.magnitude;
                rb.AddForce(aim * PullPower);
                Line.SetPosition(1, MousePos2D);
            }
        }
    }
}
