using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] Cars;

  


    private void OnEnable()
    {
        StartCoroutine(Spawning());
    }

   

    private IEnumerator Spawning()
    {
        
        while (enabled)
        {
            yield return new WaitForSeconds(Random.Range(1, 7));
            GameObject SpwanedCars =Instantiate(Cars[Random.Range(0, Cars.Length)],transform.position,Quaternion.identity);
            
            Destroy(SpwanedCars, 10);
        }
    }
}
