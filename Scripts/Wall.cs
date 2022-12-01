using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Player _player; //reference player class

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Wall deteted collision");
        //Destory the ball
        Destroy(collision.gameObject);

        //
        _player.Score();
    }
}
