using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAenemy : MonoBehaviour
{
    private float _velocidade = 6.0f;

    [SerializeField]
    private GameObject _explosaoDoInimigo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        transform.Translate(Vector3.left * _velocidade * Time.deltaTime);

        if ( transform.position.x < -11.7f)
        {
            transform.position = new Vector3(Random.Range(14.9f, 26.78f), -3.072122f, 0);
        }


    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if( other.tag == "Tiro")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }

        if ( other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                player.DanoAoPlayer();
            }
        }

        Destroy(this.gameObject);

        Instantiate(_explosaoDoInimigo, transform.position, Quaternion.identity);


    }
}
