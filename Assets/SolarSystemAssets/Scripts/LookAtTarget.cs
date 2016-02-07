﻿using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour
{
  public static GameObject target; // the target that the camera should look at

  void Start()
  {
    //Si target es nulo seleccionamos target
    if (target != null)
      return;

    target = this.gameObject;
    Debug.Log("LookAtTarget target not specified. Defaulting to parent GameObject");
  }

  // Update is called once per frame
  void Update()
  {
    if (target)
      transform.LookAt(target.transform);
  }
}