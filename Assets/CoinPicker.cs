using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{

private float coin = 0;

 private void OnTriggerEnter2D(Collider2D other) {
     Debug.Log("HERE");
     Debug.Log(other.gameObject.tag);
     if (other.gameObject.CompareTag("Coin")){
         Destroy(other.gameObject);
     }
 }
}
