using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeObjetos : MonoBehaviour
{
    [SerializeField]
    private GameObject _inimigoPrefab;

    [SerializeField]
    private GameObject [] _powerUps;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RotinaGeracaoInimigo());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator RotinaGeracaoInimigo()
    {
        while (1 == 1)
        {
            Instantiate(_inimigoPrefab, new Vector3(Random.Range(14.9f, 26.78f), -3.072122f, 0), Quaternion.identity);
            yield return new WaitForSeconds(3);
        }


    }
}
