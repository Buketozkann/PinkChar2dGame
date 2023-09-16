using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int strawberry = 0;
    private int Bananas_0 = 0;
    [SerializeField] private TMP_Text strawberriesText;
    [SerializeField] private TMP_Text BananasText;

    [SerializeField] private AudioSource collectionsSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.CompareTag("strawberry"))
        {
            collectionsSoundEffect.Play();
            Destroy(collision.gameObject);
            strawberry++;
            strawberriesText.text = "strawberries: " + strawberry;
        }

        else if(collision.gameObject.CompareTag("Bananas_0"))
        {
            collectionsSoundEffect.Play();
            Destroy(collision.gameObject);
            Bananas_0++;
            BananasText.text = "Bananas: " + Bananas_0;
        }
    }
   



}
