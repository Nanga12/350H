using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.UIElements;

public class Circle : MonoBehaviour
{
    [SerializeField] float movingSpeedPerSecond = 5;
    float screenLeft, screenRight, screenTop, screenBottom;
    float colliderHalfWidth, colliderHalfHeight;

    // Start is called before the first frame update
    void Start()
    {
        ScreenUtilsScript.Initialize();

        
        CircleCollider2D collider = GetComponent<CircleCollider2D>();
        Vector3 circleColliderDim = collider.bounds.max - collider.bounds.min;

        colliderHalfWidth = circleColliderDim.x / 2;
        colliderHalfHeight = circleColliderDim.y / 2;

        Debug.Log(screenLeft + " " + screenRight + " " + screenBottom + " " + colliderHalfHeight + " " + colliderHalfHeight);


    }



    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        // transform.position = position;
        float horizontalInput = Input.GetAxis("Horizontal");
        position.x += horizontalInput * movingSpeedPerSecond * Time.deltaTime;
        transform.position = position;


        float verticalInput = Input.GetAxis("Vertical");
        position.y += verticalInput * movingSpeedPerSecond * Time.deltaTime;
        transform.position = position;


        CheckBounds();

    }

    void CheckBounds()
    {
        Vector3 position = transform.position;

        if (position.x - colliderHalfWidth < ScreenUtilsScript.ScreenLeft)
        {
            position.x = ScreenUtilsScript.ScreenLeft + colliderHalfWidth;
        }

        if (position.x + colliderHalfWidth > ScreenUtilsScript.ScreenRight)
        {
            position.x = ScreenUtilsScript.ScreenRight - colliderHalfWidth;
        }
        if (position.y - colliderHalfHeight < ScreenUtilsScript.ScreenBottom)
        {
            position.y = ScreenUtilsScript.ScreenBottom + colliderHalfHeight;
        }

        if (position.y + colliderHalfHeight > ScreenUtilsScript.ScreenTop)
        {
            position.y = ScreenUtilsScript.ScreenTop - colliderHalfHeight;
        }

        transform.position = position;
    }


}
