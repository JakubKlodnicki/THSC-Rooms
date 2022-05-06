using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doors : MonoBehaviour
{
    [SerializeField] private Sprite ClosedDoors;
    [SerializeField] private Sprite OpenDoors;
    [SerializeField] private SpriteRenderer Door;
    bool isOpened = false;
    private void Start()
    {
        if (isOpened == false)
        {
            Door.sprite = ClosedDoors;
        }
}
    private void OnTriggerEnter2D(Collider2D other)
    {
       if(isOpened == false)
        {
            isOpened = true;
            Door.sprite = OpenDoors;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (isOpened == true)
        {
            isOpened = false;
            Door.sprite = ClosedDoors;
        }
    }
    private void Update()
    {
        
    }
}