using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class carExample : MonoBehaviour
{
    Rigidbody2D rb2d;
    displayObject disp;
    float maxSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        disp = GetComponent<displayObject>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("example");
        }
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        if (y != 0)
            disp.rotation += new Vector3(0, 0, -x * 4);
            
        GameObject body = transform.GetChild(transform.childCount-1).Find("part0").gameObject;
        transform.GetChild(0).transform.rotation = body.transform.rotation;
        
        transform.position += body.transform.right/maxSpeed*y;
        
    }
}
