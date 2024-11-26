using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FruitSceneController : MonoBehaviour
{
    public GameObject fruitCollection;
    public static int fruitsRemaining;

    public TextMeshProUGUI textFruitsTotal;
    public TextMeshProUGUI textFruitsCollected;


    void Start()
    {
       fruitsRemaining = fruitCollection.gameObject.transform.childCount;
       textFruitsTotal.text = fruitCollection.gameObject.transform.childCount.ToString();
        checkFruitsRemaining();
    }

    public void checkFruitsRemaining()
   {
      textFruitsCollected.text = (int.Parse(textFruitsTotal.text) - fruitsRemaining).ToString();
   }
}
