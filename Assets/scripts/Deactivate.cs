using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
    public Animator anim;

    void Deativate()
    {
        anim.enabled = false;
    }
}
