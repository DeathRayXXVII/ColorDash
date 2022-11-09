using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
  private Image img;
  public UnityEvent startEvent;

  private void Start()
  {
    img = GetComponent<Image>();
    startEvent.Invoke();
  }

  public void UpdateImage(floatData obj)
  {
    img.fillAmount = obj.value;
  }
}
