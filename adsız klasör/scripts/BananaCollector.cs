using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BananaCollector : MonoBehaviour
{
    private int Bananas_0 = 0;
    [SerializeField] private TMP_Text BananasText;

    [SerializeField] private AudioSource collectionsSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.CompareTag("Bananas_0"))
        {
            collectionsSoundEffect.Play();
            Destroy(collision.gameObject);
            Bananas_0++;
            BananasText.text = "Bananas_0: " + Bananas_0;
        }
    }
}