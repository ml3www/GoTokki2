using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Player : MonoBehaviour
{
    
    public float veloc  ;
    public float entradaHorizontal;
    public float entradaVertical;
    public GameObject pfLaser;
    public GameObject _disparoTriploPreFab;
 
    public float tempoDeDisparo = 0.3f;
    public float podeDisparar = 0.3f;
 
    public bool possoDarDisparoTriplo = false;

    public int vida = 3;
 
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Método Start de "+this.name);
        veloc = 3.0f;
        transform.position = new Vector3(0,0,0);
 
    }
 
    // Update is called once per frame
    void Update()
    {
        Movimento();

        if (Input.GetKeyDown(KeyCode.Space))
        {





            if (Time.time > podeDisparar)
            {

                if (possoDarDisparoTriplo == true)
                {

                    Instantiate(_disparoTriploPreFab, transform.position + new Vector3(0, 0, 0), Quaternion.identity);

                }
                else
                {
                    Instantiate(pfLaser, transform.position + new Vector3(1.8f, 0, 0), Quaternion.identity);
                }




                podeDisparar = Time.time + tempoDeDisparo;





            }
        }

    }
 
    private void Movimento() {
 
        entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * veloc * Time.deltaTime * entradaHorizontal );
 
        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * veloc * Time.deltaTime * entradaVertical );
 
        if ( transform.position.y > -3.62f ) {
            transform.position = new Vector3(transform.position.x,-3.62f,0);
        }
 
        if ( transform.position.y < -3.62f){
            transform.position = new Vector3(transform.position.x,-3.62f,0);
        }
 
        if ( transform.position.x > 7.5f){
            transform.position = new Vector3(7.5f,transform.position.y,0);
        }
 
         if ( transform.position.x < -7.5f){
            transform.position = new Vector3(-7.5f,transform.position.y,0);
       
        }
 
    }
    public void AtivarTiroTriplo()
    {
        possoDarDisparoTriplo = true;
    }

    public IEnumerator DisparoTriploRotina()
    {
        yield return new WaitForSeconds(7.0f);
        possoDarDisparoTriplo = false;

    }

    public void LigarPUDisparoTriplo()
    {
        possoDarDisparoTriplo = true;

        StartCoroutine(DisparoTriploRotina());

    }

    public void DanoAoPlayer()
    {
        vida--;

        if ( vida < 1)
        {
            Destroy(this.gameObject);
        }




    }

} 