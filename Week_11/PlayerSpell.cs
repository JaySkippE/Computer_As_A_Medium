using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerSpell : MonoBehaviour
{
    public Animator animator;
    public PlayerMana playerMana;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Spell();
    }
    // Spell Animation Plays, and 10 mana is deducted from mana pool
    void Spell() 
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            animator.SetBool("spell", true);
            playerMana.mana -= 10;
        }
        else
        {
            animator.SetBool("spell", false);
        }
    }
}