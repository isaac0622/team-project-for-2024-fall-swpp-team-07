using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public GameObject key;
    CannonControl cannonControl;
    StageManager gm;

    // Start is called before the first frame update
    void Start()
    {
        cannonControl = FindObjectOfType<CannonControl>();
        gm = FindObjectOfType<StageManager>();
    }

    // Update is called once per frame
    void Update() { }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && cannonControl.spaceBarCount == 1)
        {
            key.SetActive(false);
            gm.SetSuccess();
        }
    }
}
