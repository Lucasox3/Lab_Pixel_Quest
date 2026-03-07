using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.SceneManagement;
public class GeoController : MonoBehaviour
{
    Rigidbody2D RB;
    string rubix = "Hello guys";
    public float speed;
    public string nextlevel = "level 2";
    // Start is called before the first frame update
    void Start()
    {RB= GetComponent<Rigidbody2D>();
        Debug.Log("Hello Wold");
    }

    // Update is called once per frame
    private void Update() {

        float xInput = Input.GetAxis("Horizontal");
      
        RB.velocity = new Vector2 (xInput * speed, RB.velocity.y);  
        /*
        if (Input.GetKeyUp(KeyCode.W))
        {

            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {

            transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {

            transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {

            transform.position += new Vector3(1, 0, 0);
        }
    */

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit");
        switch (collision.tag)
        {
            case "Death":
                string levelname = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(levelname);
                Debug.Log("You died");
                break;
            case "Coin":
                Debug.Log("+1");
                break;
            case "Finish":

                SceneManager.LoadScene(nextlevel);
                break;
        }

    }
    


}
