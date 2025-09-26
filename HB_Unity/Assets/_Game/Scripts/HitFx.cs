using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitFx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Despawn), 1f);   
    }

    private void Despawn()
    {
        Destroy(gameObject);
    }
}
