using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 upDirection;
    public Vector3 downDirection;
    public Vector3 leftDirection;
    public Vector3 rightDirection;
    public GameObject upBulletPrefab;
    public GameObject downBulletPrefab;
    public GameObject leftBulletPrefab;
    public GameObject rightBulletPrefab;
    public Vector3 upOffSet;
    public Vector3 downOffSet;
    public Vector3 leftOffSet;
    public Vector3 rightOffSet;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position += upDirection;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().position += downDirection;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position += leftDirection;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position += rightDirection;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Instantiate(upBulletPrefab, GetComponent<Transform>().position+ upOffSet,Quaternion.identity);
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Instantiate(downBulletPrefab, GetComponent<Transform>().position + downOffSet,Quaternion.Euler(0, 0, 180));
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Instantiate(leftBulletPrefab, GetComponent<Transform>().position+ leftOffSet, Quaternion.Euler(0, 0, 90));
            
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Instantiate(rightBulletPrefab, GetComponent<Transform>().position + rightOffSet, Quaternion.Euler(0, 0, 270));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        
    }
}
