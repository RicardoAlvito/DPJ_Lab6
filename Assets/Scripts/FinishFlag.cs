using UnityEngine;

public class FinishFlag : MonoBehaviour
{

    public int requiredScore = 5    ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }


    private void OnTriggerEnter(Collider other) {


        if (UIManager.Instance!=null) {

            if (UIManager.Instance.score >= requiredScore)
            {


                Debug.Log("Nivel Complento");
            }
            else {

                Debug.Log("Colento todos os tokens antes complentar o nivel");
            }
        
        }

      
        
    }
}
