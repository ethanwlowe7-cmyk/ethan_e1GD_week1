using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            PlatformerControls p = col.GetComponent<PlatformerControls>();
            p.coinsCollected++;
            Debug.Log(p.coinsCollected);
            Destroy(this.gameObject);
            
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
