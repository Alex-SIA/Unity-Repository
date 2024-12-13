using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 projectileMove;
    public float projectileTimer;
    public GameObject gameManagerObject;
    void Start()
    {
        gameManagerObject = GameObject.Find("GameManager");
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position += projectileMove;
        projectileTimer += Time.deltaTime;
        if (projectileTimer > 3)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
