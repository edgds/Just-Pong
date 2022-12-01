using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string upKey = "up";
    public string downKey = "down";
    public string fireKey = "space";
    public bool _readyToFire = false;
    public GameObject _fakeBall;
    public Ball _ball;
    public int _score = 0;
    public Text _scoreText;


    // Start is called before the first frame update
    void Start()
    {
        if (_readyToFire)
            _fakeBall.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //check control keys
      if (Input.GetKey(upKey) && transform.position.y < 3.5f)
       //if (Input.GetKey(upKey))
        {
            //2 dimensional movement 
            transform.Translate(new Vector2(0f, 0.1f));
        }
      else if (Input.GetKey(downKey) && transform.position.y > -3.5f)
       //else if (Input.GetKey(downKey))
        {
            transform.Translate(new Vector2(0f, -0.1f));
        }
       else if (Input.GetKey(fireKey))
        {
            if(_readyToFire)
                FireBall();
        }
    }

    void FireBall()
    {
        _readyToFire = false;
        _fakeBall.SetActive(false);
        // spawn new ball from the prefab

        Ball newBall = Instantiate(_ball, _fakeBall.transform.position, Quaternion.identity);

        float angle;
        if (transform.position.x < 0.0f)
            angle = Mathf.Deg2Rad * Random.Range(-30, 30);

        else
            angle = Mathf.Deg2Rad * Random.Range(150, 210);

        Vector2 force = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

        newBall.GetComponent<Rigidbody2D>().AddForce(force * 1.0f);
    }

    public void Score()
    {
        _readyToFire = true;
        _fakeBall.SetActive(true);

        //increment score:
        _score++;

        _scoreText.text = _score.ToString();
    }

}
