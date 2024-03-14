using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    static int numCollision = 0;
    const float MinImpulseForce = 3.0f;
    const float MaxImpulseForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        /*Debug.Log("This is the first game");
        Vector3 position = transform.position;
        position.x = 5;
        transform.position = position;

        transform.localScale *= 2;*/

        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(magnitude * direction, ForceMode2D.Impulse);
        //Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        //rb2d.AddForce(new Vector2(-10, 0), ForceMode2D.Impulse);
        //rb2d.AddForce(new Vector2((Mathf.Cos(Random.Range(0, 2*Mathf.PI))*Random.Range(-3, 3)), (Mathf.Sin(Random.Range(0, 2*Mathf.PI)) * Random.Range(-3, 3))), ForceMode2D.Impulse);
    }


    // Update is called once per frame
    void Update()
    {
        //if (numCollision == 20)
       // {
            //UnityEditor.EditorApplication.isPaused = true;
       // }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        numCollision++;
        Debug.Log("Number of collisons" + numCollision);

    }

}