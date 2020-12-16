using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubble : MonoBehaviour
{
    public GameObject ring;
    private Rigidbody2D player;
    private Transform playerPos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            this.transform.parent = collision.transform;
            transform.position = playerPos.transform.position;
            ring.transform.parent = null;
            //ring.SetActive(false);
            player.gravityScale = -0.2f;
        }
    }
}
