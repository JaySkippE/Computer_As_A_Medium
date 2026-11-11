using UnityEngine;

public class ObjectAppear : MonoBehaviour
{
    public GameObject Pillar; // Assign in Insepctor
    public GameObject Trap; //Assign in Inspector

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Pillar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)

    //Pillar appear when the trap contact with the player
    {
        if (other.CompareTag("Player"))
        {
            Pillar.SetActive(true);
        }
    }
}