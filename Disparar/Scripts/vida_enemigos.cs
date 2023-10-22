using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida_enemigos : MonoBehaviour
{
   public int balas_disparadas=0;
   public int balas_necesarias=3;

   private void OnTriggerEnter(Collider other)
   {
       if (other.tag == "bala")
           balas_disparadas += 1; 
       //Destroy(other.gameObject);
       if (balas_necesarias == balas_disparadas)
       {
           GameManager.Instance.AumentarEnemigoMuerto();
           Destroy(this.gameObject);
         
       }


   }
}
