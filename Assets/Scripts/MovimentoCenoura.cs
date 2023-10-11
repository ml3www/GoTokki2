using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCenoura : MonoBehaviour
{

    public float velocLaser ;

    // Start is called before the first frame update

    void Start()

    {

     

    }




    // Update is called once per frame

    void Update()

    {

         transform.Translate(Vector3.right * velocLaser * Time.deltaTime);




        if (transform.position.x > 10.91f)
        {

            Destroy(this.gameObject);

        }

             

    }

}