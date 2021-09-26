using System;
using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;

using Modding;
using static Modding.Logger;
using UnityEngine;

namespace Satchel{
    public class CustomArrowPromptBehaviour : MonoBehaviour {
            public GameObject prompt;
            public PromptMarker promptMarker;
            public Action OnPromptTrigger;
            public bool showing = false;
            void Start(){}

            public void OnTriggerEnter2D(Collider2D col){
                if(col.gameObject == HeroController.instance.gameObject){
                    Show();
                }
            }
            public void OnTriggerExit2D(Collider2D col)
            {
                if(col.gameObject == HeroController.instance.gameObject){
                    Hide();
                }
            }   
            public void Show(){
                if(!showing){
                    if(prompt == null)
                    {
                        prompt = CustomArrowPrompt.GetNewPrompt();
                        prompt.transform.position = gameObject.transform.position + new Vector3(0f, 2f, 0f);
                        prompt.transform.SetParent(gameObject.transform, true);
                        promptMarker = prompt.GetComponent<PromptMarker>();
                    }
                    promptMarker.SetLabel("Listen");
                    promptMarker.SetOwner(gameObject);
                    promptMarker.Show();
                }
                showing = true;
            }
            public void Hide(){
                if(showing){
                    promptMarker.Hide();
                }
                showing = false;
            }

            public void Update(){
                if(showing && !GameManager.instance.isPaused){
                    if(GameManager.instance.inputHandler.inputActions.up.WasPressed || GameManager.instance.inputHandler.inputActions.down.WasPressed){
                        if(OnPromptTrigger != null){
                            OnPromptTrigger();
                        }
                    }
                }
            }
    }

}