              
using UnityEngine;



    // Start is called before the first frame update
  
    public interface IDamageable
    {
        void TakeHit(float damage, RaycastHit2D hit);
    }

